using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;
using Domain;

namespace AccountFormsApp
{
	public partial class Form1 : Form
	{
		AccountService accService = new AccountService();

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		//Add Account to account list and create new account
		private void btnAddAccount_Click(object sender, EventArgs e)
		{
			//Check if Account Name is Null or a whitespace
			if (!string.IsNullOrWhiteSpace(txtAccountName.Text))
			{
				string accountName = txtAccountName.Text;
				accService.CreateAccount(accountName, AccountType.Silver);

				listCurrentAccounts.Items.Add(accountName);
				txtAccountName.ResetText();

			}
		}

		//Get balance from selected account
		private void listCurrentAccounts_SelectedIndexChanged(object sender, EventArgs e)
		{
			string accountName = listCurrentAccounts.SelectedItem.ToString();
			Decimal balance = accService.GetAccountBalance(accountName);

			txtAccountBalance.Text = balance.ToString();

			txtDepositAmount.ReadOnly = false;
			txtWithdrawAmount.ReadOnly = false;
			btnDeposit.Enabled = true;
			btnWithdraw.Enabled = true;
		}

		//Add deposit amount to balance of selected account
		private void btnDeposit_Click(object sender, EventArgs e)
		{
			string accountName = listCurrentAccounts.SelectedItem.ToString();
            Decimal depositAmount;
            //Check if value is empty and that it can be parsed to a Decimal value
            if (!string.IsNullOrWhiteSpace(txtDepositAmount.Text) &&
                Decimal.TryParse(txtDepositAmount.Text, out depositAmount))
            {
                //Deposit amount into balance
                accService.Deposit(accountName, depositAmount);

                //Update balance with new balance
                txtAccountBalance.Text = accService.GetAccountBalance(accountName).ToString();
                //Reset deposit field
                txtDepositAmount.ResetText();
            }
		}

		//Remove withdraw amount from balance of selected account
		private void btnWithdraw_Click(object sender, EventArgs e)
		{
			string accountName = listCurrentAccounts.SelectedItem.ToString();
            Decimal withdrawlAmount;
            if (!string.IsNullOrWhiteSpace(txtWithdrawAmount.Text) &&
                Decimal.TryParse(txtWithdrawAmount.Text, out withdrawlAmount))
            {
                accService.Withdrawal(accountName, withdrawlAmount);

                txtAccountBalance.Text = accService.GetAccountBalance(accountName).ToString();
                txtWithdrawAmount.ResetText();
            }			
		}
	}
}
