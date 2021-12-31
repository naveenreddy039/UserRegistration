using System;

namespace UserReg5
{
    class Program
    {
        //UC5-8
        static void Main(string[] args)
        {
            bool checkValue;
            string passwrd = "Abc09@&";
            //string passwrd1 = "Abcde";
            Passowrd pass = new Passowrd();
            checkValue = pass.validatepassword(passwrd);
            //checkValue = pass.validatepasswordatloneup(passwrd1);
            if (checkValue)
            {
                Console.WriteLine("Pattern valid");
            }
            else
            {
                Console.WriteLine("Pattern not valid");
            }
            
        }
    }
}
