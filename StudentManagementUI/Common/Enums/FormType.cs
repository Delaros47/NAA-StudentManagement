using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementUI.Common.Enums
{
    #region Comment
    /*
     * Here we will create all our Forms name here later we want to access it or get description from it for example whenever we delete or update any Form record so Description we will get it from here since enum has int value we will not be using more that 255 Forms so we wrote byte
     */
    #endregion
    public enum FormType:byte
    {
        [Description("School Record")]
        School=1,
        [Description("City Record")]
        City =2,
        [Description("District Record")]
        District =3,
    }
}
