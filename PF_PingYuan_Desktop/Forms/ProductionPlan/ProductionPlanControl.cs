using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.ComponentModel.DataAnnotations;
using PF_PingYuan_Desktop.Models;
using PF_PingYuan_Desktop.Dao;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using PF_PingYuan_Desktop.Forms.ProductionPlan.Operations;
using PF_PingYuan_Desktop.DataModels;
using PF_PingYuan_Desktop.OpcUa;
using PF_PingYuan_Desktop.Setting;
using OpcUaClient;
using DevExpress.XtraBars.Docking2010;

namespace PF_PingYuan_Desktop.Forms.ProductionPlan
{
	public partial class ProductionPlanControl : DevExpress.XtraEditors.XtraUserControl
	{
		private delegate void MonitorCountAction(int? tatalNum, int count);

		private readonly ProductionPlanDao m_productionPlanDao;
		private readonly ProductionInfoDao m_productionInfoDao;
		private XMLSettings m_xmlSettings;
		private AddForm4 m_addProductionPlanForm;
		private OpcClient opcClient;
		public BindingList<Models.ProductionPlan> m_productionPlanList;
		public List<Models.ProductionPlan> productionPlans;
		private readonly object obj = new object();
		private bool _isStop = false;
		private int m_focusedRowHandle = 0;

