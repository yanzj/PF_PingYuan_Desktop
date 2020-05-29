using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using PF_PingYuan_Desktop.Setting;
using PF_PingYuan_Desktop.Forms.ProductionPlan;
using PF_PingYuan_Desktop.Forms.LabelProductionInfo;
using PF_PingYuan_Desktop.Forms.HistoricalProduction;
using PF_PingYuan_Desktop.Forms.UserInfo;
using PF_PingYuan_Desktop.Forms.StationInfo;
using PF_PingYuan_Desktop.Models;

namespace PF_PingYuan_Desktop {
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm {
        XtraUserControl employeesUserControl;
        XtraUserControl customersUserControl;
        XtraUserControl productionPlanUserControl;
        XtraUserControl labelProductionInfoUserControl;
        XtraUserControl historicalProductionUserControl;
        XtraUserControl userInfoUserControl;
        XtraUserControl stationInfoUserControl;

        public MainForm() {
            InitializeComponent();
            employeesUserControl = CreateUserControl("Employees");
            customersUserControl = CreateUserControl("Customers");

            productionPlanUserControl = CreateUserControl(AppSettings.PRODUCTION_PLAN);
            labelProductionInfoUserControl = CreateUserControl(AppSettings.LABEL_PRODUCTION_INFO);
            historicalProductionUserControl = CreateUserControl(AppSettings.HISTORICAL_PRODUCTION);
            userInfoUserControl = CreateUserControl(AppSettings.USER_INFO);
            stationInfoUserControl = CreateUserControl(AppSettings.STATION_INFO);
            accordionControl.SelectedElement = ele_ProductionPlan;
        }

        public MainForm(User user)
        {
            InitializeComponent();
            employeesUserControl = CreateUserControl("Employees");
            customersUserControl = CreateUserControl("Customers");

            this.barEdit_JobNo.EditValue = user.JobNo;
            this.barEdit_UserName.EditValue = user.UserName;
            this.barEdit_Authority.EditValue = user.OperationAuthority;

            if (user.OperationAuthority != "1")
            {
                this.ele_LabelProductionInfo.Visible = false;
                this.ele_UserInfo.Visible = false;
            }

            productionPlanUserControl = CreateUserControl(AppSettings.PRODUCTION_PLAN);
            labelProductionInfoUserControl = CreateUserControl(AppSettings.LABEL_PRODUCTION_INFO);
            historicalProductionUserControl = CreateUserControl(AppSettings.HISTORICAL_PRODUCTION);
            userInfoUserControl = CreateUserControl(AppSettings.USER_INFO);
            stationInfoUserControl = CreateUserControl(AppSettings.STATION_INFO);
            accordionControl.SelectedElement = ele_ProductionPlan;
        }

        XtraUserControl CreateUserControl(string text) {
            XtraUserControl result = new XtraUserControl();
            result.Name = text.ToLower() + "UserControl";
            result.Text = text;

            switch (text) {
                case AppSettings.PRODUCTION_PLAN:
                    ProductionPlanControl productionPlanControl = new ProductionPlanControl();
                    productionPlanControl.Parent = result;
                    productionPlanControl.Dock = DockStyle.Fill;
                    break;
                case AppSettings.LABEL_PRODUCTION_INFO:
                    LabelProductionInfoControl labelProductionInfoControl = new LabelProductionInfoControl();
                    labelProductionInfoControl.Parent = result;
                    labelProductionInfoControl.Dock = DockStyle.Fill;
                    break;
                case AppSettings.HISTORICAL_PRODUCTION:
                    HistoricalProductionControl historicalProductionControl = new HistoricalProductionControl();
                    historicalProductionControl.Parent = result;
                    historicalProductionControl.Dock = DockStyle.Fill;
                    break;
                case AppSettings.USER_INFO:
                    UserInfoControl userInfoControl = new UserInfoControl();
                    userInfoControl.Parent = result;
                    userInfoControl.Dock = DockStyle.Fill;
                    break;
                case AppSettings.STATION_INFO:
                    StationInfoControl2 stationInfoControl = new StationInfoControl2();
                    stationInfoControl.Parent = result;
                    stationInfoControl.Dock = DockStyle.Fill;
                    break;
            }

            return result;
        }

        void accordionControl_SelectedElementChanged(object sender, SelectedElementChangedEventArgs e) {
            if (e.Element == null) return;
            XtraUserControl userControl = null;
            
            switch (e.Element.Text) {
                case AppSettings.PRODUCTION_PLAN:
                    userControl = productionPlanUserControl.IsDisposed ? CreateUserControl(e.Element.Text) : productionPlanUserControl; 
                    break;
                case AppSettings.LABEL_PRODUCTION_INFO:
                    userControl = labelProductionInfoUserControl.IsDisposed ? CreateUserControl(e.Element.Text) : labelProductionInfoUserControl;
                    break;
                case AppSettings.HISTORICAL_PRODUCTION:
                    userControl = historicalProductionUserControl.IsDisposed ? CreateUserControl(e.Element.Text) : historicalProductionUserControl;
                    break;
                case AppSettings.USER_INFO:
                    userControl = userInfoUserControl.IsDisposed ? CreateUserControl(e.Element.Text) : userInfoUserControl;
                    break;
                case AppSettings.STATION_INFO:
                    userControl = stationInfoUserControl.IsDisposed ? CreateUserControl(e.Element.Text) : stationInfoUserControl;
                    break;
            }
            
            tabbedView.AddDocument(userControl);
            tabbedView.ActivateDocument(userControl);
        }

        void barButtonNavigation_ItemClick(object sender, ItemClickEventArgs e) {
            int barItemIndex = barSubItemNavigation.ItemLinks.IndexOf(e.Link);
            accordionControl.SelectedElement = mainAccordionGroup.Elements[barItemIndex];
        }

        void tabbedView_DocumentClosed(object sender, DocumentEventArgs e) {
            RecreateUserControls(e);
            SetAccordionSelectedElement(e);
        }
        void SetAccordionSelectedElement(DocumentEventArgs e) {
            if (tabbedView.Documents.Count != 0) {
                //if (e.Document.Caption == AppSettings.LABEL_PRODUCTION_INFO) accordionControl.SelectedElement = ele_LabelProductionInfo;
                //else accordionControl.SelectedElement = ele_ProductionPlan;
                switch (e.Document.Caption)
                {
                    case AppSettings.PRODUCTION_PLAN:
                        accordionControl.SelectedElement = ele_ProductionPlan;
                        break;
                    case AppSettings.LABEL_PRODUCTION_INFO:
                        accordionControl.SelectedElement = ele_LabelProductionInfo;
                        break;
                    case AppSettings.HISTORICAL_PRODUCTION:
                        accordionControl.SelectedElement = ele_HistoricalProduction;
                        break;
                    case AppSettings.USER_INFO:
                        accordionControl.SelectedElement = ele_UserInfo;
                        break;
                    case AppSettings.STATION_INFO:
                        accordionControl.SelectedElement = ele_StationInfo;
                        break;
                }
            }
            else {
                accordionControl.SelectedElement = null;
            }
        }
        void RecreateUserControls(DocumentEventArgs e) {
            if (e.Document.Caption == "Employees") employeesUserControl = CreateUserControl("Employees");
            else customersUserControl = CreateUserControl("Customers");
        }
    }
}