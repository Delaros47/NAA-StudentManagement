using Business.Abstract;
using Business.DependencyResolvers.AutoFac;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using StudentManagementUI.Common.Functions;
using StudentManagementUI.Common.Messages;
using StudentManagementUI.Common.Enums;
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
using StudentManagementUI.Common.Show;
using Entities.Concrete;

namespace StudentManagementUI.Forms.CityForms
{
    public partial class CityListForm : BaseListForm
    {
        private readonly ICityService _cityService;
        public CityListForm()
        {
            InitializeComponent();
            _cityService = InstanceFactory.GetInstance<ICityService>();
            BaseService = (BaseService)_cityService;
           
        }

        protected override void MyLoads()
        {
            GridView = gridViewCities;
            FormType = FormType.City;
            FormShow = new ShowEditForms<CityEditForm>();
            Navigator = longNavigator.controlNavigator;
        }

        protected override void RefreshEntity()
        {
            GridView.GridControl.DataSource = _cityService.GetAllActive().Data;
            
        }

        private void CityListForm_Load(object sender, EventArgs e)
        {
            MyLoads();
            RefreshEntity();
        }
    }
}