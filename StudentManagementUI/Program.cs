using StudentManagementUI.Forms.BaseForms;

namespace StudentManagementUI
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            Application.Run(new BaseEditForm());
        }
    }
}