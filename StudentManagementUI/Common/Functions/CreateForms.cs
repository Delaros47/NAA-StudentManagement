using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementUI.Common.Functions
{
    public static class CreateForms<TForm> where TForm : RibbonForm
    {
        public static void ShowDialogEditForm()
        {
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm)))
            {
                frm.ShowDialog();
            }

        }

        public static void ShowDialogListForm()
        {
            var frm = (TForm)Activator.CreateInstance(typeof(TForm));
            frm.MdiParent = Form.ActiveForm;
            frm.Show();
        }

        public static void ShowDialogListFormWithoutParent()
        {
            var frm = (TForm)Activator.CreateInstance(typeof(TForm));
            frm.ShowDialog();
        }
    }
}
