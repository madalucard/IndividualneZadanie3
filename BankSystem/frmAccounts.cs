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
    public partial class frmAccounts : Form
    {
        ViewModelBank _vmb = new ViewModelBank();

        public frmAccounts()
        {
            InitializeComponent();
        }
        public frmAccounts(int id)
        {
            InitializeComponent();
        }
        private void cmdManageAccount_Click(object sender, EventArgs e)
        {
            //using (frmClientManagement newForm = new frmClientManagement())
            //{
            //    newForm.ShowDialog();
            //}
        }

        #region Watermark txtBxs
        // ACCOUNT ID
        /// <summary>
        /// After enter to TextBox clears Text and change color to Black
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBxAccID_Enter(object sender, EventArgs e)
        {
            if (txtBxAccID.Text.ToUpper() == "ID")
            {
                txtBxAccID.Text = "";
                txtBxAccID.ForeColor = Color.Black;
            }
        }
        /// <summary>
        /// After leaving TextBox change color to LightGray
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBxAccID_Leave(object sender, EventArgs e)
        {
            if (txtBxAccID.Text == "")
            {
                txtBxAccID.Text = "ID";
                txtBxAccID.ForeColor = Color.LightGray;
            }
        }
        // ACCOUNT NAME
        /// <summary>
        /// After enter to TextBox clears Text and change color to Black
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBxAccName_Enter(object sender, EventArgs e)
        {
            if (txtBxAccName.Text.ToUpper() == "NAME")
            {
                txtBxAccName.Text = "";
                txtBxAccName.ForeColor = Color.Black;
            }

        }
        /// <summary>
        /// After leaving TextBox change color to LightGray
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBxAccName_Leave(object sender, EventArgs e)
        {
            if (txtBxAccName.Text == "")
            {
                txtBxAccName.Text = "NAME";
                txtBxAccName.ForeColor = Color.LightGray;
            }
        }
        // CUSTOMER ID
        /// <summary>
        /// After enter to TextBox clears Text and change color to Black
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBxCustID_Enter(object sender, EventArgs e)
        {
            if (txtBxCustID.Text.ToUpper() == "ID")
            {
                txtBxCustID.Text = "";
                txtBxCustID.ForeColor = Color.Black;
            }
        }
        /// <summary>
        /// After leaving TextBox change color to LightGray
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBxCustID_Leave(object sender, EventArgs e)
        {
            if (txtBxCustID.Text == "")
            {
                txtBxCustID.Text = "ID";
                txtBxCustID.ForeColor = Color.LightGray;
            }
        }
        // CUSTOMER FIRSTNAME
        /// <summary>
        /// After enter to TextBox clears Text and change color to Black
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBxCustFName_Enter(object sender, EventArgs e)
        {
            if (txtBxCustFName.Text.ToUpper() == "FIRSTNAME")
            {
                txtBxCustFName.Text = "";
                txtBxCustFName.ForeColor = Color.Black;
            }
        }
        /// <summary>
        /// After leaving TextBox change color to LightGray
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBxCustFName_Leave(object sender, EventArgs e)
        {
            if (txtBxCustFName.Text == "")
            {
                txtBxCustFName.Text = "FIRSTNAME";
                txtBxCustFName.ForeColor = Color.LightGray;
            }
        }
        // CUSTOMER LASTNAME
        /// <summary>
        /// After enter to TextBox clears Text and change color to Black
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBxLName_Enter(object sender, EventArgs e)
        {
            if (txtBxLName.Text.ToUpper() == "LASTNAME")
            {
                txtBxLName.Text = "";
                txtBxLName.ForeColor = Color.Black;
            }
        }
        /// <summary>
        /// After leaving TextBox change color to LightGray
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBxLName_Leave(object sender, EventArgs e)
        {
            if (txtBxLName.Text == "")
            {
                txtBxLName.Text = "LASTNAME";
                txtBxLName.ForeColor = Color.LightGray;
            }
        }
        #endregion

        #region Filtering buttons
        /// <summary>
        /// Find accoutnt by ID and load it to DataGridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFiltAccID_Click(object sender, EventArgs e)
        {
            int result;
            if (int.TryParse(txtBxAccID.Text, out result))
            {
                gwClients.DataSource = _vmb.GetAccountByID(result);
            }
            else
            {
                MessageBox.Show("Put number ID");
            }

           
        }
        /// <summary>
        /// Find customer by ID and load it to DataGridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFiltCustID_Click(object sender, EventArgs e)
        {
            int result;
            if (int.TryParse(txtBxCustID.Text, out result))
            {
                gwClients.DataSource = _vmb.GetCustomerByID(result);
            }
            else
            {
                MessageBox.Show("Put number ID");
            }
        }
        /// <summary>
        /// Find account by name(string) and load it to DataGridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFiltAccName_Click(object sender, EventArgs e)
        {
            gwClients.DataSource = _vmb.GetAccountsByName(txtBxAccName.Text);

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFiltCustName_Click(object sender, EventArgs e)
        {

            if (txtBxCustFName.Text == "FIRSTNAME")
            {
                gwClients.DataSource = _vmb.GetCustomerByLastname(txtBxLName.Text);
            }
            else 
            if (txtBxLName.Text == "LASTNAME")
            {
                gwClients.DataSource = _vmb.GetCustomerByFirstname(txtBxCustFName.Text);
            }
            else
            {
                gwClients.DataSource = _vmb.GetCustomerByFullname(txtBxCustFName.Text, txtBxLName.Text);
            }
        }
        #endregion

       
    }
}
