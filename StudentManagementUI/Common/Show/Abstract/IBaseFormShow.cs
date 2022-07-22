using StudentManagementUI.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementUI.Common.Show.Abstract
{
    #region Comment
    /*
     * Here we have created IBaseFormShow in ShowEditForm will be implementing it, Interface is referance keepers
     */
    #endregion
    public interface IBaseFormShow
    {
        int ShowEditDialogForm(FormType formType, int id);
    }
}
