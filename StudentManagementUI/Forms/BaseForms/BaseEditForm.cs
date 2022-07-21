using DevExpress.XtraBars.Ribbon;
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
    public partial class BaseEditForm : RibbonForm
    {

        public BaseEditForm()
        {
            InitializeComponent();
        }

        protected virtual void New(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        protected virtual void Save(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        protected virtual void Update(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        protected virtual void Clear(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        protected virtual void Exit(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        protected virtual void MyKeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}