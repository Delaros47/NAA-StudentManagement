using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementUI.Common.Functions
{
    public class ClearAll
    {
        public static void Clean(Control dataLayoutControl)
        {
            foreach (Control ctrl in dataLayoutControl.Controls)
            {
                if (ctrl.Name!="tglState")
                {
                    BaseEdit editor = ctrl as BaseEdit;
                    if (editor != null)
                        editor.EditValue = null;
                }
                
            }
        }
    }
}
