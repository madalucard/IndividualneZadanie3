using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class frmTransaction : Form
    {
        ViewModelBank _vmb = new ViewModelBank();
        //DataTable _senders = new DataTable();
        //DataTable _recievers = new DataTable();
        Transaction _tran = new Transaction();

        public frmTransaction()
        {
            InitializeComponent();
        }

        public frmTransaction(int i)
        {
            InitializeComponent();

            //_senders = _vmb.AllAccounts();
            //_recievers = _vmb.AllAccounts();
            //cmbSenders.DataSource = _senders;
            //cmbSenders.DisplayMember = "c.Lastname";
            
            switch (i)
            {
                case 1:
                    //deposit
                    gbReciewer.Visible = true;
                    gbSender.Visible = false;

                    btnTransfer.Visible = false;
                    btnWithdraw.Visible = false;
                    btnDeposit.Visible = true;


                    break;
                case 2:
                    // withdraval
                    gbReciewer.Visible = false;
                    gbSender.Visible = true;

                    btnTransfer.Visible = false;
                    btnWithdraw.Visible = true;
                    btnDeposit.Visible = false;

                    break;
                case 3:
                    //transaction
                    btnTransfer.Visible = true;
                    btnWithdraw.Visible = false;
                    btnDeposit.Visible = false;
                                                                            
                    break;
                    
            }
        }


        private Transaction LoadFromTxt()
        {

            _tran.IdFrom = Convert.ToInt32(numTxtSender.Text);
            _tran.IdTo = Convert.ToInt32(numTxtReceiver.Text);
            _tran.Value = Convert.ToInt32(numTxtSum.Text);
            _tran.Vs = txtVS.Text;
            _tran.Ss = txtSS.Text;
            _tran.Ks = txtKS.Text;
            _tran.Message = txtMessage.Text;

            return _tran;
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            Transaction _tttt = new Transaction();
            _tttt.IdFrom = Convert.ToInt32(numTxtSender.Text);
            _tttt.IdTo = Convert.ToInt32(numTxtReceiver.Text);
            _tttt.Value = Convert.ToInt32(numTxtSum.Text);
            _tttt.Vs = txtVS.Text;
            _tttt.Ss = txtSS.Text;
            _tttt.Ks = txtKS.Text;
            _vmb.ValueMinus(_tttt.IdFrom,_tttt.Value);
            _vmb.ValuePlus(_tttt.IdTo,_tttt.Value);
            this.Close();
        }
        
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            Transaction _tttt = new Transaction();
            _tttt.IdFrom = Convert.ToInt32(numTxtSender.Text);
            _tttt.IdTo = 4;
            _tttt.Value = Convert.ToInt32(numTxtSum.Text);
            _tttt.Vs = txtVS.Text;
            _tttt.Ss = txtSS.Text;
            _tttt.Ks = txtKS.Text;
            _tttt.Message = txtMessage.Text;






            //_tttt = LoadFromTxt();

            _vmb.NewTransaction(_tttt);
            _vmb.ValueMinus(_tttt.IdFrom, _tttt.Value);

            this.Close();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            Transaction _tttt = new Transaction();
            _tttt.IdFrom =4;
            _tttt.IdTo = Convert.ToInt32(numTxtReceiver.Text);
            _tttt.Value = Convert.ToInt32(numTxtSum.Text);
            _tttt.Vs = txtVS.Text;
            _tttt.Ss = txtSS.Text;
            _tttt.Ks = txtKS.Text;
            _tttt.Message = txtMessage.Text;
            _vmb.NewTransaction(_tttt);
            _vmb.ValuePlus(_tttt.IdTo, _tttt.Value);
            this.Close();
        }

        
    }
}
