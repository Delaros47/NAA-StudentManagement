using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using StudentManagementUI.Common.Enums;
using StudentManagementUI.Common.Functions;
using StudentManagementUI.Common.Show.Abstract;
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
    public partial class BaseListForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        protected IBaseFormShow _baseFormShow;
        protected FormType _formType;
        protected internal GridView _gridView;
        public BaseListForm()
        {
            InitializeComponent();
            EventsLoad();
        }

        #region Comment
        /*
         * Our Buttons are BarButtonItem and Send is BarSubItem so we have to find common componant both of should be implemented from it and that componant should has ItemClik we go to definition that they inheritted from BarItem
         */
        #endregion
        private void EventsLoad()
        {
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
        }

        private void ShowEditForm(int id)
        {
            var result = _baseFormShow.ShowDialogEditForm(_formType,id);
        }

        private void EntityDelete()
        {
            
        }

        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item==btnSend)
            {
                var link = (BarSubItemLink)e.Item.Links[0];
                link.Focus();
                link.OpenMenu();
                link.Item.ItemLinks[0].Focus();
            }
            else if (e.Item==btnExcelFileStandard)
            {

            }
            else if (e.Item==btnExcelFileFormatted)
            {

            }
            else if (e.Item==btnExcelFileUnFormatted)
            {

            }
            else if (e.Item==btnPdfFile)
            {

            }
            else if (e.Item == btnTxtFile)
            {

            }
            else if (e.Item==btnWordFile)
            {

            }
            else if (e.Item==btnNew)
            {
                ShowEditForm(-1);
            }
            else if (e.Item==btnEdit)
            {
                ShowEditForm(_gridView.GetRowId());
            }
            else if (e.Item==btnDelete)
            {
                EntityDelete();
            }
            
        }

        
    }
}