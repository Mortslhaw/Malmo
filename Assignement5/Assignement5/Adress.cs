// Adress.cs
// Tim Wahlström 2013-04-22
// Adress info
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignement5
{
    class Adress
    {
        private string m_street;
        private string m_zipCode;
        private string m_city;
        private Countries m_country;
        /// <summary>
        /// Defult konstruktorn kallar på annan konstruktor i denna klass
        /// </summary>
        public Adress() : this(string.Empty, string.Empty, "Malmö")
        {
        }
        //Kontruktor kallar på nästa konstruktor för att användas igen
        private Adress(string street, string zipCode, string city) : this(street, zip, city, countries.Sverige)
        {
        }
        private Adress(string street, string zipCode, string city, Countries country)
        {
        }
        public string Street;
        public string City;
        public string zipCode;
        public Countries Country;
        /// <summary>
        /// Tar bort alla _ och byter ifrån landets namn och sparas i enum.
        /// </summary>
        /// <returns>Namnet på landet utan understräck</returns>
        public string GetCountryString()
        {
            string strCountry = m_country.ToString();
            strCountry = strCountry.Replace("_", " ");
            return strCountry;
        }
        /// <summary>
        /// Skickar tillbaka detaljerad adressinfo i formaterat format
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string strOut = string.Format("{0,-25} {1,-8} {2,-10} {3}", m_street, m_zipCode, m_city ,GetCountryString());
            return strOut;
        }
    }
}
