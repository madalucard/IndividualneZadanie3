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
            this.lblReciever = new System.Windows.Forms.Label();
            this.lblSender = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblReciever
            // 
            this.lblReciever.BackColor = System.Drawing.Color.Moccasin;
            this.lblReciever.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReciever.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblReciever.Location = new System.Drawing.Point(218, 7);
            this.lblReciever.Name = "lblReciever";
            this.lblReciever.Size = new System.Drawing.Size(209, 179);
            this.lblReciever.TabIndex = 6;
            this.lblReciever.Text = "Tu niekde budú informácie o príjemcovi.";
            this.lblReciever.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSender
            // 
            this.lblSender.BackColor = System.Drawing.Color.Firebrick;
            this.lblSender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSender.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSender.Location = new System.Drawing.Point(10, 7);
            this.lblSender.Name = "lblSender";
            this.lblSender.Size = new System.Drawing.Size(203, 179);
            this.lblSender.TabIndex = 5;
            this.lblSender.Text = "Tu niekde budú informácie o odosielateľovi.";
            this.lblSender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkCyan;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(10, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(418, 86);
            this.label3.TabIndex = 7;
            this.label3.Text = "A niekde naokolo bude suma, VS, ŠS, KS, správa pre príjemcu....";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 287);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblReciever);
            this.Controls.Add(this.lblSender);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmTransaction";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblReciever;
        private System.Windows.Forms.Label lblSender;
        private System.Windows.Forms.Label label3;
    }
}