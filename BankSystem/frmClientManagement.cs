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

        /// <summary>
        /// Backup, do not really use :)
        /// </summary>
        //public frmClientManagement() : this(0) { }

        /// <summary>
        /// Used when viewing/updating existing client.
        /// </summary>
        /// <param name="clientId"></param>
        public frmClientManagement(int accId)
        {
            List<Customers> _custtt = new List<Customers>();
            InitializeComponent();
            gwCardsView.DataSource = _vmb.GetAllCardsByAccID(accId);
            #region Fill clients info when form is opened
            _custtt = _vmb.GetCustomerByID(accId);
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
        }












































        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            using (frmAccount newForm = new frmAccount(42))
            {
                newForm.ShowDialog();
            }
        }

        private void cmdDeposit_Click(object sender, EventArgs e)
        {
            using (frmTransaction newForm = new frmTransaction())
            {
                newForm.ShowDialog();
            }
        }

        private void cmdWithdrawal_Click(object sender, EventArgs e)
        {
            using (frmTransaction newForm = new frmTransaction())
            {
                newForm.ShowDialog();
            }
        }

        private void cmdAllTransactions_Click(object sender, EventArgs e)
        {
            using (frmTransactions newForm = new frmTransactions(42))
            {
                newForm.ShowDialog();
            }
        }

        private void cmdNewTransaction_Click(object sender, EventArgs e)
        {
            using (frmTransaction newForm = new frmTransaction())
            {
                newForm.ShowDialog();
            }
        }

        private void cmdCloseAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hodor?", "Hodor!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DialogResult = DialogResult.OK;
            }
        }
// TODO DELETE THIS!!!
        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
