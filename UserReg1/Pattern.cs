using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserReg1
{
    public class Pattern
    {
        //UC1-4

        public static string REGEX_FIRST_NAME = "^[A-Z]{1}[A-Za-z]{2,}$";

        public static string REGEX_LAST_NAME = "^[A-Z]{1}[A-Za-z]{2,}$";

        public static string REGEX_EMAIL_ID = "^[A-Z]{3}[.][a-z0-9]{5}@([a-z]{2}[.][a-z]{2}[.][a-z]{1}$";

        public static string REGEX_PHONE_NUMBER = "^[1-9]{2}[: :][0-9]{10}$";
        public bool validatefirstname(string firstName)
        {
            return Regex.IsMatch(firstName, REGEX_FIRST_NAME);
        }

        public bool validatelastname(string lastName)
        {
            return Regex.IsMatch(lastName, REGEX_LAST_NAME);
        }
        public bool validateemailid(string emailId)
        {
            return Regex.IsMatch(emailId, REGEX_EMAIL_ID);
        }
        public bool validatephonenumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, REGEX_PHONE_NUMBER);
        }
    }
}
