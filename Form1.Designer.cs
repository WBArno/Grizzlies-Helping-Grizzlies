namespace Grizzlies_Helping_Grizzlies
{
    partial class GHGForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GHGForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageAddDonations = new System.Windows.Forms.TabPage();
            this.numBoxDonID = new System.Windows.Forms.NumericUpDown();
            this.buttonDoClear = new System.Windows.Forms.Button();
            this.comboBoxDoType = new System.Windows.Forms.ComboBox();
            this.buttonDoSubmit = new System.Windows.Forms.Button();
            this.labelDoId = new System.Windows.Forms.Label();
            this.labelDoType = new System.Windows.Forms.Label();
            this.labelDoValue = new System.Windows.Forms.Label();
            this.labelDoDonorID = new System.Windows.Forms.Label();
            this.labelDoDate = new System.Windows.Forms.Label();
            this.textBoxDoDate = new System.Windows.Forms.TextBox();
            this.tabPageViewDonors = new System.Windows.Forms.TabPage();
            this.dataGridDonor = new System.Windows.Forms.DataGridView();
            this.DonorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageAddDonors = new System.Windows.Forms.TabPage();
            this.labelDrEmail = new System.Windows.Forms.Label();
            this.labelDrAddress = new System.Windows.Forms.Label();
            this.textBoxDrZip = new System.Windows.Forms.NumericUpDown();
            this.buttonDrClear = new System.Windows.Forms.Button();
            this.comboBoxDrType = new System.Windows.Forms.ComboBox();
            this.buttonDrSubmit = new System.Windows.Forms.Button();
            this.textBoxDrPNumber = new System.Windows.Forms.TextBox();
            this.labelDrPNumber = new System.Windows.Forms.Label();
            this.checkBoxAnon = new System.Windows.Forms.CheckBox();
            this.textBoxDrCity = new System.Windows.Forms.TextBox();
            this.labelDrZip = new System.Windows.Forms.Label();
            this.textBoxDrAddress = new System.Windows.Forms.TextBox();
            this.labelDrType = new System.Windows.Forms.Label();
            this.labelDrFName = new System.Windows.Forms.Label();
            this.textBoxDrFName = new System.Windows.Forms.TextBox();
            this.textBoxDrEmail = new System.Windows.Forms.TextBox();
            this.labelDrState = new System.Windows.Forms.Label();
            this.textBoxDrCompany = new System.Windows.Forms.TextBox();
            this.labelDrCompany = new System.Windows.Forms.Label();
            this.labelDrLName = new System.Windows.Forms.Label();
            this.textBoxDrLName = new System.Windows.Forms.TextBox();
            this.labelDrCity = new System.Windows.Forms.Label();
            this.textBoxDrState = new System.Windows.Forms.TextBox();
            this.tabPageViewDonations = new System.Windows.Forms.TabPage();
            this.dataGridDonations = new System.Windows.Forms.DataGridView();
            this.numBoxDrID = new System.Windows.Forms.NumericUpDown();
            this.numBoxValue = new System.Windows.Forms.NumericUpDown();
            this.labelDoDesc = new System.Windows.Forms.Label();
            this.textBoxDoDesc = new System.Windows.Forms.TextBox();
            this.anonymousDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.donorTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorCompanyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorPhoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorZipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.donationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donationValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donationTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donationDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabPageAddDonations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxDonID)).BeginInit();
            this.tabPageViewDonors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDonor)).BeginInit();
            this.tabPageAddDonors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxDrZip)).BeginInit();
            this.tabPageViewDonations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDonations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxDrID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageAddDonors);
            this.tabControl.Controls.Add(this.tabPageViewDonors);
            this.tabControl.Controls.Add(this.tabPageAddDonations);
            this.tabControl.Controls.Add(this.tabPageViewDonations);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(879, 362);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageAddDonations
            // 
            this.tabPageAddDonations.Controls.Add(this.labelDoDesc);
            this.tabPageAddDonations.Controls.Add(this.textBoxDoDesc);
            this.tabPageAddDonations.Controls.Add(this.numBoxValue);
            this.tabPageAddDonations.Controls.Add(this.numBoxDrID);
            this.tabPageAddDonations.Controls.Add(this.numBoxDonID);
            this.tabPageAddDonations.Controls.Add(this.buttonDoClear);
            this.tabPageAddDonations.Controls.Add(this.comboBoxDoType);
            this.tabPageAddDonations.Controls.Add(this.buttonDoSubmit);
            this.tabPageAddDonations.Controls.Add(this.labelDoId);
            this.tabPageAddDonations.Controls.Add(this.labelDoType);
            this.tabPageAddDonations.Controls.Add(this.labelDoValue);
            this.tabPageAddDonations.Controls.Add(this.labelDoDonorID);
            this.tabPageAddDonations.Controls.Add(this.labelDoDate);
            this.tabPageAddDonations.Controls.Add(this.textBoxDoDate);
            this.tabPageAddDonations.Location = new System.Drawing.Point(4, 29);
            this.tabPageAddDonations.Name = "tabPageAddDonations";
            this.tabPageAddDonations.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddDonations.Size = new System.Drawing.Size(871, 329);
            this.tabPageAddDonations.TabIndex = 0;
            this.tabPageAddDonations.Text = "Donations";
            this.tabPageAddDonations.UseVisualStyleBackColor = true;
            // 
            // numBoxDonID
            // 
            this.numBoxDonID.Location = new System.Drawing.Point(173, 2);
            this.numBoxDonID.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numBoxDonID.Name = "numBoxDonID";
            this.numBoxDonID.Size = new System.Drawing.Size(251, 43);
            this.numBoxDonID.TabIndex = 23;
            // 
            // buttonDoClear
            // 
            this.buttonDoClear.Location = new System.Drawing.Point(601, 254);
            this.buttonDoClear.Name = "buttonDoClear";
            this.buttonDoClear.Size = new System.Drawing.Size(103, 57);
            this.buttonDoClear.TabIndex = 22;
            this.buttonDoClear.Text = "Clear";
            this.buttonDoClear.UseVisualStyleBackColor = true;
            this.buttonDoClear.Click += new System.EventHandler(this.buttonDrClear_Click);
            // 
            // comboBoxDoType
            // 
            this.comboBoxDoType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDoType.FormattingEnabled = true;
            this.comboBoxDoType.Items.AddRange(new object[] {
            "Clothing",
            "Food",
            "Money",
            "Toys"});
            this.comboBoxDoType.Location = new System.Drawing.Point(395, 106);
            this.comboBoxDoType.Name = "comboBoxDoType";
            this.comboBoxDoType.Size = new System.Drawing.Size(250, 36);
            this.comboBoxDoType.TabIndex = 0;
            this.comboBoxDoType.SelectedIndexChanged += new System.EventHandler(this.comboBoxDrType_SelectedIndexChanged);
            // 
            // buttonDoSubmit
            // 
            this.buttonDoSubmit.Location = new System.Drawing.Point(172, 254);
            this.buttonDoSubmit.Name = "buttonDoSubmit";
            this.buttonDoSubmit.Size = new System.Drawing.Size(103, 57);
            this.buttonDoSubmit.TabIndex = 21;
            this.buttonDoSubmit.Text = "Submit";
            this.buttonDoSubmit.UseVisualStyleBackColor = true;
            this.buttonDoSubmit.Click += new System.EventHandler(this.buttonDrSubmit_Click);
            // 
            // labelDoId
            // 
            this.labelDoId.AutoSize = true;
            this.labelDoId.Location = new System.Drawing.Point(30, 9);
            this.labelDoId.Name = "labelDoId";
            this.labelDoId.Size = new System.Drawing.Size(137, 28);
            this.labelDoId.TabIndex = 10;
            this.labelDoId.Text = "Donation ID";
            // 
            // labelDoType
            // 
            this.labelDoType.AutoSize = true;
            this.labelDoType.Location = new System.Drawing.Point(227, 109);
            this.labelDoType.Name = "labelDoType";
            this.labelDoType.Size = new System.Drawing.Size(162, 28);
            this.labelDoType.TabIndex = 1;
            this.labelDoType.Text = "Donation Type";
            // 
            // labelDoValue
            // 
            this.labelDoValue.AutoSize = true;
            this.labelDoValue.Location = new System.Drawing.Point(520, 58);
            this.labelDoValue.Name = "labelDoValue";
            this.labelDoValue.Size = new System.Drawing.Size(86, 28);
            this.labelDoValue.TabIndex = 4;
            this.labelDoValue.Text = "Value $";
            // 
            // labelDoDonorID
            // 
            this.labelDoDonorID.AutoSize = true;
            this.labelDoDonorID.Location = new System.Drawing.Point(486, 4);
            this.labelDoDonorID.Name = "labelDoDonorID";
            this.labelDoDonorID.Size = new System.Drawing.Size(108, 28);
            this.labelDoDonorID.TabIndex = 2;
            this.labelDoDonorID.Text = "Donor ID";
            // 
            // labelDoDate
            // 
            this.labelDoDate.AutoSize = true;
            this.labelDoDate.Location = new System.Drawing.Point(107, 58);
            this.labelDoDate.Name = "labelDoDate";
            this.labelDoDate.Size = new System.Drawing.Size(60, 28);
            this.labelDoDate.TabIndex = 3;
            this.labelDoDate.Text = "Date";
            // 
            // textBoxDoDate
            // 
            this.textBoxDoDate.Location = new System.Drawing.Point(173, 51);
            this.textBoxDoDate.Name = "textBoxDoDate";
            this.textBoxDoDate.Size = new System.Drawing.Size(251, 43);
            this.textBoxDoDate.TabIndex = 12;
            // 
            // tabPageViewDonors
            // 
            this.tabPageViewDonors.Controls.Add(this.dataGridDonor);
            this.tabPageViewDonors.Location = new System.Drawing.Point(4, 29);
            this.tabPageViewDonors.Name = "tabPageViewDonors";
            this.tabPageViewDonors.Size = new System.Drawing.Size(871, 329);
            this.tabPageViewDonors.TabIndex = 2;
            this.tabPageViewDonors.Text = "Donor List";
            this.tabPageViewDonors.UseVisualStyleBackColor = true;
            // 
            // dataGridDonor
            // 
            this.dataGridDonor.AutoGenerateColumns = false;
            this.dataGridDonor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridDonor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDonor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DonorID,
            this.anonymousDataGridViewCheckBoxColumn,
            this.donorTypeDataGridViewTextBoxColumn,
            this.donorCompanyNameDataGridViewTextBoxColumn,
            this.donorLastNameDataGridViewTextBoxColumn,
            this.donorFirstNameDataGridViewTextBoxColumn,
            this.donorEmailDataGridViewTextBoxColumn,
            this.donorPhoneNumberDataGridViewTextBoxColumn,
            this.donorAddressDataGridViewTextBoxColumn,
            this.donorCityDataGridViewTextBoxColumn,
            this.donorStateDataGridViewTextBoxColumn,
            this.donorZipDataGridViewTextBoxColumn});
            this.dataGridDonor.DataSource = this.donorsBindingSource2;
            this.dataGridDonor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridDonor.Location = new System.Drawing.Point(0, 0);
            this.dataGridDonor.Name = "dataGridDonor";
            this.dataGridDonor.RowHeadersWidth = 62;
            this.dataGridDonor.RowTemplate.Height = 28;
            this.dataGridDonor.Size = new System.Drawing.Size(871, 329);
            this.dataGridDonor.TabIndex = 0;
            // 
            // DonorID
            // 
            this.DonorID.DataPropertyName = "DonorNumber";
            this.DonorID.HeaderText = "ID";
            this.DonorID.MinimumWidth = 8;
            this.DonorID.Name = "DonorID";
            this.DonorID.ReadOnly = true;
            this.DonorID.Width = 74;
            // 
            // tabPageAddDonors
            // 
            this.tabPageAddDonors.Controls.Add(this.labelDrEmail);
            this.tabPageAddDonors.Controls.Add(this.labelDrAddress);
            this.tabPageAddDonors.Controls.Add(this.textBoxDrZip);
            this.tabPageAddDonors.Controls.Add(this.buttonDrClear);
            this.tabPageAddDonors.Controls.Add(this.comboBoxDrType);
            this.tabPageAddDonors.Controls.Add(this.buttonDrSubmit);
            this.tabPageAddDonors.Controls.Add(this.textBoxDrPNumber);
            this.tabPageAddDonors.Controls.Add(this.labelDrPNumber);
            this.tabPageAddDonors.Controls.Add(this.checkBoxAnon);
            this.tabPageAddDonors.Controls.Add(this.textBoxDrCity);
            this.tabPageAddDonors.Controls.Add(this.labelDrZip);
            this.tabPageAddDonors.Controls.Add(this.textBoxDrAddress);
            this.tabPageAddDonors.Controls.Add(this.labelDrType);
            this.tabPageAddDonors.Controls.Add(this.labelDrFName);
            this.tabPageAddDonors.Controls.Add(this.textBoxDrFName);
            this.tabPageAddDonors.Controls.Add(this.textBoxDrEmail);
            this.tabPageAddDonors.Controls.Add(this.labelDrState);
            this.tabPageAddDonors.Controls.Add(this.textBoxDrCompany);
            this.tabPageAddDonors.Controls.Add(this.labelDrCompany);
            this.tabPageAddDonors.Controls.Add(this.labelDrLName);
            this.tabPageAddDonors.Controls.Add(this.textBoxDrLName);
            this.tabPageAddDonors.Controls.Add(this.labelDrCity);
            this.tabPageAddDonors.Controls.Add(this.textBoxDrState);
            this.tabPageAddDonors.Location = new System.Drawing.Point(4, 37);
            this.tabPageAddDonors.Name = "tabPageAddDonors";
            this.tabPageAddDonors.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddDonors.Size = new System.Drawing.Size(871, 321);
            this.tabPageAddDonors.TabIndex = 4;
            this.tabPageAddDonors.Text = "Donors";
            this.tabPageAddDonors.UseVisualStyleBackColor = true;
            // 
            // labelDrEmail
            // 
            this.labelDrEmail.AutoSize = true;
            this.labelDrEmail.Location = new System.Drawing.Point(98, 155);
            this.labelDrEmail.Name = "labelDrEmail";
            this.labelDrEmail.Size = new System.Drawing.Size(68, 28);
            this.labelDrEmail.TabIndex = 25;
            this.labelDrEmail.Text = "Email";
            // 
            // labelDrAddress
            // 
            this.labelDrAddress.AutoSize = true;
            this.labelDrAddress.Location = new System.Drawing.Point(12, 103);
            this.labelDrAddress.Name = "labelDrAddress";
            this.labelDrAddress.Size = new System.Drawing.Size(155, 28);
            this.labelDrAddress.TabIndex = 24;
            this.labelDrAddress.Text = "Street Address";
            // 
            // textBoxDrZip
            // 
            this.textBoxDrZip.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.textBoxDrZip.Location = new System.Drawing.Point(173, 198);
            this.textBoxDrZip.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.textBoxDrZip.Name = "textBoxDrZip";
            this.textBoxDrZip.Size = new System.Drawing.Size(251, 43);
            this.textBoxDrZip.TabIndex = 23;
            // 
            // buttonDrClear
            // 
            this.buttonDrClear.Location = new System.Drawing.Point(601, 254);
            this.buttonDrClear.Name = "buttonDrClear";
            this.buttonDrClear.Size = new System.Drawing.Size(103, 57);
            this.buttonDrClear.TabIndex = 22;
            this.buttonDrClear.Text = "Clear";
            this.buttonDrClear.UseVisualStyleBackColor = true;
            this.buttonDrClear.Click += new System.EventHandler(this.buttonDrClear_Click_1);
            // 
            // comboBoxDrType
            // 
            this.comboBoxDrType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDrType.FormattingEnabled = true;
            this.comboBoxDrType.Items.AddRange(new object[] {
            "Individual",
            "Company"});
            this.comboBoxDrType.Location = new System.Drawing.Point(173, 9);
            this.comboBoxDrType.Name = "comboBoxDrType";
            this.comboBoxDrType.Size = new System.Drawing.Size(250, 36);
            this.comboBoxDrType.TabIndex = 0;
            this.comboBoxDrType.SelectedIndexChanged += new System.EventHandler(this.comboBoxDrType_SelectedIndexChanged_1);
            // 
            // buttonDrSubmit
            // 
            this.buttonDrSubmit.Location = new System.Drawing.Point(172, 254);
            this.buttonDrSubmit.Name = "buttonDrSubmit";
            this.buttonDrSubmit.Size = new System.Drawing.Size(103, 57);
            this.buttonDrSubmit.TabIndex = 21;
            this.buttonDrSubmit.Text = "Submit";
            this.buttonDrSubmit.UseVisualStyleBackColor = true;
            this.buttonDrSubmit.Click += new System.EventHandler(this.buttonDrSubmit_Click_1);
            // 
            // textBoxDrPNumber
            // 
            this.textBoxDrPNumber.Location = new System.Drawing.Point(601, 107);
            this.textBoxDrPNumber.Name = "textBoxDrPNumber";
            this.textBoxDrPNumber.Size = new System.Drawing.Size(251, 43);
            this.textBoxDrPNumber.TabIndex = 15;
            // 
            // labelDrPNumber
            // 
            this.labelDrPNumber.AutoSize = true;
            this.labelDrPNumber.Location = new System.Drawing.Point(433, 110);
            this.labelDrPNumber.Name = "labelDrPNumber";
            this.labelDrPNumber.Size = new System.Drawing.Size(162, 28);
            this.labelDrPNumber.TabIndex = 6;
            this.labelDrPNumber.Text = "Phone Number";
            // 
            // checkBoxAnon
            // 
            this.checkBoxAnon.AutoSize = true;
            this.checkBoxAnon.Location = new System.Drawing.Point(309, 267);
            this.checkBoxAnon.Name = "checkBoxAnon";
            this.checkBoxAnon.Size = new System.Drawing.Size(259, 32);
            this.checkBoxAnon.TabIndex = 20;
            this.checkBoxAnon.Text = "Register Anonymously";
            this.checkBoxAnon.UseVisualStyleBackColor = true;
            // 
            // textBoxDrCity
            // 
            this.textBoxDrCity.Location = new System.Drawing.Point(601, 156);
            this.textBoxDrCity.Name = "textBoxDrCity";
            this.textBoxDrCity.Size = new System.Drawing.Size(251, 43);
            this.textBoxDrCity.TabIndex = 16;
            // 
            // labelDrZip
            // 
            this.labelDrZip.AutoSize = true;
            this.labelDrZip.Location = new System.Drawing.Point(61, 200);
            this.labelDrZip.Name = "labelDrZip";
            this.labelDrZip.Size = new System.Drawing.Size(106, 28);
            this.labelDrZip.TabIndex = 10;
            this.labelDrZip.Text = "ZIP Code";
            // 
            // textBoxDrAddress
            // 
            this.textBoxDrAddress.Location = new System.Drawing.Point(173, 100);
            this.textBoxDrAddress.Name = "textBoxDrAddress";
            this.textBoxDrAddress.Size = new System.Drawing.Size(251, 43);
            this.textBoxDrAddress.TabIndex = 14;
            // 
            // labelDrType
            // 
            this.labelDrType.AutoSize = true;
            this.labelDrType.Location = new System.Drawing.Point(34, 12);
            this.labelDrType.Name = "labelDrType";
            this.labelDrType.Size = new System.Drawing.Size(133, 28);
            this.labelDrType.TabIndex = 1;
            this.labelDrType.Text = "Donor Type";
            // 
            // labelDrFName
            // 
            this.labelDrFName.AutoSize = true;
            this.labelDrFName.Location = new System.Drawing.Point(45, 59);
            this.labelDrFName.Name = "labelDrFName";
            this.labelDrFName.Size = new System.Drawing.Size(122, 28);
            this.labelDrFName.TabIndex = 4;
            this.labelDrFName.Text = "First Name";
            // 
            // textBoxDrFName
            // 
            this.textBoxDrFName.Location = new System.Drawing.Point(173, 51);
            this.textBoxDrFName.Name = "textBoxDrFName";
            this.textBoxDrFName.Size = new System.Drawing.Size(251, 43);
            this.textBoxDrFName.TabIndex = 11;
            // 
            // textBoxDrEmail
            // 
            this.textBoxDrEmail.Location = new System.Drawing.Point(172, 149);
            this.textBoxDrEmail.Name = "textBoxDrEmail";
            this.textBoxDrEmail.Size = new System.Drawing.Size(251, 43);
            this.textBoxDrEmail.TabIndex = 17;
            // 
            // labelDrState
            // 
            this.labelDrState.AutoSize = true;
            this.labelDrState.Location = new System.Drawing.Point(533, 208);
            this.labelDrState.Name = "labelDrState";
            this.labelDrState.Size = new System.Drawing.Size(62, 28);
            this.labelDrState.TabIndex = 9;
            this.labelDrState.Text = "State";
            // 
            // textBoxDrCompany
            // 
            this.textBoxDrCompany.Location = new System.Drawing.Point(601, 9);
            this.textBoxDrCompany.Name = "textBoxDrCompany";
            this.textBoxDrCompany.Size = new System.Drawing.Size(251, 43);
            this.textBoxDrCompany.TabIndex = 13;
            this.textBoxDrCompany.Visible = false;
            // 
            // labelDrCompany
            // 
            this.labelDrCompany.AutoSize = true;
            this.labelDrCompany.Location = new System.Drawing.Point(423, 12);
            this.labelDrCompany.Name = "labelDrCompany";
            this.labelDrCompany.Size = new System.Drawing.Size(172, 28);
            this.labelDrCompany.TabIndex = 2;
            this.labelDrCompany.Text = "Company Name";
            this.labelDrCompany.Visible = false;
            // 
            // labelDrLName
            // 
            this.labelDrLName.AutoSize = true;
            this.labelDrLName.Location = new System.Drawing.Point(476, 61);
            this.labelDrLName.Name = "labelDrLName";
            this.labelDrLName.Size = new System.Drawing.Size(119, 28);
            this.labelDrLName.TabIndex = 3;
            this.labelDrLName.Text = "Last Name";
            // 
            // textBoxDrLName
            // 
            this.textBoxDrLName.Location = new System.Drawing.Point(601, 58);
            this.textBoxDrLName.Name = "textBoxDrLName";
            this.textBoxDrLName.Size = new System.Drawing.Size(251, 43);
            this.textBoxDrLName.TabIndex = 12;
            // 
            // labelDrCity
            // 
            this.labelDrCity.AutoSize = true;
            this.labelDrCity.Location = new System.Drawing.Point(542, 159);
            this.labelDrCity.Name = "labelDrCity";
            this.labelDrCity.Size = new System.Drawing.Size(53, 28);
            this.labelDrCity.TabIndex = 8;
            this.labelDrCity.Text = "City";
            // 
            // textBoxDrState
            // 
            this.textBoxDrState.Location = new System.Drawing.Point(601, 205);
            this.textBoxDrState.Name = "textBoxDrState";
            this.textBoxDrState.Size = new System.Drawing.Size(251, 43);
            this.textBoxDrState.TabIndex = 18;
            // 
            // tabPageViewDonations
            // 
            this.tabPageViewDonations.Controls.Add(this.dataGridDonations);
            this.tabPageViewDonations.Location = new System.Drawing.Point(4, 37);
            this.tabPageViewDonations.Name = "tabPageViewDonations";
            this.tabPageViewDonations.Size = new System.Drawing.Size(871, 321);
            this.tabPageViewDonations.TabIndex = 5;
            this.tabPageViewDonations.Text = "Donation List";
            this.tabPageViewDonations.UseVisualStyleBackColor = true;
            // 
            // dataGridDonations
            // 
            this.dataGridDonations.AutoGenerateColumns = false;
            this.dataGridDonations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridDonations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDonations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.donationIDDataGridViewTextBoxColumn,
            this.donorIDDataGridViewTextBoxColumn,
            this.donationDateDataGridViewTextBoxColumn,
            this.donationValueDataGridViewTextBoxColumn,
            this.donationTypeDataGridViewTextBoxColumn,
            this.donationDescriptionDataGridViewTextBoxColumn});
            this.dataGridDonations.DataSource = this.donationsBindingSource;
            this.dataGridDonations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridDonations.Location = new System.Drawing.Point(0, 0);
            this.dataGridDonations.Name = "dataGridDonations";
            this.dataGridDonations.RowHeadersWidth = 62;
            this.dataGridDonations.RowTemplate.Height = 28;
            this.dataGridDonations.Size = new System.Drawing.Size(871, 321);
            this.dataGridDonations.TabIndex = 0;
            // 
            // numBoxDrID
            // 
            this.numBoxDrID.Location = new System.Drawing.Point(600, 2);
            this.numBoxDrID.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numBoxDrID.Name = "numBoxDrID";
            this.numBoxDrID.Size = new System.Drawing.Size(251, 43);
            this.numBoxDrID.TabIndex = 26;
            // 
            // numBoxValue
            // 
            this.numBoxValue.DecimalPlaces = 2;
            this.numBoxValue.Location = new System.Drawing.Point(601, 56);
            this.numBoxValue.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numBoxValue.Name = "numBoxValue";
            this.numBoxValue.Size = new System.Drawing.Size(251, 43);
            this.numBoxValue.TabIndex = 27;
            this.numBoxValue.ThousandsSeparator = true;
            // 
            // labelDoDesc
            // 
            this.labelDoDesc.AutoSize = true;
            this.labelDoDesc.Location = new System.Drawing.Point(39, 181);
            this.labelDoDesc.Name = "labelDoDesc";
            this.labelDoDesc.Size = new System.Drawing.Size(127, 28);
            this.labelDoDesc.TabIndex = 28;
            this.labelDoDesc.Text = "Description";
            // 
            // textBoxDoDesc
            // 
            this.textBoxDoDesc.Location = new System.Drawing.Point(172, 149);
            this.textBoxDoDesc.Multiline = true;
            this.textBoxDoDesc.Name = "textBoxDoDesc";
            this.textBoxDoDesc.Size = new System.Drawing.Size(680, 99);
            this.textBoxDoDesc.TabIndex = 29;
            this.textBoxDoDesc.Text = "(Optional)";
            // 
            // anonymousDataGridViewCheckBoxColumn
            // 
            this.anonymousDataGridViewCheckBoxColumn.DataPropertyName = "Anonymous";
            this.anonymousDataGridViewCheckBoxColumn.HeaderText = "Anonymous";
            this.anonymousDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.anonymousDataGridViewCheckBoxColumn.Name = "anonymousDataGridViewCheckBoxColumn";
            this.anonymousDataGridViewCheckBoxColumn.Width = 135;
            // 
            // donorTypeDataGridViewTextBoxColumn
            // 
            this.donorTypeDataGridViewTextBoxColumn.DataPropertyName = "DonorType";
            this.donorTypeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.donorTypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.donorTypeDataGridViewTextBoxColumn.Name = "donorTypeDataGridViewTextBoxColumn";
            this.donorTypeDataGridViewTextBoxColumn.Width = 99;
            // 
            // donorCompanyNameDataGridViewTextBoxColumn
            // 
            this.donorCompanyNameDataGridViewTextBoxColumn.DataPropertyName = "DonorCompanyName";
            this.donorCompanyNameDataGridViewTextBoxColumn.HeaderText = "Company";
            this.donorCompanyNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.donorCompanyNameDataGridViewTextBoxColumn.Name = "donorCompanyNameDataGridViewTextBoxColumn";
            this.donorCompanyNameDataGridViewTextBoxColumn.Width = 143;
            // 
            // donorLastNameDataGridViewTextBoxColumn
            // 
            this.donorLastNameDataGridViewTextBoxColumn.DataPropertyName = "DonorLastName";
            this.donorLastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.donorLastNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.donorLastNameDataGridViewTextBoxColumn.Name = "donorLastNameDataGridViewTextBoxColumn";
            this.donorLastNameDataGridViewTextBoxColumn.Width = 149;
            // 
            // donorFirstNameDataGridViewTextBoxColumn
            // 
            this.donorFirstNameDataGridViewTextBoxColumn.DataPropertyName = "DonorFirstName";
            this.donorFirstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.donorFirstNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.donorFirstNameDataGridViewTextBoxColumn.Name = "donorFirstNameDataGridViewTextBoxColumn";
            this.donorFirstNameDataGridViewTextBoxColumn.Width = 152;
            // 
            // donorEmailDataGridViewTextBoxColumn
            // 
            this.donorEmailDataGridViewTextBoxColumn.DataPropertyName = "DonorEmail";
            this.donorEmailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.donorEmailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.donorEmailDataGridViewTextBoxColumn.Name = "donorEmailDataGridViewTextBoxColumn";
            this.donorEmailDataGridViewTextBoxColumn.Width = 104;
            // 
            // donorPhoneNumberDataGridViewTextBoxColumn
            // 
            this.donorPhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "DonorPhoneNumber";
            this.donorPhoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNo";
            this.donorPhoneNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.donorPhoneNumberDataGridViewTextBoxColumn.Name = "donorPhoneNumberDataGridViewTextBoxColumn";
            this.donorPhoneNumberDataGridViewTextBoxColumn.Width = 141;
            // 
            // donorAddressDataGridViewTextBoxColumn
            // 
            this.donorAddressDataGridViewTextBoxColumn.DataPropertyName = "DonorAddress";
            this.donorAddressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.donorAddressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.donorAddressDataGridViewTextBoxColumn.Name = "donorAddressDataGridViewTextBoxColumn";
            this.donorAddressDataGridViewTextBoxColumn.Width = 126;
            // 
            // donorCityDataGridViewTextBoxColumn
            // 
            this.donorCityDataGridViewTextBoxColumn.DataPropertyName = "DonorCity";
            this.donorCityDataGridViewTextBoxColumn.HeaderText = "City";
            this.donorCityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.donorCityDataGridViewTextBoxColumn.Name = "donorCityDataGridViewTextBoxColumn";
            this.donorCityDataGridViewTextBoxColumn.Width = 89;
            // 
            // donorStateDataGridViewTextBoxColumn
            // 
            this.donorStateDataGridViewTextBoxColumn.DataPropertyName = "DonorState";
            this.donorStateDataGridViewTextBoxColumn.HeaderText = "State";
            this.donorStateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.donorStateDataGridViewTextBoxColumn.Name = "donorStateDataGridViewTextBoxColumn";
            this.donorStateDataGridViewTextBoxColumn.Width = 98;
            // 
            // donorZipDataGridViewTextBoxColumn
            // 
            this.donorZipDataGridViewTextBoxColumn.DataPropertyName = "DonorZip";
            this.donorZipDataGridViewTextBoxColumn.HeaderText = "Zip";
            this.donorZipDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.donorZipDataGridViewTextBoxColumn.Name = "donorZipDataGridViewTextBoxColumn";
            this.donorZipDataGridViewTextBoxColumn.Width = 81;
            // 
            // donorsBindingSource2
            // 
            this.donorsBindingSource2.DataSource = typeof(Grizzlies_Helping_Grizzlies.Donors);
            // 
            // donationsBindingSource
            // 
            this.donationsBindingSource.DataSource = typeof(Grizzlies_Helping_Grizzlies.Donations);
            // 
            // donationIDDataGridViewTextBoxColumn
            // 
            this.donationIDDataGridViewTextBoxColumn.DataPropertyName = "DonationID";
            this.donationIDDataGridViewTextBoxColumn.HeaderText = "DonationID";
            this.donationIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.donationIDDataGridViewTextBoxColumn.Name = "donationIDDataGridViewTextBoxColumn";
            this.donationIDDataGridViewTextBoxColumn.Width = 167;
            // 
            // donorIDDataGridViewTextBoxColumn
            // 
            this.donorIDDataGridViewTextBoxColumn.DataPropertyName = "DonorID";
            this.donorIDDataGridViewTextBoxColumn.HeaderText = "DonorID";
            this.donorIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.donorIDDataGridViewTextBoxColumn.Name = "donorIDDataGridViewTextBoxColumn";
            this.donorIDDataGridViewTextBoxColumn.Width = 138;
            // 
            // donationDateDataGridViewTextBoxColumn
            // 
            this.donationDateDataGridViewTextBoxColumn.DataPropertyName = "DonationDate";
            this.donationDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.donationDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.donationDateDataGridViewTextBoxColumn.Name = "donationDateDataGridViewTextBoxColumn";
            this.donationDateDataGridViewTextBoxColumn.Width = 96;
            // 
            // donationValueDataGridViewTextBoxColumn
            // 
            this.donationValueDataGridViewTextBoxColumn.DataPropertyName = "DonationValue";
            this.donationValueDataGridViewTextBoxColumn.HeaderText = "Value";
            this.donationValueDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.donationValueDataGridViewTextBoxColumn.Name = "donationValueDataGridViewTextBoxColumn";
            this.donationValueDataGridViewTextBoxColumn.Width = 104;
            // 
            // donationTypeDataGridViewTextBoxColumn
            // 
            this.donationTypeDataGridViewTextBoxColumn.DataPropertyName = "DonationType";
            this.donationTypeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.donationTypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.donationTypeDataGridViewTextBoxColumn.Name = "donationTypeDataGridViewTextBoxColumn";
            this.donationTypeDataGridViewTextBoxColumn.Width = 99;
            // 
            // donationDescriptionDataGridViewTextBoxColumn
            // 
            this.donationDescriptionDataGridViewTextBoxColumn.DataPropertyName = "DonationDescription";
            this.donationDescriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.donationDescriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.donationDescriptionDataGridViewTextBoxColumn.Name = "donationDescriptionDataGridViewTextBoxColumn";
            this.donationDescriptionDataGridViewTextBoxColumn.Width = 163;
            // 
            // GHGForm
            // 
            this.ClientSize = new System.Drawing.Size(879, 362);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Yu Mincho", 11F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GHGForm";
            this.Text = "Grizzlies Helping Grizzlies";
            this.tabControl.ResumeLayout(false);
            this.tabPageAddDonations.ResumeLayout(false);
            this.tabPageAddDonations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxDonID)).EndInit();
            this.tabPageViewDonors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDonor)).EndInit();
            this.tabPageAddDonors.ResumeLayout(false);
            this.tabPageAddDonors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxDrZip)).EndInit();
            this.tabPageViewDonations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDonations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxDrID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donationsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageAddDonations;
        private System.Windows.Forms.Label labelDoType;
        private System.Windows.Forms.ComboBox comboBoxDoType;
        private System.Windows.Forms.Label labelDoValue;
        private System.Windows.Forms.Label labelDoDate;
        private System.Windows.Forms.Label labelDoDonorID;
        private System.Windows.Forms.TextBox textBoxDoDate;
        private System.Windows.Forms.Label labelDoId;
        private System.Windows.Forms.Button buttonDoClear;
        private System.Windows.Forms.Button buttonDoSubmit;
        private System.Windows.Forms.DataGridView dataGridDonor;
        private System.Windows.Forms.BindingSource donorsBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonorID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn anonymousDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorCompanyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorPhoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorZipDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPageViewDonors;
        private System.Windows.Forms.NumericUpDown numBoxDonID;
        private System.Windows.Forms.TabPage tabPageAddDonors;
        private System.Windows.Forms.Label labelDrEmail;
        private System.Windows.Forms.Label labelDrAddress;
        private System.Windows.Forms.NumericUpDown textBoxDrZip;
        private System.Windows.Forms.Button buttonDrClear;
        private System.Windows.Forms.ComboBox comboBoxDrType;
        private System.Windows.Forms.Button buttonDrSubmit;
        private System.Windows.Forms.TextBox textBoxDrPNumber;
        private System.Windows.Forms.Label labelDrPNumber;
        private System.Windows.Forms.CheckBox checkBoxAnon;
        private System.Windows.Forms.TextBox textBoxDrCity;
        private System.Windows.Forms.Label labelDrZip;
        private System.Windows.Forms.TextBox textBoxDrAddress;
        private System.Windows.Forms.Label labelDrType;
        private System.Windows.Forms.Label labelDrFName;
        private System.Windows.Forms.TextBox textBoxDrFName;
        private System.Windows.Forms.TextBox textBoxDrEmail;
        private System.Windows.Forms.Label labelDrState;
        private System.Windows.Forms.TextBox textBoxDrCompany;
        private System.Windows.Forms.Label labelDrCompany;
        private System.Windows.Forms.Label labelDrLName;
        private System.Windows.Forms.TextBox textBoxDrLName;
        private System.Windows.Forms.Label labelDrCity;
        private System.Windows.Forms.TextBox textBoxDrState;
        private System.Windows.Forms.TabPage tabPageViewDonations;
        private System.Windows.Forms.DataGridView dataGridDonations;
        private System.Windows.Forms.NumericUpDown numBoxDrID;
        private System.Windows.Forms.NumericUpDown numBoxValue;
        private System.Windows.Forms.Label labelDoDesc;
        private System.Windows.Forms.TextBox textBoxDoDesc;
        private System.Windows.Forms.BindingSource donationsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn donationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donationValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donationTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donationDescriptionDataGridViewTextBoxColumn;
    }
}

