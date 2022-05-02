using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

// Yes, the Microsoft.VisualBasic import works for some reason.
// It was either this or installing a nuget addon just to make C# handle .csv files in a sane manner.

namespace Grizzlies_Helping_Grizzlies
{
    public class Lib
    {
        // Init other classes
        Donors dr = new Donors();
        Donations dn = new Donations();

        // Init program-wide vars. TODO: Change to Get-Set rather than making everything public. (?)
        public int donorNumber = 0;
        public int donationNumber = 0;




        /*
         * Method Declarations
         */


        /* readCSV
         * Reads CSV Files and returns an object array to add to the BindingSource in Form1.cs
         * - Args: fileLoc: File Location of CSV,
         * fieldType: bool which determines whether donors or donations are being handled.
         * Returns: Array of objects made of each line of the CSV.
         */
        public Object[] readCSV(String fileLoc, bool fieldType) // fieldType == true: Donors; fieldType == false: Donations
        {
            // Old attempts at .csv parsing:
            // FileStream newFileStream = new FileStream(fileLoc, FileMode.Open);
            // StreamReader rd = new StreamReader(newFileStream);

            string donorType = "";
            string donorCompanyName = "";
            string donorFirstName = "";
            string donorLastName = "";
            string donorEmail = "";
            long donorPhoneNumber = 0;          // TODO: Use an array and convert to necessary vars at object decl.
            string donorAddress = "";           
            string donorCity = "";
            string donorState = "";
            int donorZip = 0;
            string donationDate = "";
            string donationType = "";
            string donationDescription = "";
            decimal donorID = 0;
            decimal donationValue = 0;
            bool anon = false;
            int count;


            Object[] why = new Object[10];


            TextFieldParser parse = new TextFieldParser(fileLoc);
            parse.TextFieldType = FieldType.Delimited;
            parse.SetDelimiters(",");
            

            for(int i = 0; i < 10; i++) // Parses each row in the CSV TODO: Make i not reliant on static endpoint.
            {
                count = 0;
                string[] row = parse.ReadFields(); 
                foreach (string dVal in row) // Processes each value in a row.
                {

                    if (fieldType) // Donors
                    {
                        switch (count) // Should have used an array... An If-Else tree of this would be nightmarish.
                        {              
                            case 0:
                                anon = Convert.ToBoolean(dVal);
                                break;
                            case 1:
                                donorType = dVal;
                                break;
                            case 2:
                                donorCompanyName = dVal;
                                break;
                            case 3:
                                donorLastName = dVal;
                                break;
                            case 4:
                                donorFirstName = dVal;
                                break;
                            case 5:
                                donorEmail = dVal;
                                break;
                            case 6:
                                donorPhoneNumber = Convert.ToInt64(dVal);
                                break;
                            case 7:
                                donorAddress = dVal;
                                break;
                            case 8:
                                donorCity = dVal;
                                break;
                            case 9:
                                donorState = dVal;
                                break;
                            case 10:
                                donorZip = Convert.ToInt32(dVal);
                                break;
                            default:
                                MessageBox.Show("This message shouldn't appear.\nDonor Switch Statement.");
                                break;
                        }
                    }
                    else // Donations
                    {
                        switch (count)
                        {
                            case 0:
                                donorID = Convert.ToDecimal(dVal);
                                break;
                            case 1:
                                donationDate = dVal;
                                break;
                            case 2:
                                donationValue = Convert.ToDecimal(dVal);
                                break;
                            case 3:
                                donationType = dVal;
                                break;
                            case 4:
                                donationDescription = dVal;
                                break;
                            default:
                                MessageBox.Show("This message shouldn't appear.\nDonations Switch Statement.");
                                break;
                        }
                    }
                    count += 1;
                }

                if (fieldType) // Donors
                {
                    this.donorNumber++;
                    Donors tempDonor = new Donors(donorType, donorFirstName, donorLastName, donorCompanyName, donorEmail, donorPhoneNumber,
                        donorAddress, donorCity, donorState, donorZip, anon, this.donorNumber);
                    why[i] = tempDonor;
                    
                }
                else // Donations
                {
                    this.donationNumber++;
                    Donations tempDonation = new Donations(this.donationNumber, donorID, donationDate, donationValue,
                        donationType, donationDescription);
                    why[i] = tempDonation;
                }
            }

            return why; // Returns Object array for addition in Form1.cs.
        }


        /* SanityCheck (Donors)
         * 
         * Takes values from donor entries and ensures that they are valid
         * - Args: ...All Object values for Donor() aside from donorNumber
         * - Returns: Bool of whether the test was considered valid.
         * TODO: Pass string array through rather than 11 vars.
         */
        public bool SanityCheck(string donorType, string donorFirstName, string donorLastName, string donorCompanyName,
            string donorEmail, string donorPhoneNumber, string donorAddress, string donorCity,
            string donorState, string donorZip, bool anonymous)
        {
            // Checks for any blank text boxes
            if ((donorType != "Company" && (donorFirstName == "" || donorLastName == "")) ||
                donorEmail == "" || donorAddress == "" || donorCity == "" || donorState == "" || donorZip == "")
            {
                MessageBox.Show("Please fill out all required boxes.", "Invalid Entry");
                return false;
            }
            // Checks for valid Phone Number
            else if (!Int64.TryParse(donorPhoneNumber, out _) || donorPhoneNumber.Length != 10)
            {
                MessageBox.Show("Please enter a valid phone number (no spaces or punctuation.)", "Invalid Entry");
                return false;
            }
            // Checks for valid Zip
            else if (!Int32.TryParse(donorZip, out _) || donorZip.Length != 5)
            {
                MessageBox.Show("Please enter a valid, five-digit ZIP code.", "Invalid Entry");
                return false;
            }
            // Ensures that donorCompanyName is filled out properly if selected.
            else if (donorType == "Company" && donorCompanyName == "")
            {
                MessageBox.Show("Please enter a valid company name.", "Invalid Entry");
                return false;
            }
            else return true;
        }


        /* InsanityCheck (Donations)
         * Takes values from donation entries and ensures that they are valid
         * - Args: ...All Object values for Donation() aside from donationNumber, date, and description
         * - Returns: Bool of whether the test was completed successfully
         */
        public bool InsanityCheck(decimal donorID, decimal donationValue, string donationType)
        {
            // Checks for any blank text boxes
            if (donationType == "")
            {
                MessageBox.Show("Please fill out all required boxes.", "Invalid Entry");
                return false;
            }
            else if (donationValue <= 0)
            {
                MessageBox.Show("Please enter a valid donation value.", "Invalid Entry");
                return false;
            }
            else if (donorID <= 0)
            {
                MessageBox.Show("Please enter a valid Donor ID.", "Invalid Entry");
                return false;
            }
            else return true;
        }


        /* ConfirmationBox
         * Simple Method that asks whether the person would like to submit and returns their answer
         * - Returns: bool of the user's choice of whether to continue
         */
        public bool ConfirmationBox()
        {
            if (MessageBox.Show("Are you sure that you would like to submit this form?", "Confirmation",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
