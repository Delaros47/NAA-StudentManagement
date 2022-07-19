using StudentManagementUI.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementUI.Common.Show.Abstract
{
    public interface IBaseFormShow
    {
        int ShowDialogEditForm(FormType formType, int id);
    }
}
