using StudentManagementUI.Forms.BaseForms;
using StudentManagementUI.Forms.MainForms;
using StudentManagementUI.Forms.SchoolForms;

namespace StudentManagementUI
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}