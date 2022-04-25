using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grizzlies_Helping_Grizzlies
{
    internal class Donations
    {
        public decimal DonationID { get; set; }
        public decimal DonorID { get; set; }
        public string DonationDate { get; set; }
        public decimal DonationValue { get; set; }
        public string DonationType { get; set; }
        public string DonationDescription { get; set; }


        // Blank Constructor
        public Donations()
        {
            DonationID = 0;
            DonorID = 0;
            DonationDate = "";
            DonationValue = 0;
            DonationType = "";
            DonationDescription = "";
        }

        public Donations(decimal donationID, decimal donorID, string donationDate, decimal donationValue, string donationType, 
            string donationDescription)
        {
            DonationID = donationID;
            DonorID = donorID;
            DonationDate= donationDate;
            DonationValue = donationValue;
            DonationType = donationType;
            if (donationDescription != "(Optional)") { DonationDescription = donationDescription; }
        }



        // Checks for invalid entries.
        public bool InsanityCheck(decimal donationID, decimal donorID, string donationDate, decimal donationValue, string donationType)
        {
            // Checks for any blank text boxes
            if (donationDate == "" || donationType == "")
            {
                MessageBox.Show("Please fill out all required boxes.", "Invalid Entry");
                return false;
            }
            else if (donationValue <= 0)
            {
                MessageBox.Show("Please enter a valid donation value.", "Invalid Entry");
                return false;
            }
            else if (donationID <= 0)
            {
                MessageBox.Show("Please enter valid Donation ID.", "Invalid Entry");
                return false;
            }
            else if (donorID <= 0)
            {
                MessageBox.Show("Please enter a valid Donor ID.", "Invalid Entry");
                return false;
            }
            else return true;
        }
    }
}
