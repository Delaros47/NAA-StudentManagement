using Business.Abstract;
using Business.DependencyResolvers.AutoFac;
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

        protected override void New(object sender, ItemClickEventArgs e)
        {
            CreateForms<CityEditForm>.ShowDialogEditForm();
        }

        protected override void Delete(object sender, ItemClickEventArgs e)
        {

        }

        protected override void Select(object sender, ItemClickEventArgs e)
        {

        }

        protected override void Edit(object sender, ItemClickEventArgs e)
        {

        }

        protected override void Refresh(object sender, ItemClickEventArgs e)
        {
           
        }

        protected override void Filter(object sender, ItemClickEventArgs e)
        {

        }

        protected override void Columns(object sender, ItemClickEventArgs e)
        {

        }

        protected override void Print(object sender, ItemClickEventArgs e)
        {

        }

        protected override void Exit(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        protected override void ExcelFileFormatted(object sender, ItemClickEventArgs e)
        {

        }

        protected override void ExcelFileStandard(object sender, ItemClickEventArgs e)
        {

        }

        protected override void ExcelFileUnFormatted(object sender, ItemClickEventArgs e)
        {

        }

        protected override void WordFile(object sender, ItemClickEventArgs e)
        {

        }

        protected override void TextFile(object sender, ItemClickEventArgs e)
        {

        }

        protected override void PdfFile(object sender, ItemClickEventArgs e)
        {

        }

        protected virtual void KeyDownOnForm(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Insert:
                    New(null, null);
                    break;
                default:
                    break;
            }
        }
    }
}