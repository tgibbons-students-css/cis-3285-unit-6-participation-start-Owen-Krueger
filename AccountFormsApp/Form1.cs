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
                //Set new account name to account name field
				string accountName = txtAccountName.Text;
                //Currently, all accounts made are an Account Type of Silver
				accService.CreateAccount(accountName, AccountType.Silver);

                //Add account to list box of current accounts
				listCurrentAccounts.Items.Add(accountName);
                //Reset account name text box
				txtAccountName.ResetText();

			}
		}

		//Get balance from selected account
		private void listCurrentAccounts_SelectedIndexChanged(object sender, EventArgs e)
		{
            //Get account name from selected item in list box
			string accountName = listCurrentAccounts.SelectedItem.ToString();
            //Get balance from account name
			Decimal balance = accService.GetAccountBalance(accountName);

            //Set account balance text box to account balance
			txtAccountBalance.Text = balance.ToString();

            //Allow user to enter deposit and withdrawl amounts into textboxes
			txtDepositAmount.ReadOnly = false;
			txtWithdrawAmount.ReadOnly = false;

            //Allow user to click deposit and withdraw buttons on form
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

                //Update balance textbox with new balance
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
            //Check if value is empty and that it can be parsed to a Decimal value
            if (!string.IsNullOrWhiteSpace(txtWithdrawAmount.Text) &&
                Decimal.TryParse(txtWithdrawAmount.Text, out withdrawlAmount))
            {
                //Withdraw amount from balance
                accService.Withdrawal(accountName, withdrawlAmount);

                //Update balance textbox with new balance
                txtAccountBalance.Text = accService.GetAccountBalance(accountName).ToString();
                //Reset withdraw field
                txtWithdrawAmount.ResetText();
            }			
		}
	}
}
