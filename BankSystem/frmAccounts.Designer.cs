namespace BankSystem
{
    partial class frmAccounts
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
            this.cmdManageAccount = new System.Windows.Forms.Button();
            this.lblFiltCustName = new System.Windows.Forms.GroupBox();
            this.btnFiltCustName = new System.Windows.Forms.Button();
            this.btnFiltCustID = new System.Windows.Forms.Button();
            this.btnFiltAccName = new System.Windows.Forms.Button();
            this.btnFiltAccID = new System.Windows.Forms.Button();
            this.txtBxLName = new System.Windows.Forms.TextBox();
            this.txtBxCustFName = new System.Windows.Forms.TextBox();
            this.txtBxCustID = new System.Windows.Forms.TextBox();
            this.txtBxAccName = new System.Windows.Forms.TextBox();
            this.txtBxAccID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFiltCustId = new System.Windows.Forms.Label();
            this.lblFiltAccName = new System.Windows.Forms.Label();
            this.lblFiltAccID = new System.Windows.Forms.Label();
            this.gwClients = new System.Windows.Forms.DataGridView();
            this.lblFiltCustName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gwClients)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdManageAccount
            // 
            this.cmdManageAccount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdManageAccount.Location = new System.Drawing.Point(242, 312);
            this.cmdManageAccount.Name = "cmdManageAccount";
            this.cmdManageAccount.Size = new System.Drawing.Size(100, 37);
            this.cmdManageAccount.TabIndex = 10;
            this.cmdManageAccount.Text = "Manage account";
            this.cmdManageAccount.UseVisualStyleBackColor = true;
            this.cmdManageAccount.Click += new System.EventHandler(this.cmdManageAccount_Click);
            // 
            // lblFiltCustName
            // 
            this.lblFiltCustName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFiltCustName.Controls.Add(this.btnFiltCustName);
            this.lblFiltCustName.Controls.Add(this.btnFiltCustID);
            this.lblFiltCustName.Controls.Add(this.btnFiltAccName);
            this.lblFiltCustName.Controls.Add(this.btnFiltAccID);
            this.lblFiltCustName.Controls.Add(this.txtBxLName);
            this.lblFiltCustName.Controls.Add(this.txtBxCustFName);
            this.lblFiltCustName.Controls.Add(this.txtBxCustID);
            this.lblFiltCustName.Controls.Add(this.txtBxAccName);
            this.lblFiltCustName.Controls.Add(this.txtBxAccID);
            this.lblFiltCustName.Controls.Add(this.label5);
            this.lblFiltCustName.Controls.Add(this.lblFiltCustId);
            this.lblFiltCustName.Controls.Add(this.lblFiltAccName);
            this.lblFiltCustName.Controls.Add(this.lblFiltAccID);
            this.lblFiltCustName.Location = new System.Drawing.Point(13, 13);
            this.lblFiltCustName.Name = "lblFiltCustName";
            this.lblFiltCustName.Size = new System.Drawing.Size(559, 130);
            this.lblFiltCustName.TabIndex = 11;
            this.lblFiltCustName.TabStop = false;
            this.lblFiltCustName.Text = "FILTER:";
            // 
            // btnFiltCustName
            // 
            this.btnFiltCustName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltCustName.Location = new System.Drawing.Point(466, 85);
            this.btnFiltCustName.Name = "btnFiltCustName";
            this.btnFiltCustName.Size = new System.Drawing.Size(75, 23);
            this.btnFiltCustName.TabIndex = 12;
            this.btnFiltCustName.Text = "CONFIRM!";
            this.btnFiltCustName.UseVisualStyleBackColor = true;
            this.btnFiltCustName.Click += new System.EventHandler(this.btnFiltCustName_Click);
            // 
            // btnFiltCustID
            // 
            this.btnFiltCustID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltCustID.Location = new System.Drawing.Point(466, 60);
            this.btnFiltCustID.Name = "btnFiltCustID";
            this.btnFiltCustID.Size = new System.Drawing.Size(75, 23);
            this.btnFiltCustID.TabIndex = 11;
            this.btnFiltCustID.Text = "CONFIRM!";
            this.btnFiltCustID.UseVisualStyleBackColor = true;
            this.btnFiltCustID.Click += new System.EventHandler(this.btnFiltCustID_Click);
            // 
            // btnFiltAccName
            // 
            this.btnFiltAccName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltAccName.Location = new System.Drawing.Point(466, 35);
            this.btnFiltAccName.Name = "btnFiltAccName";
            this.btnFiltAccName.Size = new System.Drawing.Size(75, 23);
            this.btnFiltAccName.TabIndex = 10;
            this.btnFiltAccName.Text = "CONFIRM!";
            this.btnFiltAccName.UseVisualStyleBackColor = true;
            this.btnFiltAccName.Click += new System.EventHandler(this.btnFiltAccName_Click);
            // 
            // btnFiltAccID
            // 
            this.btnFiltAccID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltAccID.Location = new System.Drawing.Point(466, 10);
            this.btnFiltAccID.Name = "btnFiltAccID";
            this.btnFiltAccID.Size = new System.Drawing.Size(75, 23);
            this.btnFiltAccID.TabIndex = 9;
            this.btnFiltAccID.Text = "CONFIRM!";
            this.btnFiltAccID.UseVisualStyleBackColor = true;
            this.btnFiltAccID.Click += new System.EventHandler(this.btnFiltAccID_Click);
            // 
            // txtBxLName
            // 
            this.txtBxLName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBxLName.ForeColor = System.Drawing.Color.LightGray;
            this.txtBxLName.Location = new System.Drawing.Point(290, 87);
            this.txtBxLName.Name = "txtBxLName";
            this.txtBxLName.Size = new System.Drawing.Size(100, 20);
            this.txtBxLName.TabIndex = 8;
            this.txtBxLName.Text = "LASTNAME";
            this.txtBxLName.Enter += new System.EventHandler(this.txtBxLName_Enter);
            this.txtBxLName.Leave += new System.EventHandler(this.txtBxLName_Leave);
            // 
            // txtBxCustFName
            // 
            this.txtBxCustFName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBxCustFName.ForeColor = System.Drawing.Color.LightGray;
            this.txtBxCustFName.Location = new System.Drawing.Point(184, 87);
            this.txtBxCustFName.Name = "txtBxCustFName";
            this.txtBxCustFName.Size = new System.Drawing.Size(100, 20);
            this.txtBxCustFName.TabIndex = 7;
            this.txtBxCustFName.Text = "FIRSTNAME";
            this.txtBxCustFName.Enter += new System.EventHandler(this.txtBxCustFName_Enter);
            this.txtBxCustFName.Leave += new System.EventHandler(this.txtBxCustFName_Leave);
            // 
            // txtBxCustID
            // 
            this.txtBxCustID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBxCustID.ForeColor = System.Drawing.Color.LightGray;
            this.txtBxCustID.Location = new System.Drawing.Point(184, 62);
            this.txtBxCustID.Name = "txtBxCustID";
            this.txtBxCustID.Size = new System.Drawing.Size(206, 20);
            this.txtBxCustID.TabIndex = 6;
            this.txtBxCustID.Text = "ID";
            this.txtBxCustID.Enter += new System.EventHandler(this.txtBxCustID_Enter);
            this.txtBxCustID.Leave += new System.EventHandler(this.txtBxCustID_Leave);
            // 
            // txtBxAccName
            // 
            this.txtBxAccName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBxAccName.ForeColor = System.Drawing.Color.LightGray;
            this.txtBxAccName.Location = new System.Drawing.Point(184, 37);
            this.txtBxAccName.Name = "txtBxAccName";
            this.txtBxAccName.Size = new System.Drawing.Size(206, 20);
            this.txtBxAccName.TabIndex = 5;
            this.txtBxAccName.Text = "NAME";
            this.txtBxAccName.Enter += new System.EventHandler(this.txtBxAccName_Enter);
            this.txtBxAccName.Leave += new System.EventHandler(this.txtBxAccName_Leave);
            // 
            // txtBxAccID
            // 
            this.txtBxAccID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBxAccID.ForeColor = System.Drawing.Color.LightGray;
            this.txtBxAccID.Location = new System.Drawing.Point(184, 12);
            this.txtBxAccID.Name = "txtBxAccID";
            this.txtBxAccID.Size = new System.Drawing.Size(206, 20);
            this.txtBxAccID.TabIndex = 4;
            this.txtBxAccID.Text = "ID";
            this.txtBxAccID.Enter += new System.EventHandler(this.txtBxAccID_Enter);
            this.txtBxAccID.Leave += new System.EventHandler(this.txtBxAccID_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "BY CUSTOMER NAME:";
            // 
            // lblFiltCustId
            // 
            this.lblFiltCustId.AutoSize = true;
            this.lblFiltCustId.Location = new System.Drawing.Point(40, 65);
            this.lblFiltCustId.Name = "lblFiltCustId";
            this.lblFiltCustId.Size = new System.Drawing.Size(102, 13);
            this.lblFiltCustId.TabIndex = 2;
            this.lblFiltCustId.Text = "BY CUSTOMER ID:";
            // 
            // lblFiltAccName
            // 
            this.lblFiltAccName.AutoSize = true;
            this.lblFiltAccName.Location = new System.Drawing.Point(40, 40);
            this.lblFiltAccName.Name = "lblFiltAccName";
            this.lblFiltAccName.Size = new System.Drawing.Size(113, 13);
            this.lblFiltAccName.TabIndex = 1;
            this.lblFiltAccName.Text = "BY ACCOUNT NAME:";
            // 
            // lblFiltAccID
            // 
            this.lblFiltAccID.AutoSize = true;
            this.lblFiltAccID.Location = new System.Drawing.Point(40, 15);
            this.lblFiltAccID.Name = "lblFiltAccID";
            this.lblFiltAccID.Size = new System.Drawing.Size(93, 13);
            this.lblFiltAccID.TabIndex = 0;
            this.lblFiltAccID.Text = "BY ACCOUNT ID:";
            // 
            // gwClients
            // 
            this.gwClients.AllowUserToAddRows = false;
            this.gwClients.AllowUserToDeleteRows = false;
            this.gwClients.AllowUserToOrderColumns = true;
            this.gwClients.AllowUserToResizeColumns = false;
            this.gwClients.AllowUserToResizeRows = false;
            this.gwClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gwClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gwClients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gwClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gwClients.Location = new System.Drawing.Point(12, 140);
            this.gwClients.MultiSelect = false;
            this.gwClients.Name = "gwClients";
            this.gwClients.RowHeadersVisible = false;
            this.gwClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gwClients.Size = new System.Drawing.Size(560, 166);
            this.gwClients.TabIndex = 12;
            // 
            // frmAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.gwClients);
            this.Controls.Add(this.lblFiltCustName);
            this.Controls.Add(this.cmdManageAccount);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "frmAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClients";
            this.lblFiltCustName.ResumeLayout(false);
            this.lblFiltCustName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gwClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmdManageAccount;
        private System.Windows.Forms.GroupBox lblFiltCustName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFiltCustId;
        private System.Windows.Forms.Label lblFiltAccName;
        private System.Windows.Forms.Label lblFiltAccID;
        private System.Windows.Forms.Button btnFiltCustName;
        private System.Windows.Forms.Button btnFiltCustID;
        private System.Windows.Forms.Button btnFiltAccName;
        private System.Windows.Forms.Button btnFiltAccID;
        private System.Windows.Forms.TextBox txtBxLName;
        private System.Windows.Forms.TextBox txtBxCustFName;
        private System.Windows.Forms.TextBox txtBxCustID;
        private System.Windows.Forms.TextBox txtBxAccName;
        private System.Windows.Forms.TextBox txtBxAccID;
        private System.Windows.Forms.DataGridView gwClients;
    }
}