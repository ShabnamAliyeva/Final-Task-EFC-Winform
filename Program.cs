using Final_Task___Winform.Forms;

namespace Final_Task___Winform
{
    internal static class Program
    {
     
        [STAThread]
        static void Main()
        {
            //    FormCore formCore = new FormCore();
            //    formCore.Close();

            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();
            Application.Run();
            

            ApplicationConfiguration.Initialize();
        }
    }
}