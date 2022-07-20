using Business.Abstract;
using Business.DependencyResolvers.AutoFac;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Entities.Concrete;
using StudentManagementUI.Common.Functions;
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
        public static int CityId = -1;
        private readonly ICityService _cityService;
        public CityEditForm()
        {
            InitializeComponent();
            _cityService = InstanceFactory.GetInstance<ICityService>();
        }

        protected override void New(object sender, ItemClickEventArgs e)
        {
            GetPrivateCode();
        }

        private void GetPrivateCode()
        {
            CleanAll();
            try
            {
                var result = _cityService.GetLastPrivateCode().Data;
                txtPrivateCode.Text = GeneratePrivateCodes.GeneratePrivate(result.PrivateCode);
            }
            catch (Exception exception)
            {
                MyMessageBox.UnassignPrivateCode();
            }


        }

        protected override void Save(object sender, ItemClickEventArgs e)
        {
            var result = _cityService.Add(new City
            {
                PrivateCode = txtPrivateCode.Text,
                CityName = txtCityName.Text,
                State = tglState.IsOn,
                Description = txtDescription.Text
            });
            if (result.Success)
            {
                MyMessageBox.AddMessage(result.Message);
            }
            else
            {
                MyMessageBox.ErrorMessage(result.Message);
            }
            CleanAll();
        }

        private void CleanAll()
        {
            ClearAll.Clean(myDataLayoutControl);
            GetPrivateCode();
        }

        protected override void Update(object sender, ItemClickEventArgs e)
        {
            if (CityId == -1) return;
            var result = _cityService.Add(new City
            {
                Id = CityId,
                PrivateCode = txtPrivateCode.Text,
                CityName = txtCityName.Text,
                State = tglState.IsOn,
                Description = txtDescription.Text
            });
            if (result.Success)
            {
                MyMessageBox.AddMessage(result.Message);
            }
            else
            {
                MyMessageBox.ErrorMessage(result.Message);
            }
            CleanAll();
        }

        protected override void Clear(object sender, ItemClickEventArgs e)
        {
            CleanAll();
        }

        protected override void Exit(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void CityEditForm_Load(object sender, EventArgs e)
        {
            if (CityId != -1)
            {
                var result = _cityService.Get(CityId).Data;
                if (result != null)
                {
                    txtPrivateCode.Text = result.PrivateCode;
                    txtCityName.Text = result.CityName;
                    txtDescription.Text = result.Description;
                }
            }
            else
            {
                GetPrivateCode();
            }
        }
    }
}