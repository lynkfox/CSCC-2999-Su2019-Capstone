﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace login.Resources
{
    public static class uF
    {

       public static bool CheckPWValid(string pw)
        {
            var regex = new Regex(@"^(?=.*[a - z])(?=.*[A - Z])(?=.*\d)(?=.*[^\da - zA - Z]).{ 8, 15 }$");

            /* 
             * This regex expression checks to make sure that the PW is between 8 and 15 characters,
             * has both Upper and Lower case, a number, and a special character
             * 
             * this check is done BEFORE we store any new passwords in the system.
             * string regex = @"^(?=.*[a - z])(?=.*[A - Z])(?=.*\d)(?=.*[^\da - zA - Z]).{ 8,15}$";
             * 
             *
             */

            regex.Match(pw.Trim());
            if (regex.Match(pw.Trim()).Success)
            {
                return true;
            }
            else
                return false;
        }

        internal static bool CheckPWValid(object text)
        {
            throw new NotImplementedException();
        }

        public static bool ZipValidate(string zip)
        {
            //first checks to make sure it is only Alpha Numberic Arabic Numerals (can't use
            // isDigits because that returns a LOT of other things)
            // already validated as a good zip code (- at pos 5) then remove the - and set.

            zip = ZipHyphen(zip);

            if (IsDigits(zip))
            {
                //if its 5 or 9 digits long, probably a good zip code. No dictionary searching here.
                if (zip.Length == 5 || zip.Length == 9)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }

        }

        public static bool IsDigits(string s)
        {
            if (s == null || s == "") return false;

            for (int i = 0; i < s.Length; i++)
                if ((s[i] ^ '0') > 9)
                    return false;

            return true;
        }

        public static string ZipHyphen(string zip)
        {
            if (zip.Length == 10 && zip[5] == '-')
            {
                zip = zip.Substring(0, 5) + zip.Substring(6, 4);
            }
            return zip;
        }
    }
}
