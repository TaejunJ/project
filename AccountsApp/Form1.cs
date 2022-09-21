using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountsApp
{
    public partial class Form1 : Form
    {
        private List<Account> accounts = new List<Account>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void grbDetails_Enter(object sender, EventArgs e)
        {

        }

        private void rbtnChecking_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnChecking.Checked)
            {
                txtWithdraw.Enabled = true;
                txtInterest.Enabled = false;
            }
        }

        private void rbtnSaving_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSaving.Checked)
            {
                txtWithdraw.Enabled = false;
                txtInterest.Enabled = true;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbtnChecking.Checked)
                {
                    CheckingAccount myChecking = new CheckingAccount(
                        Convert.ToInt32(txtAccountNo.Text),
                        txtClient.Text,
                        Convert.ToDouble(txtBalance.Text),
                        Convert.ToDouble(txtWithdraw.Text));

                    accounts.Add(myChecking);
                }
                else if (rbtnSaving.Checked)
                {
                    SavingAccount mySaving = new SavingAccount(
                        Convert.ToInt32(txtAccountNo.Text),
                        txtClient.Text,
                        Convert.ToDouble(txtBalance.Text),
                        Convert.ToDouble(txtInterest.Text));

                    accounts.Add(mySaving);
                }

                txtAccountNo.Text = "";
                txtClient.Text = "";
                txtBalance.Text = "";
                txtWithdraw.Text = "";
                txtInterest.Text = "";

                rbtnChecking.Checked = true;
                rbtnSaving.Checked = false;

                MessageBox.Show($"You have total {accounts.Count} account(s)");
            }
            catch (FormatException)
            {
                MessageBox.Show("Account Number, Balance, Widthraw Limit, Interest Rate should be a number set!");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //var account = accounts[int.Parse(txtAccountNo.Text)];
            //if (account == null) return;
            //txtAccountNo.Text = Convert.ToString(account.Number);
            //txtClient.Text = account.Name;
            //txtBalance.Text = Convert.ToString(account.Balance);
            //txtWithdraw.Text = rbtnChecking.Checked ? (account as CheckingAccount).Limit.ToString() : "";
            //txtInterest.Text = rbtnSaving.Checked ? "" : (account as SavingAccount).Interest.ToString();
        }
    }
}
