using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        Donors dr = new Donors(); // Blank Donors init for Method access. Should probably keep methods in another file.
        Donations dn = new Donations(); // Blank Donors init for Method access.
        int donorNumber = 0;

        // Form Actions
        private void buttonDrClear_Click(object sender, EventArgs e) {clearDonationFields();} // buttonDoClear
        private void buttonDoClear_Click(object sender, EventArgs e) { } // To-Do: Clean up broken button links
        private void buttonDrClear_Click_1(object sender, EventArgs e) { clearDonorFields(); } // buttonDrClear


        private void buttonDrSubmit_Click_1(object sender, EventArgs e) // buttonDrSubmit
        {
            if (dr.SanityCheck(comboBoxDrType.Text, textBoxDrFName.Text, textBoxDrLName.Text, textBoxDrCompany.Text,
                textBoxDrEmail.Text, textBoxDrPNumber.Text, textBoxDrAddress.Text, textBoxDrCity.Text, textBoxDrState.Text,
                textBoxDrZip.Text, checkBoxAnon.Checked))
            {
                donorNumber += 1;

                Donors DrObj = new Donors(comboBoxDrType.Text, textBoxDrFName.Text, textBoxDrLName.Text, textBoxDrCompany.Text,
                    textBoxDrEmail.Text, textBoxDrPNumber.Text, textBoxDrAddress.Text, textBoxDrCity.Text, textBoxDrState.Text,
                    textBoxDrZip.Text, checkBoxAnon.Checked, donorNumber);
                donorsBindingSource2.Add(DrObj);
                clearDonorFields();
            }
        }

        private void buttonDoSubmit_Click(object sender, EventArgs e) { } // To-Do: Clean up broken button links

        private void buttonDrSubmit_Click(object sender, EventArgs e) // buttonDoSubmit
        {
            if (dn.InsanityCheck(numBoxDonID.Value, numBoxDrID.Value, textBoxDoDate.Text, numBoxValue.Value, comboBoxDoType.Text))
            {
                Donations DoObj = new Donations(numBoxDonID.Value, numBoxDrID.Value, textBoxDoDate.Text, numBoxValue.Value, comboBoxDoType.Text, textBoxDoDesc.Text);
                donationsBindingSource.Add(DoObj);
                clearDonationFields();
            }
        }

        private void comboBoxDrType_SelectedIndexChanged(object sender, EventArgs e) { } // To-Do: Clean up broken button links
        private void comboBoxDrType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxDrType.Text == "Company")
            {
                labelDrCompany.Visible = true;
                textBoxDrCompany.Visible = true;
            }
            else
            {
                labelDrCompany.Visible = false;
                textBoxDrCompany.Visible = false;
                textBoxDrCompany.Clear();
            }
        }

        // Clearing Methods
        private void clearDonorFields()
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

        private void clearDonationFields()
        {
            numBoxDonID.Value = 0;
            numBoxDrID.Value = 0;
            textBoxDoDate.Clear();
            numBoxValue.Value = 0;
            comboBoxDoType.SelectedIndex = 0;
            textBoxDoDesc.Text = "(Optional)";
        }
    }
}
