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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageAddDonors = new System.Windows.Forms.TabPage();
            this.buttonDrClear = new System.Windows.Forms.Button();
            this.comboBoxDrType = new System.Windows.Forms.ComboBox();
            this.buttonDrSubmit = new System.Windows.Forms.Button();
            this.textBoxDrPNumber = new System.Windows.Forms.TextBox();
            this.labelDrEmail = new System.Windows.Forms.Label();
            this.labelDrPNumber = new System.Windows.Forms.Label();
            this.checkBoxAnon = new System.Windows.Forms.CheckBox();
            this.textBoxDrCity = new System.Windows.Forms.TextBox();
            this.labelDrZip = new System.Windows.Forms.Label();
            this.textBoxDrEmail = new System.Windows.Forms.TextBox();
            this.labelDrType = new System.Windows.Forms.Label();
            this.labelDrFName = new System.Windows.Forms.Label();
            this.textBoxDrFName = new System.Windows.Forms.TextBox();
            this.labelDrAddress = new System.Windows.Forms.Label();
            this.textBoxDrAddress = new System.Windows.Forms.TextBox();
            this.labelDrState = new System.Windows.Forms.Label();
            this.textBoxDrCompany = new System.Windows.Forms.TextBox();
            this.labelDrCompany = new System.Windows.Forms.Label();
            this.labelDrLName = new System.Windows.Forms.Label();
            this.textBoxDrLName = new System.Windows.Forms.TextBox();
            this.labelDrCity = new System.Windows.Forms.Label();
            this.textBoxDrState = new System.Windows.Forms.TextBox();
            this.tabPageViewDonors = new System.Windows.Forms.TabPage();
            this.dataGridDonor = new System.Windows.Forms.DataGridView();
            this.DonorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageAddDonations = new System.Windows.Forms.TabPage();
            this.tabPageViewDonations = new System.Windows.Forms.TabPage();
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
            this.textBoxDrZip = new System.Windows.Forms.NumericUpDown();
            this.tabControl.SuspendLayout();
            this.tabPageAddDonors.SuspendLayout();
            this.tabPageViewDonors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDonor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxDrZip)).BeginInit();
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
            this.tabControl.Size = new System.Drawing.Size(874, 411);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageAddDonors
            // 
            this.tabPageAddDonors.Controls.Add(this.textBoxDrZip);
            this.tabPageAddDonors.Controls.Add(this.buttonDrClear);
            this.tabPageAddDonors.Controls.Add(this.comboBoxDrType);
            this.tabPageAddDonors.Controls.Add(this.buttonDrSubmit);
            this.tabPageAddDonors.Controls.Add(this.textBoxDrPNumber);
            this.tabPageAddDonors.Controls.Add(this.labelDrEmail);
            this.tabPageAddDonors.Controls.Add(this.labelDrPNumber);
            this.tabPageAddDonors.Controls.Add(this.checkBoxAnon);
            this.tabPageAddDonors.Controls.Add(this.textBoxDrCity);
            this.tabPageAddDonors.Controls.Add(this.labelDrZip);
            this.tabPageAddDonors.Controls.Add(this.textBoxDrEmail);
            this.tabPageAddDonors.Controls.Add(this.labelDrType);
            this.tabPageAddDonors.Controls.Add(this.labelDrFName);
            this.tabPageAddDonors.Controls.Add(this.textBoxDrFName);
            this.tabPageAddDonors.Controls.Add(this.labelDrAddress);
            this.tabPageAddDonors.Controls.Add(this.textBoxDrAddress);
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
            this.tabPageAddDonors.Size = new System.Drawing.Size(866, 370);
            this.tabPageAddDonors.TabIndex = 0;
            this.tabPageAddDonors.Text = "Donors";
            this.tabPageAddDonors.UseVisualStyleBackColor = true;
            // 
            // buttonDrClear
            // 
            this.buttonDrClear.Location = new System.Drawing.Point(549, 295);
            this.buttonDrClear.Name = "buttonDrClear";
            this.buttonDrClear.Size = new System.Drawing.Size(103, 57);
            this.buttonDrClear.TabIndex = 22;
            this.buttonDrClear.Text = "Clear";
            this.buttonDrClear.UseVisualStyleBackColor = true;
            this.buttonDrClear.Click += new System.EventHandler(this.buttonDrClear_Click);
            // 
            // comboBoxDrType
            // 
            this.comboBoxDrType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDrType.FormattingEnabled = true;
            this.comboBoxDrType.Items.AddRange(new object[] {
            "Individual",
            "Company"});
            this.comboBoxDrType.Location = new System.Drawing.Point(165, 6);
            this.comboBoxDrType.Name = "comboBoxDrType";
            this.comboBoxDrType.Size = new System.Drawing.Size(250, 36);
            this.comboBoxDrType.TabIndex = 0;
            this.comboBoxDrType.SelectedIndexChanged += new System.EventHandler(this.comboBoxDrType_SelectedIndexChanged);
            // 
            // buttonDrSubmit
            // 
            this.buttonDrSubmit.Location = new System.Drawing.Point(225, 295);
            this.buttonDrSubmit.Name = "buttonDrSubmit";
            this.buttonDrSubmit.Size = new System.Drawing.Size(103, 57);
            this.buttonDrSubmit.TabIndex = 21;
            this.buttonDrSubmit.Text = "Submit";
            this.buttonDrSubmit.UseVisualStyleBackColor = true;
            this.buttonDrSubmit.Click += new System.EventHandler(this.buttonDrSubmit_Click);
            // 
            // textBoxDrPNumber
            // 
            this.textBoxDrPNumber.Location = new System.Drawing.Point(612, 100);
            this.textBoxDrPNumber.Name = "textBoxDrPNumber";
            this.textBoxDrPNumber.Size = new System.Drawing.Size(251, 43);
            this.textBoxDrPNumber.TabIndex = 15;
            // 
            // labelDrEmail
            // 
            this.labelDrEmail.AutoSize = true;
            this.labelDrEmail.Location = new System.Drawing.Point(92, 100);
            this.labelDrEmail.Name = "labelDrEmail";
            this.labelDrEmail.Size = new System.Drawing.Size(68, 28);
            this.labelDrEmail.TabIndex = 5;
            this.labelDrEmail.Text = "Email";
            // 
            // labelDrPNumber
            // 
            this.labelDrPNumber.AutoSize = true;
            this.labelDrPNumber.Location = new System.Drawing.Point(444, 103);
            this.labelDrPNumber.Name = "labelDrPNumber";
            this.labelDrPNumber.Size = new System.Drawing.Size(162, 28);
            this.labelDrPNumber.TabIndex = 6;
            this.labelDrPNumber.Text = "Phone Number";
            // 
            // checkBoxAnon
            // 
            this.checkBoxAnon.AutoSize = true;
            this.checkBoxAnon.Location = new System.Drawing.Point(492, 257);
            this.checkBoxAnon.Name = "checkBoxAnon";
            this.checkBoxAnon.Size = new System.Drawing.Size(259, 32);
            this.checkBoxAnon.TabIndex = 20;
            this.checkBoxAnon.Text = "Register Anonymously";
            this.checkBoxAnon.UseVisualStyleBackColor = true;
            // 
            // textBoxDrCity
            // 
            this.textBoxDrCity.Location = new System.Drawing.Point(612, 149);
            this.textBoxDrCity.Name = "textBoxDrCity";
            this.textBoxDrCity.Size = new System.Drawing.Size(251, 43);
            this.textBoxDrCity.TabIndex = 16;
            // 
            // labelDrZip
            // 
            this.labelDrZip.AutoSize = true;
            this.labelDrZip.Location = new System.Drawing.Point(54, 201);
            this.labelDrZip.Name = "labelDrZip";
            this.labelDrZip.Size = new System.Drawing.Size(106, 28);
            this.labelDrZip.TabIndex = 10;
            this.labelDrZip.Text = "ZIP Code";
            // 
            // textBoxDrEmail
            // 
            this.textBoxDrEmail.Location = new System.Drawing.Point(165, 97);
            this.textBoxDrEmail.Name = "textBoxDrEmail";
            this.textBoxDrEmail.Size = new System.Drawing.Size(251, 43);
            this.textBoxDrEmail.TabIndex = 14;
            // 
            // labelDrType
            // 
            this.labelDrType.AutoSize = true;
            this.labelDrType.Location = new System.Drawing.Point(27, 9);
            this.labelDrType.Name = "labelDrType";
            this.labelDrType.Size = new System.Drawing.Size(133, 28);
            this.labelDrType.TabIndex = 1;
            this.labelDrType.Text = "Donor Type";
            // 
            // labelDrFName
            // 
            this.labelDrFName.AutoSize = true;
            this.labelDrFName.Location = new System.Drawing.Point(38, 51);
            this.labelDrFName.Name = "labelDrFName";
            this.labelDrFName.Size = new System.Drawing.Size(122, 28);
            this.labelDrFName.TabIndex = 4;
            this.labelDrFName.Text = "First Name";
            // 
            // textBoxDrFName
            // 
            this.textBoxDrFName.Location = new System.Drawing.Point(165, 48);
            this.textBoxDrFName.Name = "textBoxDrFName";
            this.textBoxDrFName.Size = new System.Drawing.Size(251, 43);
            this.textBoxDrFName.TabIndex = 11;
            // 
            // labelDrAddress
            // 
            this.labelDrAddress.AutoSize = true;
            this.labelDrAddress.Location = new System.Drawing.Point(4, 152);
            this.labelDrAddress.Name = "labelDrAddress";
            this.labelDrAddress.Size = new System.Drawing.Size(155, 28);
            this.labelDrAddress.TabIndex = 7;
            this.labelDrAddress.Text = "Street Address";
            // 
            // textBoxDrAddress
            // 
            this.textBoxDrAddress.Location = new System.Drawing.Point(165, 146);
            this.textBoxDrAddress.Name = "textBoxDrAddress";
            this.textBoxDrAddress.Size = new System.Drawing.Size(251, 43);
            this.textBoxDrAddress.TabIndex = 17;
            // 
            // labelDrState
            // 
            this.labelDrState.AutoSize = true;
            this.labelDrState.Location = new System.Drawing.Point(544, 201);
            this.labelDrState.Name = "labelDrState";
            this.labelDrState.Size = new System.Drawing.Size(62, 28);
            this.labelDrState.TabIndex = 9;
            this.labelDrState.Text = "State";
            // 
            // textBoxDrCompany
            // 
            this.textBoxDrCompany.Location = new System.Drawing.Point(612, 2);
            this.textBoxDrCompany.Name = "textBoxDrCompany";
            this.textBoxDrCompany.Size = new System.Drawing.Size(251, 43);
            this.textBoxDrCompany.TabIndex = 13;
            this.textBoxDrCompany.Visible = false;
            // 
            // labelDrCompany
            // 
            this.labelDrCompany.AutoSize = true;
            this.labelDrCompany.Location = new System.Drawing.Point(434, 9);
            this.labelDrCompany.Name = "labelDrCompany";
            this.labelDrCompany.Size = new System.Drawing.Size(172, 28);
            this.labelDrCompany.TabIndex = 2;
            this.labelDrCompany.Text = "Company Name";
            this.labelDrCompany.Visible = false;
            // 
            // labelDrLName
            // 
            this.labelDrLName.AutoSize = true;
            this.labelDrLName.Location = new System.Drawing.Point(487, 54);
            this.labelDrLName.Name = "labelDrLName";
            this.labelDrLName.Size = new System.Drawing.Size(119, 28);
            this.labelDrLName.TabIndex = 3;
            this.labelDrLName.Text = "Last Name";
            // 
            // textBoxDrLName
            // 
            this.textBoxDrLName.Location = new System.Drawing.Point(612, 51);
            this.textBoxDrLName.Name = "textBoxDrLName";
            this.textBoxDrLName.Size = new System.Drawing.Size(251, 43);
            this.textBoxDrLName.TabIndex = 12;
            // 
            // labelDrCity
            // 
            this.labelDrCity.AutoSize = true;
            this.labelDrCity.Location = new System.Drawing.Point(553, 152);
            this.labelDrCity.Name = "labelDrCity";
            this.labelDrCity.Size = new System.Drawing.Size(53, 28);
            this.labelDrCity.TabIndex = 8;
            this.labelDrCity.Text = "City";
            // 
            // textBoxDrState
            // 
            this.textBoxDrState.Location = new System.Drawing.Point(612, 198);
            this.textBoxDrState.Name = "textBoxDrState";
            this.textBoxDrState.Size = new System.Drawing.Size(251, 43);
            this.textBoxDrState.TabIndex = 18;
            // 
            // tabPageViewDonors
            // 
            this.tabPageViewDonors.Controls.Add(this.dataGridDonor);
            this.tabPageViewDonors.Location = new System.Drawing.Point(4, 37);
            this.tabPageViewDonors.Name = "tabPageViewDonors";
            this.tabPageViewDonors.Size = new System.Drawing.Size(866, 370);
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
            this.dataGridDonor.Size = new System.Drawing.Size(866, 370);
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
            // tabPageAddDonations
            // 
            this.tabPageAddDonations.Location = new System.Drawing.Point(4, 37);
            this.tabPageAddDonations.Name = "tabPageAddDonations";
            this.tabPageAddDonations.Size = new System.Drawing.Size(866, 370);
            this.tabPageAddDonations.TabIndex = 1;
            this.tabPageAddDonations.Text = "Donations";
            this.tabPageAddDonations.UseVisualStyleBackColor = true;
            // 
            // tabPageViewDonations
            // 
            this.tabPageViewDonations.Location = new System.Drawing.Point(4, 37);
            this.tabPageViewDonations.Name = "tabPageViewDonations";
            this.tabPageViewDonations.Size = new System.Drawing.Size(866, 370);
            this.tabPageViewDonations.TabIndex = 3;
            this.tabPageViewDonations.Text = "Donation List";
            this.tabPageViewDonations.UseVisualStyleBackColor = true;
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
            // textBoxDrZip
            // 
            this.textBoxDrZip.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.textBoxDrZip.Location = new System.Drawing.Point(164, 195);
            this.textBoxDrZip.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.textBoxDrZip.Name = "textBoxDrZip";
            this.textBoxDrZip.Size = new System.Drawing.Size(251, 43);
            this.textBoxDrZip.TabIndex = 23;
            this.textBoxDrZip.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // GHGForm
            // 
            this.ClientSize = new System.Drawing.Size(874, 411);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Yu Mincho", 11F);
            this.Name = "GHGForm";
            this.Text = "Grizzlies Helping Grizzlies";
            this.tabControl.ResumeLayout(false);
            this.tabPageAddDonors.ResumeLayout(false);
            this.tabPageAddDonors.PerformLayout();
            this.tabPageViewDonors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDonor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxDrZip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageAddDonors;
        private System.Windows.Forms.Label labelDrType;
        private System.Windows.Forms.ComboBox comboBoxDrType;
        private System.Windows.Forms.Label labelDrFName;
        private System.Windows.Forms.Label labelDrLName;
        private System.Windows.Forms.Label labelDrCompany;
        private System.Windows.Forms.TextBox textBoxDrState;
        private System.Windows.Forms.TextBox textBoxDrAddress;
        private System.Windows.Forms.TextBox textBoxDrCity;
        private System.Windows.Forms.TextBox textBoxDrPNumber;
        private System.Windows.Forms.TextBox textBoxDrEmail;
        private System.Windows.Forms.TextBox textBoxDrCompany;
        private System.Windows.Forms.TextBox textBoxDrLName;
        private System.Windows.Forms.TextBox textBoxDrFName;
        private System.Windows.Forms.Label labelDrZip;
        private System.Windows.Forms.Label labelDrState;
        private System.Windows.Forms.Label labelDrCity;
        private System.Windows.Forms.Label labelDrAddress;
        private System.Windows.Forms.Label labelDrPNumber;
        private System.Windows.Forms.Label labelDrEmail;
        private System.Windows.Forms.CheckBox checkBoxAnon;
        private System.Windows.Forms.TabPage tabPageAddDonations;
        private System.Windows.Forms.Button buttonDrClear;
        private System.Windows.Forms.Button buttonDrSubmit;
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
        private System.Windows.Forms.TabPage tabPageViewDonations;
        private System.Windows.Forms.NumericUpDown textBoxDrZip;
    }
}

