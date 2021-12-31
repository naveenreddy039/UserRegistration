using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserReg5
{
    public class Passowrd
    {
        public static string REGEX_PASSWORD = "^([a-zA-Z0-9])*[!@#$%^&*]{2}([a-zA-Z0-9])*$";
        //public static string REGEX_PASSWORD_UPPER = "^[A-Z]{1}[a-z]{4}$";
        //public static string REGEX_PASSWORD_ONENUMERIC = "^[A-Z]{1}[1-9][0-9]{6}$";

        public bool validatepassword(string password)
        {
          return Regex.IsMatch(password, REGEX_PASSWORD);
        }
        //public bool validatepasswordatloneup(string passwordAtOneUp)
        //{
          //  return Regex.IsMatch(passwordAtOneUp, REGEX_PASSWORD_UPPER);
        //}
        //public bool validatepasswordatloneup(string passwordAtOneUp)
        //{
          //  return Regex.IsMatch(passwordAtOneUp, REGEX_PASSWORD_ONENUMERIC);
        //}
    }
}
