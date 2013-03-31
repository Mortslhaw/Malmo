//MovieTheater
//Kodexempel - Form applikation
//Skapad:  Tim Wahlström Mars 27 2013
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MovieTheater
{
    public partial class MainForm : Form
    {
        private const int totalNumOfSeats = 60; //Testvariablar för att testa
        private int numOfReservedSeats = 0; //Över när reservation görs

        private SeatManager m_seatMngr;

        public MainForm()
        {
            InitializeComponent(); //Ett måste av

            m_seatMngr = new SeatManager(totalNumOfSeats); //Hämtar antal platser lägger in i seatmanager
            InitializeGUI(); //Anropar all input/output kontroll
        }

        private void InitializeGUI() //Anropar kontroller
        {
            ReserveraRadioButton.Checked = true; //Sätt som Defult
            NamnTextBox.Text = string.Empty; //Tömmer Textboxen
            PrisTextBox.Text = string.Empty; //Tömmer Textboxen
            LabelTotaltAntalPlatser.Text = totalNumOfSeats.ToString();//Skriver ut antal platser i salen

            UpdateGUI();
        }

        private void OK_Click(object sender, EventArgs e)//Ok knappen
        {
            ReserveOrCancelSeat();
        }
        /// <summary>
        /// För att både reservera och makulera, hade nog blivit finare med en uppdelning av metoder och kört på en metod för reservera och en för makulera..
        /// </summary>
        private void ReserveOrCancelSeat() 
        {
            if (CheckSelectedIndex() == true)
            {
                string name = string.Empty;
                double seatPrice = 0.0;
                int selectedSeat = ReservationsListBox.SelectedIndex;
                bool checkResrvSeat = false;
                bool checkCancSeat = false;
                if (ReserveraRadioButton.Checked)
                {
                    DialogResult question = MessageBox.Show("Är du verkligen säker?", "Bekräftat", MessageBoxButtons.YesNo);

                    if (question == DialogResult.Yes)//Klickat på ja
                    {
                        
                        if (ReadAndValidateInput(out name, out seatPrice) == true && true)
                        {
                           checkResrvSeat = m_seatMngr.ReserveSeat(name, seatPrice, selectedSeat);
                           if (checkResrvSeat == true)
                           {
                               MessageBox.Show("Reseverat");
                               UpdateGUI();
                           }
                           else
                           {
                               MessageBox.Show("Redan reserverad plats du får makulera reservationen för att kunna reservera");
                           }
                        }

                    }
                }
                else
                {
                    DialogResult question = MessageBox.Show("Är du verkligen säker?", "Bekräftat", MessageBoxButtons.YesNo);

                    if (question == DialogResult.Yes)//Klickat på ja
                    {
                       checkCancSeat = m_seatMngr.CancelSeat(selectedSeat);
                       if (checkCancSeat == true)
                       {
                           MessageBox.Show("Makulerat!");
                           UpdateGUI();
                       }
                       else
                       {
                           MessageBox.Show("Platsen är redan ledig går bra att boka den");
                       }
                    }
                }
                UpdateGUI();
            }
        }
        /// <summary>
        /// Har hand om all ionfo om platserna
        /// </summary>
        /// <param name="cutmName"></param>
        /// <param name="price"></param>
        private void UpdateGUI()
        {
            ReservationsListBox.Items.Clear();//Rensar så att det inte ligger ngt skit kvar

            ReservationsListBox.Items.AddRange(m_seatMngr.GetInfoStrings()); //Lägger till alla rader ifrån arrayen till listboxen

            //Alla lediga samt tomma platser skrivs ut
            LabelAntalTommaPlatser.Text = m_seatMngr.GetNumVacant().ToString();
            LabelAntalReserverade.Text = m_seatMngr.GetNumReserved().ToString();
        }
        private bool ReadAndValidateInput(out string name, out double price)
        {
            name = string.Empty;
            price = 0.0;

            //Kallar metoder och kollar indata
            //nameOK får värde True eller False beroende på om Nbname är empty eller NULL
            bool nameOK = ReadValidateName(out name);

            bool priceOK = ReadValidatePrice(out price);



            return nameOK && priceOK; //True om båda är True annars blir det False
        }

        private bool ReadValidatePrice(out double price)
        {
            double.TryParse(PrisTextBox.Text, out price);

            //kollar så om det är något skrivet på pris
            if (!InputUtility.ValidateNumber(price))
            {
                MessageBox.Show("Hörredu! Du måste skriva ett pris ju!");
                PrisTextBox.Focus();
                PrisTextBox.Text = " ";
                PrisTextBox.SelectAll();
                return false;
            }
            else
                return true;
        }

        private bool ReadValidateName(out string name)
        {
            name = NamnTextBox.Text;

            if (!InputUtility.ValidateString(name))
            {
                //informerar användaren om att det är fel
                MessageBox.Show("Fel namn vid input! Du måste skriva ett namn på riktigt!" + Environment.NewLine + "och namnet måste minst ha ett tecken (inte mellanslag)", "Error!");
                NamnTextBox.Focus();
                NamnTextBox.Text = " ";
                NamnTextBox.SelectAll();
                return false;
            }
            else
            {
                return true;
            }
        }
        private void ReserveraRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //gör att det går att skriva i textboxarna för namn och pris
            NamnTextBox.Enabled = true;
            PrisTextBox.Enabled = true;
        }

        private void AvslutaReservationRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Tar bort möjligheten att skriva i textboxarna för namn och pris
            NamnTextBox.Enabled = false;
            PrisTextBox.Enabled = false;
        }
        /// <summary>
        /// Kollar så att listboxen stämmer, vad som är markerat osv
        /// </summary>
        /// <returns></returns>
        private bool CheckSelectedIndex()
        {
            if (ReservationsListBox.SelectedIndex != -1)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Har du valt en plats i listan?!?");
                return false;
            }
        }
	}
}
