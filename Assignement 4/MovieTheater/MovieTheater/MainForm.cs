//MovieTheater
//Kodexempel - Form applikation
//Skapad:  Tim Wahlström Mars 7 2013
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
        private const int totalNumOfSeats = 20 * 30; //Testvariablar för att testa
        private int numOfReservedSeats = 0; //Över när reservation görs

        public MainForm()
        {
            InitializeComponent(); //Ett måste av

            InitializeGUI(); //Anropar all input/output kontroll
        }

        private void InitializeGUI() //Anropar kontroller
        {
            ReserveraRadioButton.Checked = true; //Sätt som Defult
            ReservationsListBox.Items.Clear(); //Tömmer Listboxen
            NamnTextBox.Text = string.Empty; //Tömmer Textboxen
            PrisTextBox.Text = string.Empty; //Tömmer Textboxen
            LabelTotaltAntalPlatser.Text = totalNumOfSeats.ToString();//Skriver ut antal platser i salen
        }

        private void OK_Click(object sender, EventArgs e)//Ok knappen
        {
            string cutmName = string.Empty;
            double seatPrice = 0.0;

            bool inputOK = ReadAndValidateInput(out cutmName, out seatPrice);

            if (inputOK)
            {
                if (ReserveraRadioButton.Checked)
                {
                    numOfReservedSeats++;
                }
                else
                {
                    numOfReservedSeats--;
                }
                UpdateGUI(cutmName, seatPrice);
            }
        }

        private void UpdateGUI(string cutmName, double price)
        {
            string strOut = string.Empty;
            string strResed = "Ledig ";

            if (ReserveraRadioButton.Checked)//Om plats är reserverad
                strResed = "Reserverad ";
            //Formaterar strängen så den passar listboxen
            strOut = string.Format("{0,5}{1,-8}{2,-18}{3, 10:f2}"," - ", strResed, cutmName, price);
            ReservationsListBox.Items.Add(strOut);

            LabelAntalTommaPlatser.Text = (totalNumOfSeats - numOfReservedSeats).ToString();
            LabelAntalReserverade.Text = numOfReservedSeats.ToString();
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
    }
}
