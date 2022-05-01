using System;
using System.Collections.Generic;
using System.IO;
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
        public void readCSV(String fileLoc)
        {
            FileStream newFileStream = new FileStream(fileLoc, FileMode.Open);
            StreamReader rd = new StreamReader(newFileStream);
            int count = 0;


            string[] csvOut = new string[10];
            string csvLine;

            while ((csvLine = rd.ReadLine()) != null)
            {
                csvOut.Append(csvLine);
                csvLine = rd.ReadLine();
            }

            

            foreach (string drVal in csvOut)
            {
                string[] drArr = drVal.Split(',');
                foreach (string dVal in drArr)
                {
                    switch (count) // There has to be a better way of doing this...
                    {
                        case 0:
                            if (dVal == "true") { this.Anonymous = true; } else { this.Anonymous = false; }
                            break;
                        case 1:
                            this.DonorType = dVal;
                            break;
                        case 2:
                            this.DonorCompanyName = dVal;
                            break;
                        case 3:
                            this.DonorLastName = dVal;
                            break;
                        case 4:
                            this.DonorFirstName = dVal;
                            break;
                        case 5:
                            this.DonorEmail = dVal;
                            break;
                        case 6:
                            this.DonorPhoneNumber = Convert.ToInt64(dVal);
                            break;
                        case 7:
                            this.DonorAddress = dVal;
                            break;
                        case 8:
                            this.DonorCity = dVal;
                            break;
                        case 9:
                            this.DonorState = dVal;
                            break;
                        case 10:
                            this.DonorZip = Convert.ToInt32(dVal);
                            break;
                    }
                    count += 1;
                }

                Donors tempDonor = new Donors();
                donorsBindingSource.Add(tempDonor);
            }
        }

        public void arrayToDataFrame(string[] arrayIn)
        {
            
        }


        // Checks for invalid entries.
        public bool SanityCheck(string donorType, string donorFirstName, string donorLastName, string donorCompanyName,
            string donorEmail, string donorPhoneNumber, string donorAddress, string donorCity,
            string donorState, string donorZip, bool anonymous)
        {
            // Checks for any blank text boxes
            if ((donorType != "Company" && (donorFirstName == "" || donorLastName == "")) || donorEmail == "" || donorAddress == "" ||
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
