using DevExpress.XtraGrid.Views.Grid;
using StudentManagementUI.Common.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementUI.Common.Functions
{
    #region Comment
    /*
     * Here on Gneral function that we have created a GetRowId extension method so simply this method will check wheater we clicked exactly on Row or not if yes then it returns us Row Id if not then it returns us Warning message that we have to click exactly on the Row not elsewhere
     */
    #endregion
    public static class GeneralFunctions
    {
        #region Comment
        /*
         * Here we have created GetRowId extension method it will get Row Id on the GridView if we didn't focused on Row and double click or we click edit while we selected elsewhere then NotSelectedRowId will be run
         */
        #endregion
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

        #region Comment
        /*
         * Here we have create GetRow when we choose on nonchild form on GridView after the double click or Select button it will get the Row of the Form
         */
        #endregion
        public static T GetRow<T>(this GridView gridView,bool message=true)
        {
            if (gridView.FocusedRowHandle>-1)
            {
                return (T)gridView.GetRow(gridView.FocusedRowHandle);
            }
            if (message)
            {
                MyMessageBox.NotSelectedRowId();
            }
            return default(T);
        }

    }

}