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
        private bool CheckIndex(int index)
        {
            if (index >= 0 && index < m_totNumOfSeats)
                return true;
            else
                return false;
        }
        public int GetNumReserved()
        {

        }
        public int GetNumVacant()
        {

        }
        public int GetNumOfSeats()
        {
            return m_totNumOfSeats;
        }
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