		public ProductionPlanControl()
		{
			InitializeComponent();
			m_productionPlanDao = new ProductionPlanDao();
			m_productionPlanList = new BindingList<Models.ProductionPlan>();
			productionPlans = new List<Models.ProductionPlan>();
			m_productionInfoDao = new ProductionInfoDao();
			opcClient = new OpcClient();
			string batchNo = DateTime.Now.ToString("yyyyMMdd");
			productionPlans = m_productionPlanDao.GetDataSourceList(batchNo);
			gridControl.DataSource = productionPlans;

			Dictionary<object, string> dicButtons = new Dictionary<object, string>();
			dicButtons.Add("Up", "上件");
			dicButtons.Add("Stop", "暂停");
			//dicButtons.Add("Finish", "结束上件");
			RepositoryItemButtonEdit ribe = ItemOperation.CreateRepositoryItemButtonEdit(dicButtons);
			ribe.ButtonClick += new ButtonPressedEventHandler(this.ribe_ButtonClick);   //绑定事件

			this.gridView.Columns["Operating"].ColumnEdit = ribe;

			m_xmlSettings = new XMLSettings();
			m_xmlSettings.ReadXMLSettings();


			if (opcClient.WriteDataToOpcServer(m_xmlSettings.Count, (ushort)0))
				opcClient.WriteDataToOpcServer(new Models.ProductionPlan
				{
					BatchNo = "0",
					WorkpieceType = "0",
					PrimerColor = "0",
					PigmentedCoatingColor = "0",
					VarnishColor = "0",
					WorkpieceNo = "0",
					PrimerFirm = "0",
					PrimerCraft = "0",
					PigmentedCoatingFirm = "0",
					PigmentedCoatingCraft = "0",
					VarnishFirm = "0",
					VarnishCraft = "0",
					TotalNum = 0
				});

			Task t1 = Task.Run(() =>
			{

				byte data = 0;
				while (data < 128)
				{
					try
					{
						opcClient.WriteDataToOpcServer(m_xmlSettings.Heartbeat, data);
						data++;
						if (data == 128)
						{
							data = 0;
						}

					}
					catch (Exception ex)
					{
						LogManager.WriteLog(LogFile.Warning, $"t1:{ex.Message}");
					}
				}
			});

			Task t2 = Task.Run(() =>
			{
				while (true)
				{
					try
					{
						short tagInitializationNo202 = Convert.ToInt16(opcClient.ReadData(m_xmlSettings.TagInitializationNo202).Value);
						short tagInitializationNo203 = Convert.ToInt16(opcClient.ReadData(m_xmlSettings.TagInitializationNo203).Value);

						if (tagInitializationNo202 >= tagInitializationNo203)
						{
							int value = tagInitializationNo202 <= 454 ? 454 : tagInitializationNo202;
							opcClient.WriteStrDataToOpcServer(m_xmlSettings.TagInitializationNo203, $"{value}");
						}
					}
					catch (Exception ex)
					{
						LogManager.WriteLog(LogFile.Warning, $"t2:{ex.Message}");
					}
				}
			});

		}
		void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
		{
			switch (e.Button.Properties.Caption)
			{
				case "添加记录":
					m_addProductionPlanForm =
						(m_addProductionPlanForm == null || m_addProductionPlanForm.IsDisposed) ? new AddForm4(this) : m_addProductionPlanForm;
					m_addProductionPlanForm.Show();
					break;
				case "批量导入":
					ImportExcel();
					Console.WriteLine("批量导入");
					break;
				case "删除":
					DeleteSelect();
					break;
				case "刷新":
					string batchNo = DateTime.Now.ToString("yyyyMMdd");
					productionPlans = m_productionPlanDao.GetDataSourceList(batchNo);
					gridControl.DataSource = productionPlans;
					break;
				case "上移":
					MoveUp();
					break;
				case "下移":
					MoveDown();
					break;
				case "全部上件":
					if (MessageBox.Show("确认全部上件？","提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
					{
						e.Button.Properties.Enabled = false;
						InstallAllWorkpiece();
					}
					break;
				case "漏读":
					if (MessageBox.Show("确认出现漏读？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
					{
						 short result = opcClient.ReadDataFromOpcServer(m_xmlSettings.Count);
						opcClient.WriteDataToOpcServer(m_xmlSettings.Count, (ushort)(result + 1));
					}
					break;
			}
		}

		private void MoveDown()
		{
			int dsRowIndex = this.gridView.GetFocusedDataSourceRowIndex();
			if (this.gridView.IsLastRow == true)
			{   //当前节点是第一个节点,不用上移
				return;
			}
			Models.ProductionPlan role = this.gridView.GetFocusedRow() as Models.ProductionPlan;
			if (role != null)
			{
				//role.SID = role.SID + 1;
				//tService.SaveRole(role);
				//
				int tIndex = dsRowIndex + 1;
				int tRowHandle = this.gridView.GetRowHandle(tIndex);
				Models.ProductionPlan t_role = this.gridView.GetRow(tRowHandle) as Models.ProductionPlan;
				//t_role.SID = t_role.SID - 1;
				//tService.SaveRole(t_role);
				//显示
				List<Models.ProductionPlan> roleList = this.gridControl.DataSource as List<Models.ProductionPlan>;
				int selectIndex = roleList.IndexOf(role);
				roleList[selectIndex] = roleList[selectIndex + 1];
				roleList[selectIndex + 1] = role;
				//
				productionPlans = roleList;
				this.gridControl.DataSource = roleList;
				this.gridControl.RefreshDataSource();
				this.gridView.MoveNext();
			}
		}

		/// <summary>
		/// 上移
		/// </summary>
		private void MoveUp()
		{
			int dsRowIndex = this.gridView.GetFocusedDataSourceRowIndex();
			if (this.gridView.IsFirstRow == true)
			{   //当前节点是第一个节点,不用上移
				return;
			}
			//this.gridView.GetFocusedRow
			Models.ProductionPlan role = this.gridView.GetFocusedRow() as Models.ProductionPlan;
			if (role != null)
			{
				//
				int tIndex = dsRowIndex - 1;
				int tRowHandle = this.gridView.GetRowHandle(tIndex);
				Models.ProductionPlan t_role = this.gridView.GetRow(tRowHandle) as Models.ProductionPlan;
				//t_role.SID = t_role.SID + 1;
				//tService.SaveRole(t_role);
				//
				//显示
				List<Models.ProductionPlan> roleList = this.gridControl.DataSource as List<Models.ProductionPlan>;
				int selectIndex = roleList.IndexOf(role);
				roleList[selectIndex] = roleList[selectIndex - 1];
				roleList[selectIndex - 1] = role;
				//
				productionPlans = roleList;
				this.gridControl.DataSource = roleList;
				this.gridControl.RefreshDataSource();
				this.gridView.MovePrev();
			}

		}


		/// <summary>
		/// 全部上件
		/// </summary>
		private void InstallAllWorkpiece()
		{
			_isStop = false;
			if (m_xmlSettings == null)
			{
				m_xmlSettings = new XMLSettings();
				m_xmlSettings.ReadXMLSettings();
			}

			opcClient.WriteDataToOpcServer(m_xmlSettings.Count, (ushort)0);

			int rowCount = this.gridView.RowCount;
			productionPlans = new List<Models.ProductionPlan>();
			for (int i = 0;i < rowCount;i ++)
			{
				Models.ProductionPlan productionPlan = this.gridView.GetRow(i) as Models.ProductionPlan;
				productionPlans.Add(productionPlan);
			}

			Task t = Task.Run(() =>
			{
				for (int i = 0; i < productionPlans.Count; i++)
				{
					Models.ProductionPlan production = productionPlans[i];
					opcClient.WriteDataToOpcServer(production);
					int result = 0;
					while (production.TotalNum > result)
					{
						result = opcClient.ReadDataFromOpcServer(m_xmlSettings.Count);
						RunInMainthread(() =>
						{
							this.lbl_CurrentInstall.Text = $"当前上件的程序号:{production.WorkpieceType},已经上件{result}";
							this.gridView.FocusedRowHandle = i;
						});

						if (_isStop)
						{
							RunInMainthread(() =>
							{
								this.lbl_CurrentInstall.Text = $"当前没有上件";
							});
							return;
						}
					}

					if (production.TotalNum <= result)
					{
						if (opcClient.WriteDataToOpcServer(m_xmlSettings.Count, (ushort)0))
							opcClient.WriteDataToOpcServer(new Models.ProductionPlan
							{
								BatchNo = "0",
								WorkpieceType = "0",
								PrimerColor = "0",
								PigmentedCoatingColor = "0",
								VarnishColor = "0",
								WorkpieceNo = "0",
								PrimerFirm = "0",
								PrimerCraft = "0",
								PigmentedCoatingFirm = "0",
								PigmentedCoatingCraft = "0",
								VarnishFirm = "0",
								VarnishCraft = "0",
								TotalNum = 0
							});
						RunInMainthread(() =>
						{
							foreach (var windowsUIButton in this.windowsUIButtonPanel.Buttons)
							{
								if (windowsUIButton.GetType() == typeof(WindowsUIButton))
								{
									WindowsUIButton button = (WindowsUIButton)windowsUIButton;
									if (button.Caption == "全部上件")
									{
										button.Enabled = true;
									}
								}
							}
							this.lbl_CurrentInstall.Text = $"当前没有上件";
							this.gridView.FocusedRowHandle = 0;
						});
					}
				}
			});
		}

		// 异步线程
		public void RunAsync(Action action)
		{
			((Action)(delegate ()
			{
				action.Invoke();
			})).BeginInvoke(null, null);
		}

		public void RunInMainthread(Action action)
		{
			this.BeginInvoke((Action)(delegate ()
			{
				action.Invoke();
			}));
		}


		public void ReadAsync(string workpieceType, int? tatalNum, int count)
		{
			_isStop = false;
			int? result = 0;
			while (tatalNum > result)
			{
				result = opcClient.ReadDataFromOpcServer(m_xmlSettings.Count);
				//result++;
				Console.WriteLine($"当前上件的程序号:{workpieceType},已经上件{result}");
				RunInMainthread(() =>
				{
					this.lbl_CurrentInstall.Text = $"当前上件的程序号:{workpieceType},已经上件{result}";
				});

				if (_isStop)
				{
					RunInMainthread(() =>
					{
						this.lbl_CurrentInstall.Text = $"当前没有上件";
					});
                    _isStop = false;
                    return;
				}
			}

			if (tatalNum <= result)
			{
				if (opcClient.WriteDataToOpcServer(m_xmlSettings.Count, (ushort)0))
					opcClient.WriteDataToOpcServer(new Models.ProductionPlan
					{
						BatchNo = "0",
						WorkpieceType = "0",
						PrimerColor = "0",
						PigmentedCoatingColor = "0",
						VarnishColor = "0",
						WorkpieceNo = "0",
						PrimerFirm = "0",
						PrimerCraft = "0",
						PigmentedCoatingFirm = "0",
						PigmentedCoatingCraft = "0",
						VarnishFirm = "0",
						VarnishCraft = "0",
						TotalNum = 0
					});
				RunInMainthread(() =>
				{
					this.lbl_CurrentInstall.Text = $"当前没有上件";
				});
			}

		}

		public void ribe_ButtonClick(object sender, ButtonPressedEventArgs e)
		{
			switch (e.Button.Caption)
			{
				case "上件":
					if (MessageBox.Show("上件确认!", "确认", MessageBoxButtons.YesNo) == DialogResult.Yes)
					{
						UpWorkpiece();
					}
					break;
				case "暂停":
					StopWorkpiece();
					break;
				case "结束上件":
					FinishWorkpiece();
					break;
			}
		}

		private void FinishWorkpiece()
		{
			throw new NotImplementedException();
		}

		private void StopWorkpiece()
		{
			Models.ProductionPlan production = this.gridView.GetRow(this.gridView.FocusedRowHandle) as Models.ProductionPlan;
			int result = opcClient.ReadDataFromOpcServer(m_xmlSettings.Count);
			this.gridView.SetRowCellValue(this.gridView.FocusedRowHandle, "TotalNum", result);

			if (opcClient.WriteDataToOpcServer(m_xmlSettings.Count, (ushort)0)) 
			{ 
				opcClient.WriteDataToOpcServer(new Models.ProductionPlan
				{
					BatchNo = "0",
					WorkpieceType = "0",
					PrimerColor = "0",
					PigmentedCoatingColor = "0",
					VarnishColor = "0",
					WorkpieceNo = "0",
					PrimerFirm = "0",
					PrimerCraft = "0",
					PigmentedCoatingFirm = "0",
					PigmentedCoatingCraft = "0",
					VarnishFirm = "0",
					VarnishCraft = "0",
					TotalNum = 0
				});
			}

			_isStop = true;

			RunInMainthread(() =>
			{
				foreach (var windowsUIButton in this.windowsUIButtonPanel.Buttons)
				{
					if (windowsUIButton.GetType() == typeof(WindowsUIButton))
					{
						WindowsUIButton button = (WindowsUIButton)windowsUIButton;
						if (button.Caption == "全部上件")
						{
							button.Enabled = true;
						}
					}
				}
				this.lbl_CurrentInstall.Text = $"当前没有上件";
			});
		}

		private void UpWorkpiece()
		{
			Models.ProductionPlan production = this.gridView.GetRow(this.gridView.FocusedRowHandle) as Models.ProductionPlan;
			//productionPlans.Add(production);

			if (m_xmlSettings == null)
			{
				m_xmlSettings = new XMLSettings();
				m_xmlSettings.ReadXMLSettings();
			}

			int result = opcClient.ReadDataFromOpcServer(m_xmlSettings.Count);				
			if (!_isStop && result > 0)
			{
				this.gridView.SetRowCellValue(m_focusedRowHandle, "TotalNum", result);
					
			}

			_isStop = true;
            m_focusedRowHandle = this.gridView.FocusedRowHandle;

			opcClient.WriteDataToOpcServer(m_xmlSettings.Count, (ushort)0);

			opcClient.WriteDataToOpcServer(production);
			RunAsync(() =>
			{
				ReadAsync(production.WorkpieceType, production.TotalNum, 0);
			});
		}

		private void ImportExcel()
		{
			if (openExcelDialog.ShowDialog() == DialogResult.OK)
			{
				string filePath = openExcelDialog.FileName;
				Console.WriteLine(filePath);
				ImportForm importForm = new ImportForm(this, filePath);
				importForm.Show();
			}
		}

		/// <summary>
		/// 删除选中行
		/// </summary>
		private void DeleteSelect()
		{
			if (MessageBox.Show("确认删除？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				int index = this.gridView.FocusedRowHandle;
				Models.ProductionPlan production = this.gridView.GetRow(index) as Models.ProductionPlan;
				//int result = m_productionPlanDao.DeleteById(production.Id);
				for (int i = 0;i < productionPlans.Count;i ++)
				{
					if (productionPlans[i].Id == production.Id)
					{
						productionPlans.RemoveAt(i); 
					}
				}
				this.gridControl.DataSource = productionPlans;
				this.gridControl.RefreshDataSource();
			}
		}

		private void gridView_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
		{
			if (e.RowHandle == this.gridView.FocusedRowHandle)
			{
				e.Appearance.BackColor = Color.DeepSkyBlue;
				e.Appearance.BackColor2 = Color.LightBlue;
			}
		}

		private void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
		{
			Models.ProductionPlan role = this.gridView.GetFocusedRow() as Models.ProductionPlan;
			int result = m_productionPlanDao.UpdateProductionPlan(role);

			if (result > 0)
			{
				for (int i = 0;i < productionPlans.Count;i ++)
				{
					if (productionPlans[i].Id == role.Id)
					{
						productionPlans[i].BatchNo = role.BatchNo;
						productionPlans[i].WorkpieceType = role.WorkpieceType;
						productionPlans[i].PrimerColor = role.PrimerColor;
						productionPlans[i].PigmentedCoatingColor = role.PigmentedCoatingColor;
						productionPlans[i].VarnishColor = role.VarnishColor;
						productionPlans[i].TotalNum = role.TotalNum;
					}
				}

				this.gridControl.DataSource = productionPlans;
				this.gridControl.RefreshDataSource();
			}
		}
	}
}
