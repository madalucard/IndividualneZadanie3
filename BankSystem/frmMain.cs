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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region Watermarks
        /// <summary>
        /// After enter to TextBox clears Text and change color to Black
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBxMainFindClient_Enter(object sender, EventArgs e)
        {
            if (txtBxMainFindClient.Text.ToUpper() == "ID")
            {
                txtBxMainFindClient.Text = "";
                txtBxMainFindClient.ForeColor = Color.Black;
            }
        }
        /// <summary>
        /// After leaving TextBox change color to LightGray
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBxMainFindClient_Leave(object sender, EventArgs e)
        {
            if (txtBxMainFindClient.Text == "")
            {
                txtBxMainFindClient.Text = "ID";
                txtBxMainFindClient.ForeColor = Color.LightGray;
            }
        }
        #endregion

        /// <summary>
        /// Opens new frmClientManagment with filtered Client/Account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdFindClient_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBxMainFindClient.Text, out int result))
            {
                MessageBox.Show("Put number ID");
            }
            else
            {
                using (frmClientManagement newForm = new frmClientManagement(result))
                {
                    newForm.ShowDialog();
                }
            }
        }

        private void cmdNewAccount_Click(object sender, EventArgs e)
        {
            using (frmAccount newForm = new frmAccount())
            {
                newForm.ShowDialog();
            }
        }

        private void cmdAllAccounts_Click(object sender, EventArgs e)
        {
            using (frmAccounts newForm = new frmAccounts())
            {
                newForm.ShowDialog();
            }
        }

        private void cmdAllTransactions_Click(object sender, EventArgs e)
        {
            using (frmTransactions newForm = new frmTransactions())
            {
                newForm.ShowDialog();
            }
        }
    }
}
