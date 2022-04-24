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
        private TabControl tabControl;
        private TabPage Donors;
        private Label labelDType;
        private ComboBox comboBoxDonorType;
        private Label labelFName;
        private Label labelLName;
        private Label label2;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBoxPNumber;
        private TextBox textBoxEmail;
        private TextBox textBoxCName;
        private TextBox textBoxLName;
        private TextBox textBoxFName;
        private Label label6;
        private Label labelState;
        private Label labelCity;
        private Label labelStAddress;
        private Label labelPNumber;
        private Label labelEmail;
        private CheckBox checkBoxAnon;
        private TabPage tabPage1;

        public GHGForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Donors = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBoxDonorType = new System.Windows.Forms.ComboBox();
            this.labelDType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLName = new System.Windows.Forms.Label();
            this.labelFName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPNumber = new System.Windows.Forms.Label();
            this.labelStAddress = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.textBoxCName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPNumber = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.checkBoxAnon = new System.Windows.Forms.CheckBox();
            this.tabControl.SuspendLayout();
            this.Donors.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Donors);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1296, 646);
            this.tabControl.TabIndex = 0;
            // 
            // Donors
            // 
            this.Donors.Controls.Add(this.checkBoxAnon);
            this.Donors.Controls.Add(this.textBox4);
            this.Donors.Controls.Add(this.textBox3);
            this.Donors.Controls.Add(this.textBox2);
            this.Donors.Controls.Add(this.textBox1);
            this.Donors.Controls.Add(this.textBoxPNumber);
            this.Donors.Controls.Add(this.textBoxEmail);
            this.Donors.Controls.Add(this.textBoxCName);
            this.Donors.Controls.Add(this.textBoxLName);
            this.Donors.Controls.Add(this.textBoxFName);
            this.Donors.Controls.Add(this.label6);
            this.Donors.Controls.Add(this.labelState);
            this.Donors.Controls.Add(this.labelCity);
            this.Donors.Controls.Add(this.labelStAddress);
            this.Donors.Controls.Add(this.labelPNumber);
            this.Donors.Controls.Add(this.labelEmail);
            this.Donors.Controls.Add(this.labelFName);
            this.Donors.Controls.Add(this.labelLName);
            this.Donors.Controls.Add(this.label2);
            this.Donors.Controls.Add(this.labelDType);
            this.Donors.Controls.Add(this.comboBoxDonorType);
            this.Donors.Location = new System.Drawing.Point(8, 51);
            this.Donors.Name = "Donors";
            this.Donors.Padding = new System.Windows.Forms.Padding(3);
            this.Donors.Size = new System.Drawing.Size(1280, 587);
            this.Donors.TabIndex = 0;
            this.Donors.Text = "Donors";
            this.Donors.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(8, 51);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(973, 587);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Donations";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBoxDonorType
            // 
            this.comboBoxDonorType.FormattingEnabled = true;
            this.comboBoxDonorType.Items.AddRange(new object[] {
            "Individual",
            "Company"});
            this.comboBoxDonorType.Location = new System.Drawing.Point(269, 53);
            this.comboBoxDonorType.Name = "comboBoxDonorType";
            this.comboBoxDonorType.Size = new System.Drawing.Size(250, 45);
            this.comboBoxDonorType.TabIndex = 0;
            this.comboBoxDonorType.Text = "Individual";
            // 
            // labelDType
            // 
            this.labelDType.AutoSize = true;
            this.labelDType.Location = new System.Drawing.Point(83, 56);
            this.labelDType.Name = "labelDType";
            this.labelDType.Size = new System.Drawing.Size(180, 39);
            this.labelDType.TabIndex = 1;
            this.labelDType.Text = "Donor Type";
            this.labelDType.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Company Name";
            // 
            // labelLName
            // 
            this.labelLName.AutoSize = true;
            this.labelLName.Location = new System.Drawing.Point(629, 120);
            this.labelLName.Name = "labelLName";
            this.labelLName.Size = new System.Drawing.Size(159, 39);
            this.labelLName.TabIndex = 3;
            this.labelLName.Text = "Last Name";
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Location = new System.Drawing.Point(98, 120);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(165, 39);
            this.labelFName.TabIndex = 4;
            this.labelFName.Text = "First Name";
            this.labelFName.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(695, 180);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(93, 39);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "Email";
            // 
            // labelPNumber
            // 
            this.labelPNumber.AutoSize = true;
            this.labelPNumber.Location = new System.Drawing.Point(567, 60);
            this.labelPNumber.Name = "labelPNumber";
            this.labelPNumber.Size = new System.Drawing.Size(221, 39);
            this.labelPNumber.TabIndex = 6;
            this.labelPNumber.Text = "Phone Number";
            // 
            // labelStAddress
            // 
            this.labelStAddress.AutoSize = true;
            this.labelStAddress.Location = new System.Drawing.Point(53, 237);
            this.labelStAddress.Name = "labelStAddress";
            this.labelStAddress.Size = new System.Drawing.Size(210, 39);
            this.labelStAddress.TabIndex = 7;
            this.labelStAddress.Text = "Street Address";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(190, 297);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(73, 39);
            this.labelCity.TabIndex = 8;
            this.labelCity.Text = "City";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(705, 297);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(83, 39);
            this.labelState.TabIndex = 9;
            this.labelState.Text = "State";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 39);
            this.label6.TabIndex = 10;
            this.label6.Text = "ZIP Code";
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(268, 114);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(251, 54);
            this.textBoxFName.TabIndex = 11;
            // 
            // textBoxLName
            // 
            this.textBoxLName.Location = new System.Drawing.Point(794, 117);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(251, 54);
            this.textBoxLName.TabIndex = 12;
            // 
            // textBoxCName
            // 
            this.textBoxCName.Location = new System.Drawing.Point(269, 174);
            this.textBoxCName.Name = "textBoxCName";
            this.textBoxCName.Size = new System.Drawing.Size(251, 54);
            this.textBoxCName.TabIndex = 13;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(794, 177);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(251, 54);
            this.textBoxEmail.TabIndex = 14;
            // 
            // textBoxPNumber
            // 
            this.textBoxPNumber.Location = new System.Drawing.Point(794, 57);
            this.textBoxPNumber.Name = "textBoxPNumber";
            this.textBoxPNumber.Size = new System.Drawing.Size(251, 54);
            this.textBoxPNumber.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(269, 294);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 54);
            this.textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(268, 234);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(777, 54);
            this.textBox2.TabIndex = 17;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(794, 294);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(251, 54);
            this.textBox3.TabIndex = 18;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(268, 354);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(251, 54);
            this.textBox4.TabIndex = 19;
            // 
            // checkBoxAnon
            // 
            this.checkBoxAnon.AutoSize = true;
            this.checkBoxAnon.Location = new System.Drawing.Point(698, 355);
            this.checkBoxAnon.Name = "checkBoxAnon";
            this.checkBoxAnon.Size = new System.Drawing.Size(347, 43);
            this.checkBoxAnon.TabIndex = 20;
            this.checkBoxAnon.Text = "Register Anonymously";
            this.checkBoxAnon.UseVisualStyleBackColor = true;
            // 
            // GHGForm
            // 
            this.ClientSize = new System.Drawing.Size(1296, 646);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Yu Mincho", 11F);
            this.Name = "GHGForm";
            this.Text = "Grizzlies Helping Grizzlies";
            this.tabControl.ResumeLayout(false);
            this.Donors.ResumeLayout(false);
            this.Donors.PerformLayout();
            this.ResumeLayout(false);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
