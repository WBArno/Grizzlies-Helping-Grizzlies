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

        public int donorNumber = 0;
        public int donationNumber = 0;

        //
        // Method Declarations
        //

        // fieldType == true: Donors; fieldType == false: Donations
        public Object[] readCSV(String fileLoc, bool fieldType)
        {
            // Old attempts at .csv parsing.
            // FileStream newFileStream = new FileStream(fileLoc, FileMode.Open);
            // StreamReader rd = new StreamReader(newFileStream);

            string donorType = "";
            string donorCompanyName = "";
            string donorFirstName = "";
            string donorLastName = "";
            string donorEmail = "";
            long donorPhoneNumber = 0;          // No, it wouldn't let me define these in the switch statements
            string donorAddress = "";           // or in conditionals, or leave these without values.
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

            
            
            
            Object[] why = new Object[10];              // Why



            TextFieldParser parse = new TextFieldParser(fileLoc);
            parse.TextFieldType = FieldType.Delimited;
            parse.SetDelimiters(",");
            

            for(int i = 0; i < 10; i++)
            {
                count = 0;
                string[] row = parse.ReadFields();
                foreach (string dVal in row)
                {

                    if (fieldType)
                    {
                        switch (count) // There has to be a better way of doing this...
                        {
                            case 0:
                                anon = Boolean.TryParse(dVal, out anon);
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
                    else
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

                if (fieldType)
                {
                    this.donorNumber++;
                    Donors tempDonor = new Donors(donorType, donorFirstName, donorLastName, donorCompanyName, donorEmail, donorPhoneNumber,
                        donorAddress, donorCity, donorState, donorZip, anon, this.donorNumber);
                    why[i] = tempDonor;
                    
                }
                else
                {
                    this.donationNumber++;
                    Donations tempDonation = new Donations(this.donationNumber, donorID, donationDate, donationValue,
                        donationType, donationDescription);
                    why[i] = tempDonation;
                }
            }

            return why;
        }

    }
}
