using Business.Abstract;
using Business.DependencyResolvers.AutoFac;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using StudentManagementUI.Common.Messages;
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
using Entities.Concrete;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace StudentManagementUI.Forms.CityForms
{
    public partial class CityListForm : BaseListForm
    {
        private readonly ICityService _cityService;
        public CityListForm()
        {
            InitializeComponent();
            _cityService = InstanceFactory.GetInstance<ICityService>();           
        }


        private void CityListForm_Load(object sender, EventArgs e)
        {

        }
    }
}