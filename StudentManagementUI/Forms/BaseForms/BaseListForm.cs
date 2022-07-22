using Business.Abstract;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using StudentManagementUI.Abstract;
using StudentManagementUI.Common.Enums;
using StudentManagementUI.Common.Functions;
using StudentManagementUI.Common.Show.Abstract;
using StudentManagementUI.Forms.SchoolForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementUI.Forms.BaseForms
{

    public partial class BaseListForm : RibbonForm
    {
        #region Comment
        /*
         * FormShow it is interface which form will be used for ShowDialog and so on cause it will keep referances of of all other forms
         * FormType is our Enum also will be used for giving messages and so on
         */
        #endregion
        protected IBaseFormShow FormShow;
        protected FormType FormType;
        protected internal GridView GridView;
        protected bool ActivePassiveList = true;
        protected internal bool MultiSelect;
        protected internal BaseEntity SelectedEntity;
        protected IBaseService BaseService;
        protected ControlNavigator Navigator;
        public BaseListForm()
        {
            InitializeComponent();
            EventsLoad();
            
        }

        #region Comment
        /*
         * Here we will not click on our controls and try to create their events instead we write all here beside it we will do our best to write all our codes in BaseForms in order to write less codes 
         */
        #endregion
        private void EventsLoad()
        {
            //Button Events
            #region Comment
            /*
             * Here in Ribbon control all are BarButtonItem except the Send cause Send is BarSubItem so these two don't have ItemClick class we look at their inherited classes so we find both of them are implemented from BarItem that's why we wrote BarItem
             */
            #endregion
            foreach (var item in ribbonControl.Items)
            {
                switch (item)
                {
                    case BarItem button:
                        button.ItemClick += Button_ItemClick;
                        break;
                    default:
                        break;
                }
            }
            //GridView Events
            //GridView.DoubleClick += GridView_DoubleClick;
            //GridView.KeyDown += GridView_KeyDown;


            //Form Events


        }

        protected virtual void MyLoads()
        {
            FillFuntions();
            EventsLoad();
            Navigator.NavigatableControl = GridView.GridControl;
            GridView.OptionsSelection.MultiSelect = MultiSelect;
            Cursor.Current = Cursors.WaitCursor;
            RefreshEntity();
            Cursor = DefaultCursor;
            
        }

        private void FillFuntions()
        {
            

        } 



        #region Comment
        /*
         * Here whenever we click New or Double click on our GridView so it will open any EditForm if Id=-1 it means that it was open by New if Id is different than -1 then it was double click on GridView
         */
        #endregion
        private void ShowEditForm(int id)
        {
            var result = FormShow.ShowEditDialogForm(FormType, id);
        }

        private void DeleteEntity()
        {
           
        }

        #region Comment
        /*
         * Here EntitySelect whenever we click on our ButtonEdit Control so it will be opened any Form but not as MdiChild so then with double click on the GridView it will get the value that we have double clicked from SelectedEntity we will create an extension method so it will get our row from it
         * Diaglog result that means that we have definitly selected on GridView Row so then we write Close(); function so it will close our nonchild GridView Form (ListForm)
         */
        #endregion
        private void SelectEntity()
        {
            if (MultiSelect)
            {

            }
            else
            {
                SelectedEntity = GridView.GetRow<BaseEntity>();
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        protected virtual void RefreshEntity()
        {

        }

        private void FilterEntity()
        {

        }

        private void PrintEntity()
        {

        }

        #region Comment
        /*
         * Here we will be changing ActivePassive List Caption when as manually it will be shown Passive List then we click that it will be Passive List
         */
        #endregion
        private void CaptionChangeEntity()
        {

        }

        #region Comment
        /*
         * Here when it entered on GridView it will check that if it is MdiChild then it will open an EditForm as Dialog if not then it will open GridView Form as not MdiChild so whenever we double click that it will get our value or move it to ButtonEdit Control
         */
        #endregion
        private void SelectProcessTypeEntity()
        {
            if (!IsMdiChild)
            {
                SelectEntity();
            }
            else
            {
                btnEdit.PerformClick();
            }
        }

        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            #region Comment
            /*
             * Here Buttons on Ribbon are BarItemLink if we want to focus on any of them we simply { var link = e.Item.Links[0]; link.Focus();} but since ExcelFiles are BarSubItemLink so we will open menu and focus on it that's why we have converted into BarSubItemLink 
             */
            #endregion
            if (e.Item == btnSend)
            {
                var link = (BarSubItemLink)e.Item.Links[0];
                link.Focus();
                link.OpenMenu();
                link.Item.ItemLinks[0].Focus();
            }
            else if (e.Item == btnExcelFileStandard)
            {

            }
            else if (e.Item == btnExcelFileFormatted)
            {

            }
            else if (e.Item == btnExcelFileUnFormatted)
            {

            }
            else if (e.Item == btnPdfFile)
            {

            }
            else if (e.Item == btnTxtFile)
            {

            }
            else if (e.Item == btnWordFile)
            {

            }
            else if (e.Item == btnNew)
            {
                ShowEditForm(-1);
            }
            else if (e.Item == btnEdit)
            {
                #region Comment
                /*
                 * Here when we click our buttton it will get first Id of our GridView then it will run ShowEditForm if we have selected Row with Id then it will open EditForm and set our Id value on EditForm then there we click call our Service Get method we will bring all data in order to update them there
                 */
                #endregion
                ShowEditForm(GridView.GetRowId());
            }
            else if (e.Item == btnDelete)
            {
                DeleteEntity();
            }
            else if (e.Item == btnSelect)
            {
                SelectEntity();
            }
            else if (e.Item == btnRefresh)
            {
                RefreshEntity();
            }
            else if (e.Item == btnFilter)
            {
                FilterEntity();
            }
            else if (e.Item == btnColumns)
            {
                #region Comment
                /*
                 * Here whenever we click on Column button that it will open right down side small screen so we can move our column inside it or from Customization Form to GridView
                 */
                #endregion
                if (GridView.CustomizationForm == null)
                    GridView.ShowCustomization();
                else
                    GridView.HideCustomization();
            }
            else if (e.Item == btnPrint)
            {
                PrintEntity();
            }
            else if (e.Item == btnExit)
            {
                Close();
            }
            else if (e.Item == btnActivePassiveList)
            {
                #region Comment
                /*
                 * Here Whenever we click Passive List or Active List then it will here make for us ActivePassiveList as true or false each time when we click it
                 */
                #endregion
                ActivePassiveList = !ActivePassiveList;
                CaptionChangeEntity();
            }

            Cursor.Current = DefaultCursor;



        }

        #region Comment
        /*
         * Here whenever we pressed some certain Key on GridView that it will perform some methods or functions
         */
        #endregion
        private void GridView_KeyDown(object? sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    SelectProcessTypeEntity();
                    break;
                case Keys.Escape:
                    Close();
                    break;
                default:
                    break;
            }
        }

        #region Comment
        /*
         * Here whenever we double click on GridView so then it will run our EntitySelectProcessType();
         */
        #endregion
        private void GridView_DoubleClick(object? sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            SelectProcessTypeEntity();
            Cursor.Current = DefaultCursor;
        }


    }
}