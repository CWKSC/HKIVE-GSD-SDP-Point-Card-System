using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP_prototype
{
    class FormatChecking
    {


        // refer to https://www.csharpstar.com/c-program-to-check-password/
        public static bool UserName(string accountName)
        {
            bool isItCorrect = true;

            if (accountName == "")
            {
                MessageBox.Show("Account Name should not be empty.");
                return false;
            }

            if (accountName.Length > 16)
            {
                MessageBox.Show("User Account Name maximum sixteen characters.");
                isItCorrect = false;
            }

            //No white space
            if (accountName.Contains(" "))
            {
                MessageBox.Show("User Account Name should not have space.");
                isItCorrect = false;
            }

            // No special char
            string specialCharacters = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"";
            char[] specialCharactersArray = specialCharacters.ToCharArray();
            foreach (char c in specialCharactersArray)
            {
                if (accountName.Contains(c))
                {
                    MessageBox.Show("User Account Name should not have special characters.\n" +
                        "e.g. %!@#$%^&*()?/>.<,:;'\\|}]{[_~`+=-\"");
                    isItCorrect = false;
                }
            }

            return isItCorrect;
        }

        // refer to https://www.csharpstar.com/c-program-to-check-password/
        public static bool Password(string password)
        {
            bool isItCorrect = true;

            if(password == "")
            {
                MessageBox.Show("Password should not be empty.");
                return false;
            }

            //min 6 chars, max 12 chars
            if (password.Length < 6 || password.Length > 15)
            {
                MessageBox.Show("Password should greater than 6 and least than 15.");
                isItCorrect = false;
            }

            //No white space
            if (password.Contains(" "))
            {
                MessageBox.Show("Password should not have space.");
                isItCorrect = false;
            }

            //At least 1 upper case letter
            if (!password.Any(char.IsUpper))
            {
                MessageBox.Show("Password at least 1 uppercase letter.");
                isItCorrect = false;
            }

            //At least 1 lower case letter
            if (!password.Any(char.IsLower))
            {
                MessageBox.Show("Password at least 1 lowercase letter.");
                isItCorrect = false;
            }

            // No special char
            string specialCharacters = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"";
            char[] specialCharactersArray = specialCharacters.ToCharArray();
            foreach (char c in specialCharactersArray)
            {
                if (password.Contains(c))
                {
                    MessageBox.Show("Password should not have special characters.\n" +
                        "e.g. %!@#$%^&*()?/>.<,:;'\\|}]{[_~`+=-\"");
                    isItCorrect = false;
                    break;
                }
            }

            return isItCorrect;
        }



    }
}
