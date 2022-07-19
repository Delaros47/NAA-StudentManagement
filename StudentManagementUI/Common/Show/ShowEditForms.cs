using StudentManagementUI.Common.Enums;
using StudentManagementUI.Forms.BaseForms;
using StudentManagementUI.Common.Show.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementUI.Common.Show
{
    #region Comment
    /*
     * Here Whenever we are on ListForm then we want to shift to EditForm so we click New or double click on GridView so then it will create an instance of EditForm then it will identify wheater we clicked New or we try to edit it then in the end it will if there is a changes on it then it will return id then we will refresh our form and we will be focused on it in our GridView
     */
    #endregion
    public class ShowEditForms<TForm>:IBaseFormShow where TForm:BaseEditForm
    {
        public int ShowDialogEditForm(FormType formType,int id)
        {
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm)))
            {
                frm._processType = id > 0 ? ProcessType.EntityUpdate : ProcessType.EntityAdd;
                frm._id = id;
                frm.MyLoad();
                frm.ShowDialog();
                return frm.WillItRefreshed ? frm._id : 0;
            }
        }
    }
}
