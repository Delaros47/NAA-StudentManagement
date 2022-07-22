using StudentManagementUI.Common.Enums;
using StudentManagementUI.Common.Show.Abstract;
using StudentManagementUI.Forms.BaseForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementUI.Common.Show
{
    #region Comment
    /*
     * Here we have created a class that will create instance for our From in order to show us either with New or Double Click on GridView
     */
    #endregion
    public class ShowEditForms<TForm> : IBaseFormShow where TForm : BaseEditForm
    {
        #region Comment
        /*
         * Here we have created a method ShowEditDialogForm and it returns int then it will create any instance that we send to our Method and also it will identity we will add or update the EditForm
         * ProcessType we set our ProcessType on BaseEditForm EntityUpdate or EntityAdd
         * Id will set Id on BaseEditForm
         * MyLoads(); function will be run before our EditForm even opened
         * WillRefresh will set method with id because if we do any changes on EditForm then it will be refreshed on GridView and it will be focused on that Row and also that Id will be Method return value
         */
        #endregion
        public int ShowEditDialogForm(FormType formType, int id)
        {
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm)))
            {
                frm.ProcessType = id > 0 ? ProcessType.EntityUpdate : ProcessType.EntityAdd;
                frm.Id = id;
                frm.MyLoads();
                frm.ShowDialog();
                return frm.WillRefresh ? frm.Id : 0;
            }
        }

    }
}
