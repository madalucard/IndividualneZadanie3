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
    public partial class frmClientManagement : Form
    {
        ViewModelBank _vmb = new ViewModelBank();
        List<Customers> _custtt = new List<Customers>();
        Account _acc = new Account();
        int custIdNext = 0;
        /// <summary>
        /// Backup, do not really use :)
        /// </summary>
        //public frmClientManagement() : this(0) { }

        /// <summary>
        /// Used when viewing/updating existing client.
        /// </summary>
        /// <param name="clientId"></param>
        public frmClientManagement(int custId)
        {
            custIdNext = custId;
            InitializeComponent();
            gwCardsView.DataSource = _vmb.GetAllCardsByAccID(custId);

            #region Fill clients info when form is opened
            _custtt = _vmb.GetCustomerByID(custId);
            _acc =_vmb.GetAccountByCustomerID(custId);
            lblCustIdValue.Text = _custtt[0].IdCustomer.ToString();
            lblTitleValue.Text = _custtt[0].Title.ToString() == "null" ? "" : _custtt[0].Title.ToString();
            lblFNameValue.Text = _custtt[0].Firstname.ToString();
            lblMNameValue.Text = _custtt[0].Middlename.ToString() == "null" ? "" : _custtt[0].Middlename.ToString();
            lblLNameValue.Text = _custtt[0].Lastname.ToString();
            lblSuffixValue.Text = _custtt[0].Suffix.ToString() == "null" ? "" : _custtt[0].Suffix.ToString();
            lblBDayValue.Text = _custtt[0].Birthdate.ToString();
            lblIDCardNumValue.Text = _custtt[0].IdCardPersonal.ToString();

            lblAddressValue.Text = _custtt[0].Address.ToString();
            lblPostcodeValue.Text = _custtt[0].Postcode.ToString();
            lblCityValue.Text = _custtt[0].CityId.ToString();
            lblCountryValue.Text = _custtt[0].Country.ToString();

            lblPhoneValue.Text = _custtt[0].Phone.ToString();
            lblEMailValue.Text = _custtt[0].Email.ToString() == "null" ? "" : _custtt[0].Email.ToString();
            #endregion
            #region Status set Active/Closed
            if (_custtt[0].Active)
            {
                OpenCust();
            }
            else
            {
                CloseCust();
            }

            if (_acc.Active)
            {
                OpenAcc();
            }
            else
            {
                CloseAcc();
            }
            #endregion
        }
        /// <summary>
        /// Change account status in db 
        /// </summary>
        /// <param name="idCustomer"></param>
        private void ChangeAccActiv(int IdCustomer)
        {
            _vmb.UpdateAccountActivityByIdCustomer(IdCustomer);
        }
        /// <summary>
        /// Change customer status in db
        /// </summary>
        /// <param name="IdCustomer"></param>
        private void ChangeCustActiv(int IdCustomer)
        {
            _vmb.UpdateCustomerActivityByIdCustomer(IdCustomer);
        }

        /// <summary>
        /// Sets customer to active.
        /// </summary>
        private void OpenCust()
        {
            lblCustStatusValue.Text = "ACTIVE";
            lblCustStatusValue.ForeColor = Color.Lime;
            cmdCloseOpenCustomer.Text = "Close customer";

            lblBDayValue.Visible = true;
            lblIDCardNumValue.Visible = true;
            lblAddressValue.Visible = true;
            lblPostcodeValue.Visible = true;
            lblCityValue.Visible = true;
            lblCountryValue.Visible = true;
            lblPhoneValue.Visible = true;
            lblEMailValue.Visible = true;
            gbCardsView.Visible = true;

            OpenAcc();
        }
        /// <summary>
        /// Sets customer to closed.
        /// </summary>
        private void CloseCust()
        {
            lblCustStatusValue.Text = "CLOSED";
            lblCustStatusValue.ForeColor = Color.Red;
            cmdCloseOpenCustomer.Text = "Open customer";

            lblBDayValue.Visible = false;
            lblIDCardNumValue.Visible = false;
            lblAddressValue.Visible = false;
            lblPostcodeValue.Visible = false;
            lblCityValue.Visible = false;
            lblCountryValue.Visible = false;
            lblPhoneValue.Visible = false;
            lblEMailValue.Visible = false;
            gbCardsView.Visible = false;

            CloseAcc();
        }

        /// <summary>
        /// Sets account to active.
        /// </summary>
        private void OpenAcc()
        {
            lblAccStatusValue.Text = "ACTIVE";
            lblAccStatusValue.ForeColor = Color.Lime;
            cmdCloseOpenAcc.Text = "Close account";

            lblAmountValue.Visible = true;
            gbCardsView.Visible = true;

        }
        /// <summary>
        /// Sets account to closed.
        /// </summary>
        private void CloseAcc()
        {
            lblAccStatusValue.Text = "CLOSED";
            lblAccStatusValue.ForeColor = Color.Red;
            cmdCloseOpenAcc.Text = "Open account";

            lblAmountValue.Visible = false;
            gbCardsView.Visible = false;
        }

        /// <summary>
        /// Button for  closing and opening account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdCloseOpenAccount_Click(object sender, EventArgs e)
        {

            if (lblAccStatusValue.Text == "ACTIVE")
            {
                MessageBox.Show("Are you sure?", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                ChangeAccActiv(_custtt[0].IdCustomer);
                CloseAcc();
            }
            else if (lblAccStatusValue.Text == "CLOSED")
            {
                MessageBox.Show("Are you sure?", "Opening", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                ChangeAccActiv(_custtt[0].IdCustomer);
                OpenAcc();
            }

        }
        /// <summary>
        /// Button for  closing and opening account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdCloseOpenCust_Click(object sender, EventArgs e)
        {

            if (lblCustStatusValue.Text == "ACTIVE")
            {
                MessageBox.Show("Are you sure?", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                ChangeCustActiv(_custtt[0].IdCustomer);
                if (_acc.Active)
                {
                    ChangeAccActiv(_custtt[0].IdCustomer);
                }
                CloseCust();
            }
            else if (lblCustStatusValue.Text == "CLOSED")
            {
                MessageBox.Show("Are you sure?", "Opening", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                ChangeCustActiv(_custtt[0].IdCustomer);
                if (_acc.Active)
                {
                    ChangeAccActiv(_custtt[0].IdCustomer);
                }   
                OpenCust();
            }
        }
                                 
        /// <summary>
        /// Opens formular for update customer(register)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            using (frmAccount newForm = new frmAccount(custIdNext))
            {
                newForm.ShowDialog();
            }
        }
        /// <summary>
        /// Show all transaction from/for this account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdAllTransactions_Click(object sender, EventArgs e)
        {
            using (frmTransactions newForm = new frmTransactions(_acc.IdAccount))
            {
                newForm.ShowDialog();
            }
        }
        /// <summary>
        /// Opens formular for deposit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdDeposit_Click(object sender, EventArgs e)
        {
            using (frmTransaction newForm = new frmTransaction(1))
            {
                newForm.ShowDialog();
            }
        }
             
        /// <summary>
        /// opens formular for withdrawal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdWithdrawal_Click(object sender, EventArgs e)
        {
            using (frmTransaction newForm = new frmTransaction(2))
            {
                newForm.ShowDialog();
            }
        }
       
        /// <summary>
        /// opens formular new transaction
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdNewTransaction_Click(object sender, EventArgs e)
        {
            using (frmTransaction newForm = new frmTransaction(3))
            {
                newForm.ShowDialog();
            }
        }

      
      
    }
}
