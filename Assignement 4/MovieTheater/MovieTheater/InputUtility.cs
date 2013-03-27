//MovieTheater
//Kodexempel - Form applikation
//Skapad:  Tim Wahlström Mars 27 2013
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieTheater
{
    class InputUtility
    {
        public static bool GetInteger(string stringToConvert, out int intOutValue) //Konverterar strängen till en integer och retunerar värde True eller False.
        {
            if (int.TryParse(stringToConvert, out intOutValue)) //if satsen som bestämmer om det är true eller false
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool GetDouble(string stringToConvert, out double dblOutValue) //Konverterar strängen till en double och retunerar True eller False
        {
            if (double.TryParse(stringToConvert, out dblOutValue)) //if satsen som bestämmer om det är true eller false
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Ser om det är NULL eller negativa tal
        public static bool ValidateString(string stringToCheck)
        {
            //Tar bort mellanslag i början och slutet av strängen
            string strIn = stringToCheck.Trim();
            if (string.IsNullOrEmpty(strIn))
            {
                return false;
            }  
            else 
            {
                return true;
            }
        }//Ser till så att priset är större än 0,0
        public static bool ValidateNumber(double doblToValidate)
        {
            if (doblToValidate <= 0.0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }//Fixar med storabokstäver
        public static string ChngToUC(string stringToUC)
        {
            string strIn = stringToUC.ToUpper();
            return strIn;            
        }//fixar med små bokstäver
        public static string ChngToLC(string stringToLC)
        {
            string strIn = stringToLC.ToLower();
            return strIn;
        }
    }
}
