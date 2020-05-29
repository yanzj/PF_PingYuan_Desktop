using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF_PingYuan_Desktop.Forms.ProductionPlan.Operations
{
	public class ItemOperation
	{
		/// <summary>
		/// 创建可以在gridView的每一行添加的按钮组
		/// </summary>
		/// <param name="dicButtons"></param>
		/// <returns></returns>
		public static RepositoryItemButtonEdit CreateRepositoryItemButtonEdit(Dictionary<object, string> dicButtons)
		{
			RepositoryItemButtonEdit repositoryBtn = new RepositoryItemButtonEdit();
			repositoryBtn.AppearanceDisabled.Options.UseTextOptions = true;
			repositoryBtn.AppearanceDisabled.TextOptions.HAlignment = HorzAlignment.Near;
			repositoryBtn.AutoHeight = false;
			repositoryBtn.TextEditStyle = TextEditStyles.HideTextEditor;
			repositoryBtn.ButtonsStyle = BorderStyles.UltraFlat;
			repositoryBtn.Buttons.Clear();
			EditorButton btn = null;
			foreach (KeyValuePair<object, string> item in dicButtons)
			{
				btn = new EditorButton();
				btn.Kind = ButtonPredefines.Glyph;
				btn.Caption = item.Value;
				btn.Tag = item.Key;
				repositoryBtn.Buttons.Add(btn);
			}
			return repositoryBtn;
		}
	}
}
