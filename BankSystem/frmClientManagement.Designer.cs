namespace BankSystem
{
    partial class frmClientManagement
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
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.cmdNewTransaction = new System.Windows.Forms.Button();
            this.cmdCloseAccount = new System.Windows.Forms.Button();
            this.cmdAllTransactions = new System.Windows.Forms.Button();
            this.cmdWithdrawal = new System.Windows.Forms.Button();
            this.cmdDeposit = new System.Windows.Forms.Button();
            this.gwCardsView = new System.Windows.Forms.DataGridView();
            this.gbCarsView = new System.Windows.Forms.GroupBox();
            this.gbClientInfo = new System.Windows.Forms.GroupBox();
            this.gbCustContact = new System.Windows.Forms.GroupBox();
            this.lblEMailValue = new System.Windows.Forms.Label();
            this.lblPhoneValue = new System.Windows.Forms.Label();
            this.lblEMail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbCustAddress = new System.Windows.Forms.GroupBox();
            this.lblCountryValue = new System.Windows.Forms.Label();
            this.lblCityValue = new System.Windows.Forms.Label();
            this.lblPostcodeValue = new System.Windows.Forms.Label();
            this.lblAddressValue = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.gbCustInfo = new System.Windows.Forms.GroupBox();
            this.lblIDCardNumValue = new System.Windows.Forms.Label();
            this.lblBDayValue = new System.Windows.Forms.Label();
            this.lblLNameValue = new System.Windows.Forms.Label();
            this.lblMNameValue = new System.Windows.Forms.Label();
            this.lblFNameValue = new System.Windows.Forms.Label();
            this.lblTitleValue = new System.Windows.Forms.Label();
            this.lblCustIdValue = new System.Windows.Forms.Label();
            this.lblIDCardNum = new System.Windows.Forms.Label();
            this.lblBDay = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblMName = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCustId = new System.Windows.Forms.Label();
            this.lblSuffixValue = new System.Windows.Forms.Label();
            this.lblSuffix = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gwCardsView)).BeginInit();
            this.gbCarsView.SuspendLayout();
            this.gbClientInfo.SuspendLayout();
            this.gbCustContact.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbCustAddress.SuspendLayout();
            this.gbCustInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdUpdate.Location = new System.Drawing.Point(102, 58);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(112, 23);
            this.cmdUpdate.TabIndex = 4;
            this.cmdUpdate.Text = "Update info";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // cmdNewTransaction
            // 
            this.cmdNewTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdNewTransaction.Location = new System.Drawing.Point(171, 187);
            this.cmdNewTransaction.Name = "cmdNewTransaction";
            this.cmdNewTransaction.Size = new System.Drawing.Size(112, 23);
            this.cmdNewTransaction.TabIndex = 5;
            this.cmdNewTransaction.Text = "New transaction";
            this.cmdNewTransaction.UseVisualStyleBackColor = true;
            this.cmdNewTransaction.Click += new System.EventHandler(this.cmdNewTransaction_Click);
            // 
            // cmdCloseAccount
            // 
            this.cmdCloseAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCloseAccount.Location = new System.Drawing.Point(37, 29);
            this.cmdCloseAccount.Name = "cmdCloseAccount";
            this.cmdCloseAccount.Size = new System.Drawing.Size(112, 23);
            this.cmdCloseAccount.TabIndex = 6;
            this.cmdCloseAccount.Text = "Close account";
            this.cmdCloseAccount.UseVisualStyleBackColor = true;
            this.cmdCloseAccount.Click += new System.EventHandler(this.cmdCloseAccount_Click);
            // 
            // cmdAllTransactions
            // 
            this.cmdAllTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAllTransactions.Location = new System.Drawing.Point(153, 87);
            this.cmdAllTransactions.Name = "cmdAllTransactions";
            this.cmdAllTransactions.Size = new System.Drawing.Size(112, 23);
            this.cmdAllTransactions.TabIndex = 8;
            this.cmdAllTransactions.Text = "All transactions";
            this.cmdAllTransactions.UseVisualStyleBackColor = true;
            this.cmdAllTransactions.Click += new System.EventHandler(this.cmdAllTransactions_Click);
            // 
            // cmdWithdrawal
            // 
            this.cmdWithdrawal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdWithdrawal.Location = new System.Drawing.Point(102, 158);
            this.cmdWithdrawal.Name = "cmdWithdrawal";
            this.cmdWithdrawal.Size = new System.Drawing.Size(112, 23);
            this.cmdWithdrawal.TabIndex = 9;
            this.cmdWithdrawal.Text = "Withdrawal";
            this.cmdWithdrawal.UseVisualStyleBackColor = true;
            this.cmdWithdrawal.Click += new System.EventHandler(this.cmdWithdrawal_Click);
            // 
            // cmdDeposit
            // 
            this.cmdDeposit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdDeposit.Location = new System.Drawing.Point(37, 132);
            this.cmdDeposit.Name = "cmdDeposit";
            this.cmdDeposit.Size = new System.Drawing.Size(112, 23);
            this.cmdDeposit.TabIndex = 10;
            this.cmdDeposit.Text = "Deposit";
            this.cmdDeposit.UseVisualStyleBackColor = true;
            this.cmdDeposit.Click += new System.EventHandler(this.cmdDeposit_Click);
            // 
            // gwCardsView
            // 
            this.gwCardsView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gwCardsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gwCardsView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gwCardsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gwCardsView.Location = new System.Drawing.Point(6, 19);
            this.gwCardsView.Name = "gwCardsView";
            this.gwCardsView.Size = new System.Drawing.Size(972, 167);
            this.gwCardsView.TabIndex = 18;
            // 
            // gbCarsView
            // 
            this.gbCarsView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gbCarsView.Controls.Add(this.gwCardsView);
            this.gbCarsView.Location = new System.Drawing.Point(1, 269);
            this.gbCarsView.Name = "gbCarsView";
            this.gbCarsView.Size = new System.Drawing.Size(984, 192);
            this.gbCarsView.TabIndex = 19;
            this.gbCarsView.TabStop = false;
            this.gbCarsView.Text = "CARDS:";
            // 
            // gbClientInfo
            // 
            this.gbClientInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbClientInfo.Controls.Add(this.gbCustContact);
            this.gbClientInfo.Controls.Add(this.groupBox1);
            this.gbClientInfo.Controls.Add(this.gbCustAddress);
            this.gbClientInfo.Controls.Add(this.gbCustInfo);
            this.gbClientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbClientInfo.Location = new System.Drawing.Point(12, 13);
            this.gbClientInfo.Name = "gbClientInfo";
            this.gbClientInfo.Size = new System.Drawing.Size(960, 250);
            this.gbClientInfo.TabIndex = 20;
            this.gbClientInfo.TabStop = false;
            this.gbClientInfo.Text = "CLIENT AND ACCOUNT INFO:";
            // 
            // gbCustContact
            // 
            this.gbCustContact.Controls.Add(this.lblEMailValue);
            this.gbCustContact.Controls.Add(this.lblPhoneValue);
            this.gbCustContact.Controls.Add(this.lblEMail);
            this.gbCustContact.Controls.Add(this.lblPhone);
            this.gbCustContact.Location = new System.Drawing.Point(372, 169);
            this.gbCustContact.Name = "gbCustContact";
            this.gbCustContact.Size = new System.Drawing.Size(280, 78);
            this.gbCustContact.TabIndex = 2;
            this.gbCustContact.TabStop = false;
            this.gbCustContact.Text = "CLIENTS CONTACT:";
            // 
            // lblEMailValue
            // 
            this.lblEMailValue.AutoSize = true;
            this.lblEMailValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEMailValue.Location = new System.Drawing.Point(124, 47);
            this.lblEMailValue.MinimumSize = new System.Drawing.Size(150, 25);
            this.lblEMailValue.Name = "lblEMailValue";
            this.lblEMailValue.Size = new System.Drawing.Size(150, 25);
            this.lblEMailValue.TabIndex = 13;
            this.lblEMailValue.Text = "____________________";
            // 
            // lblPhoneValue
            // 
            this.lblPhoneValue.AutoSize = true;
            this.lblPhoneValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPhoneValue.Location = new System.Drawing.Point(124, 22);
            this.lblPhoneValue.MinimumSize = new System.Drawing.Size(150, 25);
            this.lblPhoneValue.Name = "lblPhoneValue";
            this.lblPhoneValue.Size = new System.Drawing.Size(150, 25);
            this.lblPhoneValue.TabIndex = 12;
            this.lblPhoneValue.Text = "____________________";
            // 
            // lblEMail
            // 
            this.lblEMail.AutoSize = true;
            this.lblEMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEMail.Location = new System.Drawing.Point(14, 47);
            this.lblEMail.MinimumSize = new System.Drawing.Size(0, 25);
            this.lblEMail.Name = "lblEMail";
            this.lblEMail.Size = new System.Drawing.Size(35, 25);
            this.lblEMail.TabIndex = 12;
            this.lblEMail.Text = "Email:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPhone.Location = new System.Drawing.Point(14, 22);
            this.lblPhone.MinimumSize = new System.Drawing.Size(0, 25);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(79, 25);
            this.lblPhone.TabIndex = 12;
            this.lblPhone.Text = "Phone number:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdDeposit);
            this.groupBox1.Controls.Add(this.cmdWithdrawal);
            this.groupBox1.Controls.Add(this.cmdAllTransactions);
            this.groupBox1.Controls.Add(this.cmdNewTransaction);
            this.groupBox1.Controls.Add(this.cmdUpdate);
            this.groupBox1.Controls.Add(this.cmdCloseAccount);
            this.groupBox1.Location = new System.Drawing.Point(665, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 228);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // gbCustAddress
            // 
            this.gbCustAddress.Controls.Add(this.lblCountryValue);
            this.gbCustAddress.Controls.Add(this.lblCityValue);
            this.gbCustAddress.Controls.Add(this.lblPostcodeValue);
            this.gbCustAddress.Controls.Add(this.lblAddressValue);
            this.gbCustAddress.Controls.Add(this.lblCountry);
            this.gbCustAddress.Controls.Add(this.lblCity);
            this.gbCustAddress.Controls.Add(this.lblPostcode);
            this.gbCustAddress.Controls.Add(this.lblAddress);
            this.gbCustAddress.Location = new System.Drawing.Point(372, 19);
            this.gbCustAddress.Name = "gbCustAddress";
            this.gbCustAddress.Size = new System.Drawing.Size(281, 130);
            this.gbCustAddress.TabIndex = 1;
            this.gbCustAddress.TabStop = false;
            this.gbCustAddress.Text = "CLIENT ADDRESS:";
            // 
            // lblCountryValue
            // 
            this.lblCountryValue.AutoSize = true;
            this.lblCountryValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCountryValue.Location = new System.Drawing.Point(125, 103);
            this.lblCountryValue.MinimumSize = new System.Drawing.Size(150, 25);
            this.lblCountryValue.Name = "lblCountryValue";
            this.lblCountryValue.Size = new System.Drawing.Size(150, 25);
            this.lblCountryValue.TabIndex = 11;
            this.lblCountryValue.Text = "____________________";
            // 
            // lblCityValue
            // 
            this.lblCityValue.AutoSize = true;
            this.lblCityValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCityValue.Location = new System.Drawing.Point(125, 78);
            this.lblCityValue.MinimumSize = new System.Drawing.Size(150, 25);
            this.lblCityValue.Name = "lblCityValue";
            this.lblCityValue.Size = new System.Drawing.Size(150, 25);
            this.lblCityValue.TabIndex = 10;
            this.lblCityValue.Text = "____________________";
            // 
            // lblPostcodeValue
            // 
            this.lblPostcodeValue.AutoSize = true;
            this.lblPostcodeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPostcodeValue.Location = new System.Drawing.Point(125, 53);
            this.lblPostcodeValue.MinimumSize = new System.Drawing.Size(150, 25);
            this.lblPostcodeValue.Name = "lblPostcodeValue";
            this.lblPostcodeValue.Size = new System.Drawing.Size(150, 25);
            this.lblPostcodeValue.TabIndex = 9;
            this.lblPostcodeValue.Text = "____________________";
            this.lblPostcodeValue.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblAddressValue
            // 
            this.lblAddressValue.AutoSize = true;
            this.lblAddressValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAddressValue.Location = new System.Drawing.Point(125, 28);
            this.lblAddressValue.MinimumSize = new System.Drawing.Size(150, 25);
            this.lblAddressValue.Name = "lblAddressValue";
            this.lblAddressValue.Size = new System.Drawing.Size(150, 25);
            this.lblAddressValue.TabIndex = 8;
            this.lblAddressValue.Text = "____________________";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCountry.Location = new System.Drawing.Point(15, 103);
            this.lblCountry.MinimumSize = new System.Drawing.Size(0, 25);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(46, 25);
            this.lblCountry.TabIndex = 4;
            this.lblCountry.Text = "Country:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCity.Location = new System.Drawing.Point(15, 78);
            this.lblCity.MinimumSize = new System.Drawing.Size(0, 25);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(38, 25);
            this.lblCity.TabIndex = 3;
            this.lblCity.Text = "CityID:";
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPostcode.Location = new System.Drawing.Point(15, 53);
            this.lblPostcode.MinimumSize = new System.Drawing.Size(0, 25);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(55, 25);
            this.lblPostcode.TabIndex = 2;
            this.lblPostcode.Text = "Postcode:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAddress.Location = new System.Drawing.Point(15, 28);
            this.lblAddress.MinimumSize = new System.Drawing.Size(0, 25);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 25);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address:";
            // 
            // gbCustInfo
            // 
            this.gbCustInfo.Controls.Add(this.lblSuffixValue);
            this.gbCustInfo.Controls.Add(this.lblSuffix);
            this.gbCustInfo.Controls.Add(this.lblIDCardNumValue);
            this.gbCustInfo.Controls.Add(this.lblBDayValue);
            this.gbCustInfo.Controls.Add(this.lblLNameValue);
            this.gbCustInfo.Controls.Add(this.lblMNameValue);
            this.gbCustInfo.Controls.Add(this.lblFNameValue);
            this.gbCustInfo.Controls.Add(this.lblTitleValue);
            this.gbCustInfo.Controls.Add(this.lblCustIdValue);
            this.gbCustInfo.Controls.Add(this.lblIDCardNum);
            this.gbCustInfo.Controls.Add(this.lblBDay);
            this.gbCustInfo.Controls.Add(this.lblLName);
            this.gbCustInfo.Controls.Add(this.lblMName);
            this.gbCustInfo.Controls.Add(this.lblFName);
            this.gbCustInfo.Controls.Add(this.lblTitle);
            this.gbCustInfo.Controls.Add(this.lblCustId);
            this.gbCustInfo.Location = new System.Drawing.Point(7, 20);
            this.gbCustInfo.Name = "gbCustInfo";
            this.gbCustInfo.Size = new System.Drawing.Size(359, 227);
            this.gbCustInfo.TabIndex = 0;
            this.gbCustInfo.TabStop = false;
            this.gbCustInfo.Text = "CLIENTS INFO:";
            // 
            // lblIDCardNumValue
            // 
            this.lblIDCardNumValue.AutoSize = true;
            this.lblIDCardNumValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIDCardNumValue.Location = new System.Drawing.Point(203, 198);
            this.lblIDCardNumValue.MinimumSize = new System.Drawing.Size(150, 25);
            this.lblIDCardNumValue.Name = "lblIDCardNumValue";
            this.lblIDCardNumValue.Size = new System.Drawing.Size(150, 25);
            this.lblIDCardNumValue.TabIndex = 13;
            this.lblIDCardNumValue.Text = "____________________";
            // 
            // lblBDayValue
            // 
            this.lblBDayValue.AutoSize = true;
            this.lblBDayValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBDayValue.Location = new System.Drawing.Point(203, 173);
            this.lblBDayValue.MinimumSize = new System.Drawing.Size(150, 25);
            this.lblBDayValue.Name = "lblBDayValue";
            this.lblBDayValue.Size = new System.Drawing.Size(150, 25);
            this.lblBDayValue.TabIndex = 12;
            this.lblBDayValue.Text = "____________________";
            // 
            // lblLNameValue
            // 
            this.lblLNameValue.AutoSize = true;
            this.lblLNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLNameValue.Location = new System.Drawing.Point(203, 123);
            this.lblLNameValue.MinimumSize = new System.Drawing.Size(150, 25);
            this.lblLNameValue.Name = "lblLNameValue";
            this.lblLNameValue.Size = new System.Drawing.Size(150, 25);
            this.lblLNameValue.TabIndex = 11;
            this.lblLNameValue.Text = "____________________";
            // 
            // lblMNameValue
            // 
            this.lblMNameValue.AutoSize = true;
            this.lblMNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMNameValue.Location = new System.Drawing.Point(203, 98);
            this.lblMNameValue.MinimumSize = new System.Drawing.Size(150, 25);
            this.lblMNameValue.Name = "lblMNameValue";
            this.lblMNameValue.Size = new System.Drawing.Size(150, 25);
            this.lblMNameValue.TabIndex = 10;
            this.lblMNameValue.Text = "____________________";
            // 
            // lblFNameValue
            // 
            this.lblFNameValue.AutoSize = true;
            this.lblFNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFNameValue.Location = new System.Drawing.Point(203, 73);
            this.lblFNameValue.MinimumSize = new System.Drawing.Size(150, 25);
            this.lblFNameValue.Name = "lblFNameValue";
            this.lblFNameValue.Size = new System.Drawing.Size(150, 25);
            this.lblFNameValue.TabIndex = 9;
            this.lblFNameValue.Text = "____________________";
            // 
            // lblTitleValue
            // 
            this.lblTitleValue.AutoSize = true;
            this.lblTitleValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitleValue.Location = new System.Drawing.Point(203, 48);
            this.lblTitleValue.MinimumSize = new System.Drawing.Size(150, 25);
            this.lblTitleValue.Name = "lblTitleValue";
            this.lblTitleValue.Size = new System.Drawing.Size(150, 25);
            this.lblTitleValue.TabIndex = 8;
            this.lblTitleValue.Text = "____________________";
            // 
            // lblCustIdValue
            // 
            this.lblCustIdValue.AutoSize = true;
            this.lblCustIdValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCustIdValue.Location = new System.Drawing.Point(203, 23);
            this.lblCustIdValue.MinimumSize = new System.Drawing.Size(150, 25);
            this.lblCustIdValue.Name = "lblCustIdValue";
            this.lblCustIdValue.Size = new System.Drawing.Size(150, 25);
            this.lblCustIdValue.TabIndex = 7;
            this.lblCustIdValue.Text = "____________________";
            // 
            // lblIDCardNum
            // 
            this.lblIDCardNum.AutoSize = true;
            this.lblIDCardNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIDCardNum.Location = new System.Drawing.Point(10, 198);
            this.lblIDCardNum.MinimumSize = new System.Drawing.Size(0, 25);
            this.lblIDCardNum.Name = "lblIDCardNum";
            this.lblIDCardNum.Size = new System.Drawing.Size(81, 25);
            this.lblIDCardNum.TabIndex = 6;
            this.lblIDCardNum.Text = "IDCard number:";
            // 
            // lblBDay
            // 
            this.lblBDay.AutoSize = true;
            this.lblBDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBDay.Location = new System.Drawing.Point(10, 173);
            this.lblBDay.MinimumSize = new System.Drawing.Size(0, 25);
            this.lblBDay.Name = "lblBDay";
            this.lblBDay.Size = new System.Drawing.Size(48, 25);
            this.lblBDay.TabIndex = 5;
            this.lblBDay.Text = "Birthday:";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLName.Location = new System.Drawing.Point(10, 123);
            this.lblLName.MinimumSize = new System.Drawing.Size(0, 25);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(56, 25);
            this.lblLName.TabIndex = 4;
            this.lblLName.Text = "Lastname:";
            // 
            // lblMName
            // 
            this.lblMName.AutoSize = true;
            this.lblMName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMName.Location = new System.Drawing.Point(10, 98);
            this.lblMName.MinimumSize = new System.Drawing.Size(0, 25);
            this.lblMName.Name = "lblMName";
            this.lblMName.Size = new System.Drawing.Size(67, 25);
            this.lblMName.TabIndex = 3;
            this.lblMName.Text = "Middlename:";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFName.Location = new System.Drawing.Point(10, 73);
            this.lblFName.MinimumSize = new System.Drawing.Size(0, 25);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(55, 25);
            this.lblFName.TabIndex = 2;
            this.lblFName.Text = "Firstname:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.Location = new System.Drawing.Point(10, 48);
            this.lblTitle.MinimumSize = new System.Drawing.Size(0, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title:";
            // 
            // lblCustId
            // 
            this.lblCustId.AutoSize = true;
            this.lblCustId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCustId.Location = new System.Drawing.Point(10, 23);
            this.lblCustId.MinimumSize = new System.Drawing.Size(0, 25);
            this.lblCustId.Name = "lblCustId";
            this.lblCustId.Size = new System.Drawing.Size(73, 25);
            this.lblCustId.TabIndex = 0;
            this.lblCustId.Text = "Customers ID:";
            // 
            // lblSuffixValue
            // 
            this.lblSuffixValue.AutoSize = true;
            this.lblSuffixValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSuffixValue.Location = new System.Drawing.Point(203, 148);
            this.lblSuffixValue.MinimumSize = new System.Drawing.Size(150, 25);
            this.lblSuffixValue.Name = "lblSuffixValue";
            this.lblSuffixValue.Size = new System.Drawing.Size(150, 25);
            this.lblSuffixValue.TabIndex = 15;
            this.lblSuffixValue.Text = "____________________";
            // 
            // lblSuffix
            // 
            this.lblSuffix.AutoSize = true;
            this.lblSuffix.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSuffix.Location = new System.Drawing.Point(10, 148);
            this.lblSuffix.MinimumSize = new System.Drawing.Size(0, 25);
            this.lblSuffix.Name = "lblSuffix";
            this.lblSuffix.Size = new System.Drawing.Size(33, 25);
            this.lblSuffix.TabIndex = 14;
            this.lblSuffix.Text = "Suffix";
            // 
            // frmClientManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.gbCarsView);
            this.Controls.Add(this.gbClientInfo);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "frmClientManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmClientManagement";
            ((System.ComponentModel.ISupportInitialize)(this.gwCardsView)).EndInit();
            this.gbCarsView.ResumeLayout(false);
            this.gbClientInfo.ResumeLayout(false);
            this.gbCustContact.ResumeLayout(false);
            this.gbCustContact.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gbCustAddress.ResumeLayout(false);
            this.gbCustAddress.PerformLayout();
            this.gbCustInfo.ResumeLayout(false);
            this.gbCustInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.Button cmdNewTransaction;
        private System.Windows.Forms.Button cmdCloseAccount;
        private System.Windows.Forms.Button cmdAllTransactions;
        private System.Windows.Forms.Button cmdWithdrawal;
        private System.Windows.Forms.Button cmdDeposit;
        private System.Windows.Forms.DataGridView gwCardsView;
        private System.Windows.Forms.GroupBox gbCarsView;
        private System.Windows.Forms.GroupBox gbClientInfo;
        private System.Windows.Forms.GroupBox gbCustContact;
        private System.Windows.Forms.GroupBox gbCustAddress;
        private System.Windows.Forms.GroupBox gbCustInfo;
        private System.Windows.Forms.Label lblIDCardNum;
        private System.Windows.Forms.Label lblBDay;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblMName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCustId;
        private System.Windows.Forms.Label lblIDCardNumValue;
        private System.Windows.Forms.Label lblBDayValue;
        private System.Windows.Forms.Label lblLNameValue;
        private System.Windows.Forms.Label lblMNameValue;
        private System.Windows.Forms.Label lblFNameValue;
        private System.Windows.Forms.Label lblTitleValue;
        private System.Windows.Forms.Label lblCustIdValue;
        private System.Windows.Forms.Label lblEMailValue;
        private System.Windows.Forms.Label lblPhoneValue;
        private System.Windows.Forms.Label lblEMail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCountryValue;
        private System.Windows.Forms.Label lblCityValue;
        private System.Windows.Forms.Label lblPostcodeValue;
        private System.Windows.Forms.Label lblAddressValue;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblSuffixValue;
        private System.Windows.Forms.Label lblSuffix;
    }
}