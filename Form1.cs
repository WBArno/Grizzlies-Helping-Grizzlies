using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grizzlies_Helping_Grizzlies
{
    public partial class GHGForm : Form
    {
        public GHGForm()
        {
            InitializeComponent();
            
            // Applies initial field values from CSV.
            // Only works when running from nested folder; will not work from root
            Object[] what = lib.readCSV("../../resources/donorList.csv", true); // Donors
            foreach (Object why in what)
            {
                donorsBindingSource.Add(why);
            }
            labelDrNum.Text = Convert.ToString(lib.donorNumber + 1);

            Object[] doObj = lib.readCSV("../../resources/donationList.csv", false); // Donations
            foreach (Object dObj in doObj)
            {
                donationsBindingSource.Add(dObj);
            }
            labelDoNum.Text = Convert.ToString(lib.donationNumber + 1);

            // Donors
            labelTlDr.Text = Convert.ToString(lib.donorNumber);
            labelIndCt.Text = Convert.ToString(lib.individualCount);
            labelCmpCt.Text = Convert.ToString(lib.companyCount);

            // Donations
            labelClothingCount.Text = Convert.ToString(lib.donationTypes[0]);
            labelFoodCount.Text = Convert.ToString(lib.donationTypes[1]);
            labelMoneyCount.Text = Convert.ToString(lib.donationTypes[2]);
            labelToyCt.Text = Convert.ToString(lib.donationTypes[3]);
            labelDoToVal.Text = Convert.ToString(lib.donationTotalVal);

            logInPage(true);  // Hides initial tabs for login form


        }
        
        Lib lib = new Lib();




        // Form Actions
        private void buttonDrClear_Click(object sender, EventArgs e) {clearFields(false);} // buttonDoClear
        private void buttonDrClear_Click_1(object sender, EventArgs e) { clearFields(true); } // buttonDrClear
        
        private void buttonDrSubmit_Click_1(object sender, EventArgs e) // buttonDrSubmit
        {
            if (lib.SanityCheck(comboBoxDrType.Text, textBoxDrFName.Text, textBoxDrLName.Text, textBoxDrCompany.Text,
                textBoxDrEmail.Text, textBoxDrPNumber.Text, textBoxDrAddress.Text, textBoxDrCity.Text, textBoxDrState.Text,
                textBoxDrZip.Text, checkBoxAnon.Checked) && lib.ConfirmationBox()) // TODO: Change to method?
            {
                if (checkBoxML.Checked)
                { 
                    MailingList mlObj = new MailingList(textBoxDrEmail.Text);
                    mailingListBindingSource.Add(mlObj);
                }

                lib.donorNumber ++;
                labelDrNum.Text = Convert.ToString(lib.donorNumber + 1);

                labelTlDr.Text = Convert.ToString(lib.donorNumber);
                if (comboBoxDrType.Text == "Individual")
                {
                    lib.individualCount++;
                    labelIndCt.Text = Convert.ToString(lib.individualCount);
                }
                else
                {
                    lib.companyCount++;
                    labelCmpCt.Text = Convert.ToString(lib.companyCount);
                }
                


                Donors DrObj = new Donors(comboBoxDrType.Text, textBoxDrFName.Text, textBoxDrLName.Text, textBoxDrCompany.Text,
                    textBoxDrEmail.Text, Convert.ToInt64(textBoxDrPNumber.Text), textBoxDrAddress.Text, textBoxDrCity.Text, textBoxDrState.Text,
                    Convert.ToInt32(textBoxDrZip.Text), checkBoxAnon.Checked, lib.donorNumber);
                donorsBindingSource.Add(DrObj);
                clearFields(true);
            }
        }

        private void buttonDrSubmit_Click(object sender, EventArgs e) // buttonDoSubmit
        {
            if (lib.InsanityCheck(numBoxDrID.Value, numBoxValue.Value, comboBoxDoType.Text) && lib.ConfirmationBox()) // TODO: Change to method?
            {
                lib.donationNumber ++;
                labelDoNum.Text = Convert.ToString(lib.donationNumber + 1);

                if (comboBoxDoType.Text == "Clothing")
                {
                    lib.donationTypes[0]++;
                    labelClothingCount.Text = Convert.ToString(lib.donationTypes[0]);
                }
                else if (comboBoxDoType.Text == "Food")
                {
                    lib.donationTypes[1]++;
                    labelFoodCount.Text = Convert.ToString(lib.donationTypes[1]);
                }
                else if (comboBoxDoType.Text == "Money")
                {
                    lib.donationTypes[2]++;
                    labelMoneyCount.Text = Convert.ToString(lib.donationTypes[2]);
                }
                else
                {
                    lib.donationTypes[3]++;
                    labelToyCt.Text = Convert.ToString(lib.donationTypes[3]);
                }
                lib.donationTotalVal += Convert.ToDouble(numBoxValue.Value);
                labelDoToVal.Text = Convert.ToString(lib.donationTotalVal);

                Donations DoObj = new Donations(lib.donationNumber, numBoxDrID.Value, 
                    Convert.ToString(dateTimePickerDo.Value).Substring(0, Convert.ToString(dateTimePickerDo.Value).IndexOf(" ")), 
                    numBoxValue.Value, comboBoxDoType.Text, textBoxDoDesc.Text);
                donationsBindingSource.Add(DoObj);
                clearFields(false);
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            logIn(textBoxUsr.Text, textBoxPwd.Text);
        }

        private void comboBoxDrType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxDrType.Text == "Company")
            {
                textBoxDrFName.Enabled = false;
                textBoxDrLName.Enabled = false;
                textBoxDrFName.Clear();
                textBoxDrLName.Clear();

                labelDrCompany.Visible = true;
                textBoxDrCompany.Visible = true;
                textBoxDrFName.Enabled = false;
                textBoxDrLName.Enabled = false;
            }
            else
            {
                textBoxDrFName.Enabled = true;
                textBoxDrLName.Enabled = true;
                labelDrCompany.Visible = false;
                textBoxDrCompany.Visible = false;
                textBoxDrCompany.Clear();
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e) {}
        private void toolTip2_Popup(object sender, PopupEventArgs e) {} // Why are there two toolTips?


        /* clearFields
         * Clears text fields of either donor or donation page dependent upon argument
         * - Args: fieldType: bool which determines whether donors or donations are being handled.
         */
        private void clearFields(bool fieldType)
        {
            if (fieldType) // Donors
            {
                comboBoxDrType.Text = "Individual";
                checkBoxAnon.Checked = false;
                checkBoxML.Checked = false;
                textBoxDrFName.Clear();
                textBoxDrLName.Clear();
                textBoxDrCompany.Clear();
                textBoxDrEmail.Clear();
                textBoxDrPNumber.Clear();
                textBoxDrAddress.Clear();
                textBoxDrCity.Clear();
                textBoxDrState.Clear();
                textBoxDrZip.Value = 0;
            }
            else // Donations
            {
                numBoxDrID.Value = 0;
                dateTimePickerDo.Value = DateTime.Today;
                numBoxValue.Value = 0;
                comboBoxDoType.SelectedIndex = 0;
                textBoxDoDesc.Text = "(Optional)";
            }    
        }

        private void logInPage(bool userLoggedIn) // And Out
        {
            clearFields(true);
            clearFields(false);
            textBoxML.Clear();

            if (!userLoggedIn)
            {
                tabControl.TabPages.Add(tabPageAddDonors);
                tabControl.TabPages.Add(tabPageViewDonors);
                tabControl.TabPages.Add(tabPageAddDonations);
                tabControl.TabPages.Add(tabPageViewDonations);
                tabControl.TabPages.Add(tabPageMailingList);
                tabControl.TabPages.Remove(tabPageLogin);
            }
            else
            {
                tabControl.TabPages.Remove(tabPageAddDonations);
                tabControl.TabPages.Remove(tabPageAddDonors);
                tabControl.TabPages.Remove(tabPageViewDonations);
                tabControl.TabPages.Remove(tabPageViewDonors);
                tabControl.TabPages.Remove(tabPageMailingList);
                if (!tabControl.TabPages.Contains(tabPageLogin))
                {
                    tabControl.TabPages.Add(tabPageLogin);
                }
            }

        }

        private void logIn(string username, string password)
        {
            if (password != "Admin" || username == "")
            {
                logInPage(false);
                tabControl.TabPages.Remove(tabPageViewDonors);
                tabControl.TabPages.Remove(tabPageViewDonations);
                tabControl.TabPages.Remove(tabPageMailingList);

            }
            else
            {
                logInPage(false);
            }
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            if (lib.isValidAddress(textBoxML.Text) && lib.ConfirmationBox())
            {
                MailingList mailObj = new MailingList(textBoxML.Text);
                mailingListBindingSource.Add(mailObj);
            }
            else
            {
                MessageBox.Show("Please enter a valid email.", "Invalid Entry");
            }
        }

        private void buttonLODrAdd_Click(object sender, EventArgs e)
        {
            logInPage(true);
        }

        private void buttonLODrList_Click(object sender, EventArgs e)
        {
            logInPage(true);
        }

        private void buttonLODoAdd_Click(object sender, EventArgs e)
        {
            logInPage(true);
        }

        private void buttonLODoList_Click(object sender, EventArgs e)
        {
            logInPage(true);
        }

        private void buttonLOML_Click(object sender, EventArgs e)
        {
            logInPage(true);
        }
    }
}
