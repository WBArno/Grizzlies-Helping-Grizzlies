using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
                lib.donorNumber ++;
                labelDrNum.Text = Convert.ToString(lib.donorNumber + 1);
                
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

                Donations DoObj = new Donations(lib.donationNumber, numBoxDrID.Value, 
                    Convert.ToString(dateTimePickerDo.Value).Substring(0, Convert.ToString(dateTimePickerDo.Value).IndexOf(" ")), 
                    numBoxValue.Value, comboBoxDoType.Text, textBoxDoDesc.Text);
                donationsBindingSource.Add(DoObj);
                clearFields(false);
            }
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
        
    }
}
