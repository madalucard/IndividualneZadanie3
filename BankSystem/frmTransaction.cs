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
        DataTable _senders = new DataTable();
        DataTable _recievers = new DataTable();

        public frmTransaction()
        {
            InitializeComponent();
        }

        public frmTransaction(int i)
        {
            InitializeComponent();

            _senders = _vmb.AllAccounts();
            _recievers = _vmb.AllAccounts();


            //cmbSenders.DataSource = _senders;
            //cmbSenders.DisplayMember = "c.Lastname";

            cmbSenders.DataSource = _senders;
            cmbSenders.DisplayMember = "c.Lastname";
            //CmbPrijimatelAdresa.DataSource = Prijimatel;
            //CmbPrijimatelAdresa.DisplayMember = "Adresa";
            //CmbPrijimatelIBAN.DataSource = Prijimatel;
            //CmbPrijimatelIBAN.DisplayMember = "UcetIBAN";



            switch (i)
            {



                case 1:




                    break;
                case 2:



                    break;
                case 3:
                    //do some stuff
                    break;












            }



        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
