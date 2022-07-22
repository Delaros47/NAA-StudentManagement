using Business.Abstract;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using StudentManagementUI.Common.Enums;
using StudentManagementUI.UserControls.Controls;
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
    public partial class BaseEditForm : RibbonForm
    {
        #region Comment
        /*
         * Here we declared our ProcessType we have to set it either we are going to update it or we are going to add a new one we will set it from ShowEditForms class 
         * Id that we set it on ShowEditForms so we could use our Id as Update
         * MyLoads is functions that we will be running it during opening our EditForm because on ShowEditForms we have written it that during opening our EditForm that it will be runned even before our Forms opened
         * WillRefresh we have written that if we open our edit Form then if we didn't change anything that it will not refresh our ListForm if we make some changes that it will refresh and moreover that it will be focused on it
         */
        #endregion
        protected internal ProcessType ProcessType;
        protected internal int Id;
        protected internal bool WillRefresh;
        protected MyDataLayoutControl MyDataLayoutControl;
        protected IBaseService BaseService;
        protected FormType FormType;
        public BaseEditForm()
        {
            InitializeComponent();
            EventsLoad();
        }

        protected void EventsLoad()
        {
            //Button Events
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

        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item==btnNew)
            {
                ProcessType = ProcessType.EntityAdd;
                MyLoads();
            }
            else if (e.Item==btnSave)
            {
                SaveEntity(false);
            }
            else if (e.Item==btnUpdate)
            {
                UpdateEntity();
            }
            else if(e.Item==btnClear)
            {
                ClearEntity();
            }
            else if (e.Item==btnExit)
            {
                Close();
            }
        }

        private void ClearEntity()
        {
            
        }

        private void UpdateEntity()
        {
           
        }

        private void SaveEntity(bool v)
        {
            
        }

        protected virtual void MyLoads() 
        {

        }
    }
}