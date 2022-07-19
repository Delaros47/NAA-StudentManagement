using DevExpress.XtraBars;
using DevExpress.XtraEditors;
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
            
        }

        
    }
}