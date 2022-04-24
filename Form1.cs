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


            // Hiding tabs
            tabPageViewDonors.Hide();
            tabPageViewDonations.Hide();
        }

        Donors dr = new Donors(); // Blank Donors init for Method access. Should probably keep methods in another file.
        int donorNumber = 0;

        // Form Actions
        private void buttonDrClear_Click(object sender, EventArgs e)
        {
            clearDonorFields();
        }

        private void buttonDrSubmit_Click(object sender, EventArgs e)
        {
            if (dr.SanityCheck(comboBoxDrType.Text, textBoxDrFName.Text, textBoxDrLName.Text, textBoxDrCompany.Text,
                    textBoxDrEmail.Text, textBoxDrPNumber.Text, textBoxDrAddress.Text, textBoxDrCity.Text, textBoxDrState.Text,
                    textBoxDrZip2.Text, checkBoxAnon.Checked)) 
            {
                donorNumber += 1;

                Donors DrObj = new Donors(comboBoxDrType.Text, textBoxDrFName.Text, textBoxDrLName.Text, textBoxDrCompany.Text,
                    textBoxDrEmail.Text, textBoxDrPNumber.Text, textBoxDrAddress.Text, textBoxDrCity.Text, textBoxDrState.Text,
                    textBoxDrZip2.Text, checkBoxAnon.Checked, donorNumber);
                donorsBindingSource2.Add(DrObj);
                  clearDonorFields();
            }
        }

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
            textBoxDrZip2.Clear();
            labelDrCompany.Hide();
            textBoxDrCompany.Hide();
        }

        private void comboBoxDrType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDrType.Text == "Company")
            {
                labelDrCompany.Show();
                textBoxDrCompany.Show();
            } else
            {
                labelDrCompany.Hide();
                textBoxDrCompany.Hide();
                textBoxDrCompany.Clear();
            }
        }
    }
}
