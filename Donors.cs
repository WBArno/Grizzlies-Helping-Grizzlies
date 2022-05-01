using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using Microsoft.VisualBasic.FileIO;





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
            DonorNumber = 0;
        }

        public Donors(string donorType, string donorFirstName, string donorLastName, string donorCompanyName,
            string donorEmail, long donorPhoneNumber, string donorAddress, string donorCity,
            string donorState, int donorZip, bool anonymous, int donorNumber)
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

    }
}
