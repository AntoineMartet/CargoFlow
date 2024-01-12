using CargoFlowMgmt;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace CargoFlowForms
{
    public static class Program
    {
        private static FrmLogin frmLogin = new FrmLogin();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(frmLogin);
        }

        public static FrmLogin FrmLogin
        {
            get { return frmLogin; }
        }
    }
}