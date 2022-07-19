using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DevExpress.XtraEditors;
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
        private readonly ISchoolService _schoolService;
        public SchoolListForm()
        {
            InitializeComponent();
            _schoolService = new SchoolManager(new EfSchoolDal());
        }

        private void SchoolListForm_Load(object sender, EventArgs e)
        {
            gridControlSchools.DataSource = _schoolService.GetSchoolDetailDtoActive().Data;
        }
    }
}