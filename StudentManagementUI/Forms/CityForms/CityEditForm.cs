using Business.Abstract;
using Business.DependencyResolvers.AutoFac;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Entities.Concrete;
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

namespace StudentManagementUI.Forms.CityForms
{
    public partial class CityEditForm : BaseEditForm
    {
        #region Comment
        /*
         * Here in order to reach events on BaseEditForm we have send to our DataLayoutControl there
         */
        #endregion
        private readonly ICityService _cityService;
        public CityEditForm()
        {
            InitializeComponent();
            _cityService = InstanceFactory.GetInstance<ICityService>();
        }

    }
}