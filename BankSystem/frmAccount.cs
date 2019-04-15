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
        List<Customers> _custtt = new List<Customers>();
        Account _acccc = new Account();
        /// <summary>
        /// Used when adding new account.
        /// </summary>
        public frmAccount()
        {
            InitializeComponent();
            btnRegister.Text = "Register";
            btnUpdate.Visible = false;
            btnRegister.Visible = true;

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            int ruturnedID = 0;
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


        /// <summary>
        /// Used when viewing/updating existing account.
        /// </summary>
        /// <param name="clientId"></param>
        public frmAccount(int clientId)
        {   
            InitializeComponent();
            _custtt = _vmb.GetCustomerByID(clientId);
            _acccc = _vmb.GetAccountByCustomerID(clientId);

            txtTitle.Text = _custtt[0].Title;
            txtFName.Text = _custtt[0].Firstname;
            txtMName.Text = _custtt[0].Middlename;
            txtLName.Text = _custtt[0].Lastname;
            txtSuffix.Text = _custtt[0].Suffix;
            txtIDCardPers.Text = _custtt[0].IdCardPersonal;
            //birthdate
            txtAddress.Text = _custtt[0].Address;
            txtPostcode.Text = _custtt[0].Postcode;
            txtCityID.Text = _custtt[0].CityId.ToString();
            txtCountry.Text = _custtt[0].Country;
            txtPhone.Text = _custtt[0].Phone;

            char separator = '@';
            string[] s1 = _custtt[0].Email.Split(separator);

            txtEmail1.Text = s1[0];
            txtEmail2.Text = s1[1];
            txtAccName.Text = _acccc.AccName;
            txtOverdraft.Text = _acccc.Overdraft.ToString();

            btnUpdate.Text = "Update";
            btnUpdate.Visible = true;
            btnRegister.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{txtEmail1.Text.ToString()}@{txtEmail2.Text.ToString()}");

            _vmb.UpdateCustomer(_custtt[0].IdCustomer,
                                    txtTitle.Text.ToString(),
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
            _vmb.UpdateAccount(_custtt[0].IdCustomer,
                                txtAccName.Text.ToString(),
                                int.Parse(txtOverdraft.Text)
                                );
            Close();
        }
    }
}
