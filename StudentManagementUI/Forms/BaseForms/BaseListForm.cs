using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using StudentManagementUI.Abstract;
using StudentManagementUI.Forms.SchoolForms;
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
    public partial class BaseListForm : RibbonForm
    {

        public BaseListForm()
        {
            InitializeComponent();
        }

        protected virtual void New(object sender, ItemClickEventArgs e)
        {
            
        }

        protected virtual void Delete(object sender, ItemClickEventArgs e)
        {

        }

        protected virtual void Select(object sender, ItemClickEventArgs e)
        {

        }

        protected virtual void Edit(object sender, ItemClickEventArgs e)
        {

        }

        protected virtual void Refresh(object sender, ItemClickEventArgs e)
        {

        }

        protected virtual void Filter(object sender, ItemClickEventArgs e)
        {

        }

        protected virtual void Columns(object sender, ItemClickEventArgs e)
        {

        }

        protected virtual void Print(object sender, ItemClickEventArgs e)
        {

        }

        protected virtual void Exit(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        protected virtual void ExcelFileStandard(object sender, ItemClickEventArgs e)
        {

        }

        protected virtual void ExcelFileFormatted(object sender, ItemClickEventArgs e)
        {

        }

        protected virtual void ExcelFileUnFormatted(object sender, ItemClickEventArgs e)
        {

        }

        protected virtual void TextFile(object sender, ItemClickEventArgs e)
        {

        }

        protected virtual void WordFile(object sender, ItemClickEventArgs e)
        {

        }

        protected virtual void PdfFile(object sender, ItemClickEventArgs e)
        {

        }

        protected virtual void ActivePassiveList(object sender, ItemClickEventArgs e)
        {

        }

        protected virtual void MyKeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}