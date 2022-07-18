using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementUI.Enums
{
    public enum FormType:byte
    {
        [Description("School Record")]
        School=1,
        [Description("City Record")]
        City = 2,
        [Description("District Record")]
        District = 3,
    }
}
