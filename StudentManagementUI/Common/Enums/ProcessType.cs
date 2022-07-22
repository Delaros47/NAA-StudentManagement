using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementUI.Common.Enums
{
    #region Comment
    /*
     * Here we create ProcessType on our ShowEditForms that we should tell class that we intend to add or update if we intend to add that then we have clicked on New if update then we intend to double click on GridView or Edit Button
     */
    #endregion
    public enum ProcessType
    {
        EntityAdd,
        EntityUpdate
    }
}
