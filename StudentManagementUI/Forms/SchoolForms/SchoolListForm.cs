using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers.AutoFac;
using DataAccess.Concrete.EntityFramework;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using StudentManagementUI.Common.Functions;
using StudentManagementUI.Forms.BaseForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementUI.Forms.SchoolForms
{
    public partial class SchoolListForm : BaseListForm
    {
        public SchoolListForm()
        {
            InitializeComponent();
        }

    }
}