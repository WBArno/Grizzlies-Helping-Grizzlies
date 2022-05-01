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
        public int DonationID { get; set; }
        public decimal DonorID { get; set; }
        public string DonationDate { get; set; }
        public decimal DonationValue { get; set; }
        public string DonationType { get; set; }
        public string DonationDescription { get; set; }



        // Blank Constructor
        public Donations()
        {
            DonorID = 0;
            DonationDate = Convert.ToString(DateTime.Today);
            DonationValue = 0;
            DonationType = "";
            DonationDescription = "";
        }

        public Donations(int donationID, decimal donorID, string donationDate, decimal donationValue, string donationType,
            string donationDescription)
        {
            DonationID = donationID;
            DonorID = donorID;
            DonationDate = donationDate;
            DonationValue = donationValue;
            DonationType = donationType;
            if (donationDescription != "(Optional)") { DonationDescription = donationDescription; }
        }
    }
}