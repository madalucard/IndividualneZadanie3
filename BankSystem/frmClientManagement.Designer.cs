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
            this.cmdCloseOpenCustomer = new System.Windows.Forms.Button();
            this.cmdAllTransactions = new System.Windows.Forms.Button();
            this.cmdWithdrawal = new System.Windows.Forms.Button();
            this.cmdDeposit = new System.Windows.Forms.Button();
            this.gwCardsView = new System.Windows.Forms.DataGridView();
            this.gbCardsView = new System.Windows.Forms.GroupBox();
            this.gbClientInfo = new System.Windows.Forms.GroupBox();
            this.gbAccStatus = new System.Windows.Forms.GroupBox();
            this.lblCustStatusValue = new System.Windows.Forms.Label();
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
            this.lblSuffixValue = new System.Windows.Forms.Label();
            this.lblSuffix = new System.Windows.Forms.Label();
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
            this.gbAccInfo = new System.Windows.Forms.GroupBox();
            this.cmdCloseOpenAcc = new System.Windows.Forms.Button();
            this.lblAmountValue = new System.Windows.Forms.Label();
            this.lblOverdraftValue = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblOverdraft = new System.Windows.Forms.Label();
            this.lblIbanValue = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblAccStatusValue = new System.Windows.Forms.Label();
            this.lblAccNameValue = new System.Windows.Forms.Label();
            this.lblIDAcc = new System.Windows.Forms.Label();
            this.lblIDAccValue = new System.Windows.Forms.Label();
            this.lblAccName = new System.Windows.Forms.Label();
            this.lblIban = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gwCardsView)).BeginInit();
            this.gbCardsView.SuspendLayout();
            this.gbClientInfo.SuspendLayout();
            this.gbAccStatus.SuspendLayout();
            this.gbCustContact.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbCustAddress.SuspendLayout();
            this.gbCustInfo.SuspendLayout();
            this.gbAccInfo.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdUpdate.Location = new System.Drawing.Point(146, 29);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(143, 23);
            this.cmdUpdate.TabIndex = 4;
            this.cmdUpdate.Text = "Update info";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // cmdNewTransaction
            // 
            this.cmdNewTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdNewTransaction.Location = new System.Drawing.Point(6, 87);
            this.cmdNewTransaction.Name = "cmdNewTransaction";
            this.cmdNewTransaction.Size = new System.Drawing.Size(143, 23);
            this.cmdNewTransaction.TabIndex = 5;
            this.cmdNewTransaction.Text = "New transaction";
            this.cmdNewTransaction.UseVisualStyleBackColor = true;
            this.cmdNewTransaction.Click += new System.EventHandler(this.cmdNewTransaction_Click);
            // 
            // cmdCloseOpenCustomer
            // 
            this.cmdCloseOpenCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCloseOpenCustomer.Location = new System.Drawing.Point(6, 29);
            this.cmdCloseOpenCustomer.Name = "cmdCloseOpenCustomer";
            this.cmdCloseOpenCustomer.Size = new System.Drawing.Size(143, 23);
            this.cmdCloseOpenCustomer.TabIndex = 6;
            this.cmdCloseOpenCustomer.Text = "Close customer";
            this.cmdCloseOpenCustomer.UseVisualStyleBackColor = true;
            this.cmdCloseOpenCustomer.Click += new System.EventHandler(this.cmdCloseOpenCust_Click);
            // 
            // cmdAllTransactions
            // 
            this.cmdAllTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAllTransactions.Location = new System.Drawing.Point(146, 58);
            this.cmdAllTransactions.Name = "cmdAllTransactions";
            this.cmdAllTransactions.Size = new System.Drawing.Size(143, 23);
            this.cmdAllTransactions.TabIndex = 8;
            this.cmdAllTransactions.Text = "All transactions";
            this.cmdAllTransactions.UseVisualStyleBackColor = true;
            this.cmdAllTransactions.Click += new System.EventHandler(this.cmdAllTransactions_Click);
            // 
            // cmdWithdrawal
            // 
            this.cmdWithdrawal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdWithdrawal.Location = new System.Drawing.Point(146, 87);
            this.cmdWithdrawal.Name = "cmdWithdrawal";
            this.cmdWithdrawal.Size = new System.Drawing.Size(143, 23);
            this.cmdWithdrawal.TabIndex = 9;
            this.cmdWithdrawal.Text = "Withdrawal";
            this.cmdWithdrawal.UseVisualStyleBackColor = true;
            this.cmdWithdrawal.Click += new System.EventHandler(this.cmdWithdrawal_Click);
            // 
            // cmdDeposit
            // 
            this.cmdDeposit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdDeposit.Location = new System.Drawing.Point(6, 58);
            this.cmdDeposit.Name = "cmdDeposit";
            this.cmdDeposit.Size = new System.Drawing.Size(143, 23);
            this.cmdDeposit.TabIndex = 10;
            this.cmdDeposit.Text = "Deposit";
            this.cmdDeposit.UseVisualStyleBackColor = true;
            this.cmdDeposit.Click += new System.EventHandler(this.cmdDeposit_Click);
            // 
            // gwCardsView
            // 
            this.gwCardsView.AllowUserToOrderColumns = true;
            this.gwCardsView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gwCardsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gwCardsView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gwCardsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gwCardsView.Location = new System.Drawing.Point(6, 19);
            this.gwCardsView.Name = "gwCardsView";
            this.gwCardsView.Size = new System.Drawing.Size(972, 137);
            this.gwCardsView.TabIndex = 18;
            // 
            // gbCardsView
            // 
            this.gbCardsView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gbCardsView.Controls.Add(this.gwCardsView);
            this.gbCardsView.Location = new System.Drawing.Point(1, 399);
            this.gbCardsView.Name = "gbCardsView";
            this.gbCardsView.Size = new System.Drawing.Size(984, 162);
            this.gbCardsView.TabIndex = 19;
            this.gbCardsView.TabStop = false;
            this.gbCardsView.Text = "CARDS:";
            // 
            // gbClientInfo
            // 
            this.gbClientInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbClientInfo.Controls.Add(this.gbAccStatus);
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
            // gbAccStatus
            // 
            this.gbAccStatus.Controls.Add(this.lblCustStatusValue);
            this.gbAccStatus.Location = new System.Drawing.Point(665, 22);
            this.gbAccStatus.Name = "gbAccStatus";
            this.gbAccStatus.Size = new System.Drawing.Size(289, 100);
            this.gbAccStatus.TabIndex = 20;
            this.gbAccStatus.TabStop = false;
            this.gbAccStatus.Text = "CUSTOMER STATUS:";
            // 
            // lblCustStatusValue
            // 
            this.lblCustStatusValue.AutoSize = true;
            this.lblCustStatusValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCustStatusValue.Location = new System.Drawing.Point(6, 19);
            this.lblCustStatusValue.MinimumSize = new System.Drawing.Size(275, 75);
            this.lblCustStatusValue.Name = "lblCustStatusValue";
            this.lblCustStatusValue.Size = new System.Drawing.Size(275, 75);
            this.lblCustStatusValue.TabIndex = 0;
            this.lblCustStatusValue.Text = "ACTIVE";
            this.lblCustStatusValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblEMailValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblPhoneValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblEMail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdDeposit);
            this.groupBox1.Controls.Add(this.cmdWithdrawal);
            this.groupBox1.Controls.Add(this.cmdAllTransactions);
            this.groupBox1.Controls.Add(this.cmdNewTransaction);
            this.groupBox1.Controls.Add(this.cmdUpdate);
            this.groupBox1.Controls.Add(this.cmdCloseOpenCustomer);
            this.groupBox1.Location = new System.Drawing.Point(665, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 125);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account functions:";
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
            this.lblCountryValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblCityValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblPostcodeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblAddressValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblCountry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblPostcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblSuffixValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblSuffix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblIDCardNumValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblBDayValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblLNameValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblMNameValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblFNameValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblTitleValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblCustIdValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblIDCardNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblBDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblLName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblMName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblFName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblCustId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbAccInfo
            // 
            this.gbAccInfo.Controls.Add(this.cmdCloseOpenAcc);
            this.gbAccInfo.Controls.Add(this.lblAmountValue);
            this.gbAccInfo.Controls.Add(this.lblOverdraftValue);
            this.gbAccInfo.Controls.Add(this.lblAmount);
            this.gbAccInfo.Controls.Add(this.lblOverdraft);
            this.gbAccInfo.Controls.Add(this.lblIbanValue);
            this.gbAccInfo.Controls.Add(this.groupBox3);
            this.gbAccInfo.Controls.Add(this.lblAccNameValue);
            this.gbAccInfo.Controls.Add(this.lblIDAcc);
            this.gbAccInfo.Controls.Add(this.lblIDAccValue);
            this.gbAccInfo.Controls.Add(this.lblAccName);
            this.gbAccInfo.Controls.Add(this.lblIban);
            this.gbAccInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.gbAccInfo.Location = new System.Drawing.Point(12, 267);
            this.gbAccInfo.Name = "gbAccInfo";
            this.gbAccInfo.Size = new System.Drawing.Size(954, 126);
            this.gbAccInfo.TabIndex = 21;
            this.gbAccInfo.TabStop = false;
            this.gbAccInfo.Text = "ACCOUNT INFO:";
            // 
            // cmdCloseOpenAcc
            // 
            this.cmdCloseOpenAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCloseOpenAcc.Location = new System.Drawing.Point(389, 88);
            this.cmdCloseOpenAcc.Name = "cmdCloseOpenAcc";
            this.cmdCloseOpenAcc.Size = new System.Drawing.Size(257, 23);
            this.cmdCloseOpenAcc.TabIndex = 27;
            this.cmdCloseOpenAcc.Text = "Close account";
            this.cmdCloseOpenAcc.UseVisualStyleBackColor = true;
            this.cmdCloseOpenAcc.Click += new System.EventHandler(this.cmdCloseOpenAccount_Click);
            // 
            // lblAmountValue
            // 
            this.lblAmountValue.AutoSize = true;
            this.lblAmountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAmountValue.Location = new System.Drawing.Point(497, 60);
            this.lblAmountValue.MinimumSize = new System.Drawing.Size(150, 25);
            this.lblAmountValue.Name = "lblAmountValue";
            this.lblAmountValue.Size = new System.Drawing.Size(150, 25);
            this.lblAmountValue.TabIndex = 26;
            this.lblAmountValue.Text = "____________________";
            this.lblAmountValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOverdraftValue
            // 
            this.lblOverdraftValue.AutoSize = true;
            this.lblOverdraftValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOverdraftValue.Location = new System.Drawing.Point(497, 35);
            this.lblOverdraftValue.MinimumSize = new System.Drawing.Size(150, 25);
            this.lblOverdraftValue.Name = "lblOverdraftValue";
            this.lblOverdraftValue.Size = new System.Drawing.Size(150, 25);
            this.lblOverdraftValue.TabIndex = 25;
            this.lblOverdraftValue.Text = "____________________";
            this.lblOverdraftValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAmount.Location = new System.Drawing.Point(386, 60);
            this.lblAmount.MinimumSize = new System.Drawing.Size(0, 25);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(46, 25);
            this.lblAmount.TabIndex = 23;
            this.lblAmount.Text = "Amount:";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOverdraft
            // 
            this.lblOverdraft.AutoSize = true;
            this.lblOverdraft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOverdraft.Location = new System.Drawing.Point(386, 35);
            this.lblOverdraft.MinimumSize = new System.Drawing.Size(0, 25);
            this.lblOverdraft.Name = "lblOverdraft";
            this.lblOverdraft.Size = new System.Drawing.Size(54, 25);
            this.lblOverdraft.TabIndex = 22;
            this.lblOverdraft.Text = "Overdraft:";
            this.lblOverdraft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIbanValue
            // 
            this.lblIbanValue.AutoSize = true;
            this.lblIbanValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIbanValue.Location = new System.Drawing.Point(210, 85);
            this.lblIbanValue.MinimumSize = new System.Drawing.Size(150, 25);
            this.lblIbanValue.Name = "lblIbanValue";
            this.lblIbanValue.Size = new System.Drawing.Size(150, 25);
            this.lblIbanValue.TabIndex = 21;
            this.lblIbanValue.Text = "____________________";
            this.lblIbanValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblAccStatusValue);
            this.groupBox3.Location = new System.Drawing.Point(659, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(289, 100);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ACCOUNT STATUS:";
            // 
            // lblAccStatusValue
            // 
            this.lblAccStatusValue.AutoSize = true;
            this.lblAccStatusValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAccStatusValue.Location = new System.Drawing.Point(8, 16);
            this.lblAccStatusValue.MinimumSize = new System.Drawing.Size(275, 75);
            this.lblAccStatusValue.Name = "lblAccStatusValue";
            this.lblAccStatusValue.Size = new System.Drawing.Size(275, 75);
            this.lblAccStatusValue.TabIndex = 0;
            this.lblAccStatusValue.Text = "ACTIVE";
            this.lblAccStatusValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAccNameValue
            // 
            this.lblAccNameValue.AutoSize = true;
            this.lblAccNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAccNameValue.Location = new System.Drawing.Point(210, 60);
            this.lblAccNameValue.MinimumSize = new System.Drawing.Size(150, 25);
            this.lblAccNameValue.Name = "lblAccNameValue";
            this.lblAccNameValue.Size = new System.Drawing.Size(150, 25);
            this.lblAccNameValue.TabIndex = 20;
            this.lblAccNameValue.Text = "____________________";
            this.lblAccNameValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIDAcc
            // 
            this.lblIDAcc.AutoSize = true;
            this.lblIDAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIDAcc.Location = new System.Drawing.Point(17, 35);
            this.lblIDAcc.MinimumSize = new System.Drawing.Size(0, 25);
            this.lblIDAcc.Name = "lblIDAcc";
            this.lblIDAcc.Size = new System.Drawing.Size(61, 25);
            this.lblIDAcc.TabIndex = 16;
            this.lblIDAcc.Text = "Account ID";
            this.lblIDAcc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIDAccValue
            // 
            this.lblIDAccValue.AutoSize = true;
            this.lblIDAccValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIDAccValue.Location = new System.Drawing.Point(210, 35);
            this.lblIDAccValue.MinimumSize = new System.Drawing.Size(150, 25);
            this.lblIDAccValue.Name = "lblIDAccValue";
            this.lblIDAccValue.Size = new System.Drawing.Size(150, 25);
            this.lblIDAccValue.TabIndex = 19;
            this.lblIDAccValue.Text = "____________________";
            this.lblIDAccValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAccName
            // 
            this.lblAccName.AutoSize = true;
            this.lblAccName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAccName.Location = new System.Drawing.Point(17, 60);
            this.lblAccName.MinimumSize = new System.Drawing.Size(0, 25);
            this.lblAccName.Name = "lblAccName";
            this.lblAccName.Size = new System.Drawing.Size(79, 25);
            this.lblAccName.TabIndex = 17;
            this.lblAccName.Text = "Account name:";
            this.lblAccName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIban
            // 
            this.lblIban.AutoSize = true;
            this.lblIban.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIban.Location = new System.Drawing.Point(17, 85);
            this.lblIban.MinimumSize = new System.Drawing.Size(0, 25);
            this.lblIban.Name = "lblIban";
            this.lblIban.Size = new System.Drawing.Size(31, 25);
            this.lblIban.TabIndex = 18;
            this.lblIban.Text = "Iban:";
            this.lblIban.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmClientManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.gbAccInfo);
            this.Controls.Add(this.gbCardsView);
            this.Controls.Add(this.gbClientInfo);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "frmClientManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmClientManagement";
            ((System.ComponentModel.ISupportInitialize)(this.gwCardsView)).EndInit();
            this.gbCardsView.ResumeLayout(false);
            this.gbClientInfo.ResumeLayout(false);
            this.gbAccStatus.ResumeLayout(false);
            this.gbAccStatus.PerformLayout();
            this.gbCustContact.ResumeLayout(false);
            this.gbCustContact.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gbCustAddress.ResumeLayout(false);
            this.gbCustAddress.PerformLayout();
            this.gbCustInfo.ResumeLayout(false);
            this.gbCustInfo.PerformLayout();
            this.gbAccInfo.ResumeLayout(false);
            this.gbAccInfo.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.Button cmdNewTransaction;
        private System.Windows.Forms.Button cmdCloseOpenCustomer;
        private System.Windows.Forms.Button cmdAllTransactions;
        private System.Windows.Forms.Button cmdWithdrawal;
        private System.Windows.Forms.Button cmdDeposit;
        private System.Windows.Forms.DataGridView gwCardsView;
        private System.Windows.Forms.GroupBox gbCardsView;
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
        private System.Windows.Forms.GroupBox gbAccStatus;
        private System.Windows.Forms.Label lblCustStatusValue;
        private System.Windows.Forms.GroupBox gbAccInfo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblAccStatusValue;
        private System.Windows.Forms.Label lblAmountValue;
        private System.Windows.Forms.Label lblOverdraftValue;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblOverdraft;
        private System.Windows.Forms.Label lblIbanValue;
        private System.Windows.Forms.Label lblAccNameValue;
        private System.Windows.Forms.Label lblIDAcc;
        private System.Windows.Forms.Label lblIDAccValue;
        private System.Windows.Forms.Label lblAccName;
        private System.Windows.Forms.Label lblIban;
        private System.Windows.Forms.Button cmdCloseOpenAcc;
    }
}