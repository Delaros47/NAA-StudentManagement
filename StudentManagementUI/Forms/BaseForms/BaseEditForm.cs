using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using StudentManagementUI.Common.Enums;
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
        protected internal ProcessType _processType;
        protected internal int _id;
        protected internal bool WillItRefreshed;
        public BaseEditForm()
        {
            InitializeComponent();
        }

        protected internal void MyLoad()
        {

        }
    }
}