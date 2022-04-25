using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grizzlies_Helping_Grizzlies
{
    internal class Donors
    {
        public string DonorType { get; set; }
        public string DonorFirstName { get; set; }
        public string DonorLastName { get; set; }
        public string DonorCompanyName { get; set; }
        public string DonorEmail { get; set; }
        public long DonorPhoneNumber { get; set; }
        public string DonorAddress { get; set; }
        public string DonorCity { get; set; }
        public string DonorState { get; set; }
        public int DonorZip { get; set; }
        public bool Anonymous { get; set; }
        public int DonorNumber { get; set; }

        // Blank Constructor
        public Donors()
        {
            DonorType = "";
            DonorFirstName = "";
            DonorLastName = "";
            DonorCompanyName = "";
            DonorEmail = "";
            DonorPhoneNumber = 0;
            DonorAddress = "";
            DonorCity = "";
            DonorState = "";
            DonorZip = 0;
            Anonymous = false;
        }

        public Donors(string donorType, string donorFirstName, string donorLastName, string donorCompanyName, 
            string donorEmail, string donorPhoneNumber, string donorAddress, string donorCity, 
            string donorState, string donorZip, bool anonymous, int donorNumber)
        {
            DonorType = donorType;
            DonorPhoneNumber = Convert.ToInt64(donorPhoneNumber);
            Anonymous = anonymous;
            DonorNumber = donorNumber;
            DonorFirstName = donorFirstName;
            DonorLastName = donorLastName;
            DonorCompanyName = donorCompanyName;
            DonorEmail = donorEmail;
            DonorAddress = donorAddress;
            DonorCity = donorCity;
            DonorState = donorState;
            DonorZip = Convert.ToInt32(donorZip);
        }



        // Checks for invalid entries.
        public bool SanityCheck(string donorType, string donorFirstName, string donorLastName, string donorCompanyName,
            string donorEmail, string donorPhoneNumber, string donorAddress, string donorCity,
            string donorState, string donorZip, bool anonymous)
        {
            // Checks for any blank text boxes
            if (donorFirstName == "" || donorLastName == "" || donorEmail == "" || donorAddress == "" ||
                donorCity == "" || donorState == "" || donorZip == "")
            {
                MessageBox.Show("Please fill out all required boxes.", "Invalid Entry");
                return false;
            }
            else if (!Int64.TryParse(donorPhoneNumber, out _) || donorPhoneNumber.Length != 10)
            {
                MessageBox.Show("Please enter a valid phone number (no spaces or punctuation.)", "Invalid Entry");
                return false;
            }
            else if (!Int32.TryParse(donorZip, out _) || donorZip.Length != 5)
            {
                MessageBox.Show("Please enter a valid, five-digit ZIP code.", "Invalid Entry");
                return false;
            }
            else if (donorType == "Company" && donorCompanyName == "")
            {
                MessageBox.Show("Please enter a valid company name.", "Invalid Entry");
                return false;
            }
            else return true;
        }
    }
}
