using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementUI.Common.Messages
{
    public class MyMessageBox
    {
        public static void ErrorMessage(string errorMessage)
        {
            XtraMessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void AddMessage(string message)
        {
            XtraMessageBox.Show(message, "Adding a new", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void WarningMessage(string warningMessage)
        {
            XtraMessageBox.Show(warningMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult YesSelectedYesAndNo(string message, string caption)
        {
            return XtraMessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        }

        public static DialogResult NoSelectedYesAndNo(string message, string caption)
        {
            return XtraMessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        public static DialogResult DeleteMessage(string formName)
        {
            return NoSelectedYesAndNo($"Selected {formName} will be Deleted. Are you conforming it?", "Delete Confirmation");
        }

        public static void NotSelectedRowId()
        {
            WarningMessage("Please choose the proper row on the table");
        }

        public static void UnassignPrivateCode()
        {
            XtraMessageBox.Show("Unassigned Private Code please enter the first Private Code manually", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
