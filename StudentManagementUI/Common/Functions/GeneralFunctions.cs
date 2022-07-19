using DevExpress.XtraGrid.Views.Grid;
using StudentManagementUI.Common.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementUI.Common.Functions
{
    public static class GeneralFunctions
    {
        public static int GetRowId(this GridView gridView)
        {
            if (gridView.FocusedRowHandle>-1)
            {
                return (int)gridView.GetFocusedRowCellValue("Id");
            }
            else
            {
                MyMessageBox.NotSelectedRowId();
            }
            return -1;
        }
    }
}
