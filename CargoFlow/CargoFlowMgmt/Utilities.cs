using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CargoFlowMgmt
{
    public static class Utilities
    {
        public static bool CheckEmailaddressFormat(string emailAdressToCheck)
        {
            //if the instantiation fails, it means that the mail provided isn't correct.
            try
            {
                MailAddress mail = new MailAddress(emailAdressToCheck);
                return true;
            }
            catch
            {
                throw new EmailaddressException();
            }
        }

        public class EmailaddressException : Exception { }
    }
}
