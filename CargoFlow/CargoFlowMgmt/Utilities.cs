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
        /// <summary>
        /// Checks if the email address is in the correct format
        /// </summary>
        /// <param name="emailAdressToCheck"></param>
        /// <returns>Returns true if the format is correct, false otherwise</returns>
        /// <exception cref="EmailaddressException"></exception>
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
