﻿using System;

namespace UserReg1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool checkValue;
            //string patt = "Cap";
            string patt2 = "ABC.na039@bl.co.in";
            //string patt1 = "Cap";
            //string patt3 = "91 8309294800";
            Pattern pattern = new Pattern();
            //checkValue = pattern.validatefirstname(patt);
            //checkValue = pattern.validatelastname(patt1);
            checkValue = pattern.validateemailid(patt2);
            //checkValue = pattern.validatephonenumber(patt3);
            if (checkValue)
            {
                Console.WriteLine("Pattern Valid ");
            }
            else
            {
                Console.WriteLine("Pattern not valid");
            }
        }
    }
}
