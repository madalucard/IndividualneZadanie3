namespace BankSystem
{
    partial class frmTransaction
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
            this.gbSender = new System.Windows.Forms.GroupBox();
            this.lblSender = new System.Windows.Forms.Label();
            this.gbReciewer = new System.Windows.Forms.GroupBox();
            this.lblReciever = new System.Windows.Forms.Label();
            this.gbTranDetails = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVS = new System.Windows.Forms.TextBox();
            this.txtSS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbSender.SuspendLayout();
            this.gbReciewer.SuspendLayout();
            this.gbTranDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSender
            // 
            this.gbSender.Controls.Add(this.textBox3);
            this.gbSender.Controls.Add(this.label1);
            this.gbSender.Controls.Add(this.textBox1);
            this.gbSender.Controls.Add(this.lblSender);
            this.gbSender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbSender.Location = new System.Drawing.Point(10, 7);
            this.gbSender.Name = "gbSender";
            this.gbSender.Size = new System.Drawing.Size(202, 117);
            this.gbSender.TabIndex = 8;
            this.gbSender.TabStop = false;
            this.gbSender.Text = "SENDERS INFO:";
            // 
            // lblSender
            // 
            this.lblSender.AutoSize = true;
            this.lblSender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSender.Location = new System.Drawing.Point(7, 20);
            this.lblSender.Name = "lblSender";
            this.lblSender.Size = new System.Drawing.Size(62, 13);
            this.lblSender.TabIndex = 1;
            this.lblSender.Text = "SENDER:";
            // 
            // gbReciewer
            // 
            this.gbReciewer.Controls.Add(this.textBox4);
            this.gbReciewer.Controls.Add(this.label2);
            this.gbReciewer.Controls.Add(this.textBox2);
            this.gbReciewer.Controls.Add(this.lblReciever);
            this.gbReciewer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbReciewer.Location = new System.Drawing.Point(218, 7);
            this.gbReciewer.Name = "gbReciewer";
            this.gbReciewer.Size = new System.Drawing.Size(209, 117);
            this.gbReciewer.TabIndex = 9;
            this.gbReciewer.TabStop = false;
            this.gbReciewer.Text = "RECIEWER INFO:";
            // 
            // lblReciever
            // 
            this.lblReciever.AutoSize = true;
            this.lblReciever.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblReciever.Location = new System.Drawing.Point(6, 20);
            this.lblReciever.Name = "lblReciever";
            this.lblReciever.Size = new System.Drawing.Size(73, 13);
            this.lblReciever.TabIndex = 2;
            this.lblReciever.Text = "RECIEVER:";
            // 
            // gbTranDetails
            // 
            this.gbTranDetails.Controls.Add(this.txtMessage);
            this.gbTranDetails.Controls.Add(this.label6);
            this.gbTranDetails.Controls.Add(this.txtKS);
            this.gbTranDetails.Controls.Add(this.label5);
            this.gbTranDetails.Controls.Add(this.txtSS);
            this.gbTranDetails.Controls.Add(this.label4);
            this.gbTranDetails.Controls.Add(this.txtVS);
            this.gbTranDetails.Controls.Add(this.label3);
            this.gbTranDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbTranDetails.Location = new System.Drawing.Point(9, 192);
            this.gbTranDetails.Name = "gbTranDetails";
            this.gbTranDetails.Size = new System.Drawing.Size(418, 135);
            this.gbTranDetails.TabIndex = 10;
            this.gbTranDetails.TabStop = false;
            this.gbTranDetails.Text = "TRANSACTION DETAILS:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 23);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(194, 23);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 85);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(194, 23);
            this.textBox4.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(128, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 72);
            this.button1.TabIndex = 11;
            this.button1.Text = "SEND";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "VS:";
            // 
            // txtVS
            // 
            this.txtVS.Location = new System.Drawing.Point(108, 16);
            this.txtVS.Name = "txtVS";
            this.txtVS.Size = new System.Drawing.Size(304, 23);
            this.txtVS.TabIndex = 6;
            // 
            // txtSS
            // 
            this.txtSS.Location = new System.Drawing.Point(108, 45);
            this.txtSS.Name = "txtSS";
            this.txtSS.Size = new System.Drawing.Size(304, 23);
            this.txtSS.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "SS:";
            // 
            // txtKS
            // 
            this.txtKS.Location = new System.Drawing.Point(108, 74);
            this.txtKS.Name = "txtKS";
            this.txtKS.Size = new System.Drawing.Size(304, 23);
            this.txtKS.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "KS:";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(108, 103);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(304, 23);
            this.txtMessage.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "MESSAGE:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(10, 85);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(186, 23);
            this.textBox3.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(128, 166);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(169, 20);
            this.textBox5.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(164, 133);
            this.label7.MinimumSize = new System.Drawing.Size(100, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 31);
            this.label7.TabIndex = 13;
            this.label7.Text = "SUM:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // frmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 409);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbReciewer);
            this.Controls.Add(this.gbSender);
            this.Controls.Add(this.gbTranDetails);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmTransaction";
            this.gbSender.ResumeLayout(false);
            this.gbSender.PerformLayout();
            this.gbReciewer.ResumeLayout(false);
            this.gbReciewer.PerformLayout();
            this.gbTranDetails.ResumeLayout(false);
            this.gbTranDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSender;
        private System.Windows.Forms.GroupBox gbReciewer;
        private System.Windows.Forms.GroupBox gbTranDetails;
        private System.Windows.Forms.Label lblSender;
        private System.Windows.Forms.Label lblReciever;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
    }
}