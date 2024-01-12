using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoFlowForms
{
    public static class Session
    {
        private static string userMail = "";
        private static string userRole = "";

        public static string UserMail
        {
            get { return userMail; }
            set { userMail = value; }
        }

        public static string UserRole
        {
            get { return userRole; }
            set { userRole = value; }
        }
    }
}
