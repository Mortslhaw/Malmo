//MovieTheater
//Kodexempel - Form applikation
//Skapad:  Tim Wahlström Mars 27 2013
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieTheater
{
    public class SeatManager //Tar hand om alla platser
    {
        //Totalt antal platser, läggs in av konstruktorn 
        private readonly int m_totNumOfSeats;
        //Array som lagrar besökarnas namn
        private string[] m_nameList = null;
        //Array som lagrar platsernas pris
        private double[] m_priceList = null;
        /// <summary>
        /// Konstruktor lägg in allt här typ 
        /// </summary>
        /// <param name="maxNumerOfSeats">Antal platser</param>
        public SeatManager(int maxNumerOfSeats)
        {
            m_totNumOfSeats = maxNumerOfSeats;
            m_nameList = new string [m_totNumOfSeats];
            m_priceList = new double [m_totNumOfSeats];
        }
        /// <summary>
        /// Kollar så att index är innom räckhåll för arrayen
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private bool CheckIndex(int index)
        {
            if (index >= 0 && index < m_nameList.Length)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Antalet reserverade platser
        /// </summary>
        /// <returns></returns>
        public int GetNumReserved()
        {
            int NumbOfReservedSeats = 0;//VAriabel lokalt
            for (int i = 0; i < m_nameList.Length; i++)//Kollar igenom hela arrayen 
            {

                if (!String.IsNullOrEmpty(m_nameList[i]))//Är arrayen skilt ifrån empty eller null
                {
                    NumbOfReservedSeats++;
                }
            }
            return NumbOfReservedSeats;//Retunerar alla reserverade platser
        }
        /// <summary>
        /// Kollar upp antalet lediga platser
        /// </summary>
        /// <returns></returns>
        public int GetNumVacant()
        {
            int NumbOfVacantSeats = 0;

            for (int i = 0; i < m_nameList.Length; i++)
            {
                if (string.IsNullOrEmpty(m_nameList[i]))
                {
                    NumbOfVacantSeats++;
                }
            }
            return NumbOfVacantSeats;
        }
        /// <summary>
        /// Hämtar antalet platser
        /// </summary>
        /// <returns></returns>
        public int GetNumOfSeats()
        {
            return m_totNumOfSeats;
        }
        /// <summary>
        /// Ska retunera true eller false om reservation går igenom eller ej
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool ReserveSeat(string name, double price, int index)
        {

        }
        public bool CancelSeat(int index)
        {

        }
        public string GetSeatInfoAt(int index)
        {

        }
        public string[] GetInfoStrings()
        {
            int count = GetNumOfSeats();

            if ((count <= 0))
                return null;

            string[] srtSeatInfoStrings = new string[count];

            for (int index = 0; index <= m_totNumOfSeats - 1; index++)
            {
                srtSeatInfoStrings[index] = GetSeatInfoAt(index);
            }
            return srtSeatInfoStrings;
        }
    }
}
