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
    public partial class frmAccount : Form
    {
        ViewModelBank _vmb = new ViewModelBank();
        /// <summary>
        /// Used when adding new account.
        /// </summary>
        public frmAccount()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Used when viewing/updating existing account.
        /// </summary>
        /// <param name="clientId"></param>
        public frmAccount(int clientId)
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            int ruturnedID=0;
            StringBuilder sb = new StringBuilder();
            sb.Append($"{txtEmail1.Text.ToString()}@{txtEmail2.Text.ToString()}");

            ruturnedID = _vmb.RegisterCustomers(txtTitle.Text.ToString(),
                                    txtFName.Text.ToString(),
                                    txtMName.Text.ToString(),
                                    txtLName.Text.ToString(),
                                    txtSuffix.Text.ToString(),
                                    DateTime.Parse(dtpBirthDate.Text.ToString()),
                                    txtIDCardPers.Text.ToString(),
                                    txtAddress.Text.ToString(),
                                    txtPostcode.Text.ToString(),
                                    int.Parse(txtCityID.Text),
                                    txtCountry.Text.ToString(),
                                    txtPhone.Text.ToString(),
                                    sb.ToString());


            //  TODO natlacit tam ID customera
            _vmb.RegisterAccount(ruturnedID, txtAccName.Text.ToString(), int.Parse(txtOverdraft.Text));
            using (frmClientManagement newForm = new frmClientManagement(ruturnedID))
            {
                newForm.ShowDialog();
            }

        }
    }
}
