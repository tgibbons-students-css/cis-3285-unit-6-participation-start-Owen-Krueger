namespace AccountFormsApp
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblAccountName = new System.Windows.Forms.Label();
			this.txtAccountName = new System.Windows.Forms.TextBox();
			this.btnAddAccount = new System.Windows.Forms.Button();
			this.lblCurrentAccounts = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.listCurrentAccounts = new System.Windows.Forms.ListBox();
			this.txtDepositAmount = new System.Windows.Forms.TextBox();
			this.txtAccountBalance = new System.Windows.Forms.TextBox();
			this.txtWithdrawAmount = new System.Windows.Forms.TextBox();
			this.lblAccountBalance = new System.Windows.Forms.Label();
			this.lblAmount = new System.Windows.Forms.Label();
			this.btnDeposit = new System.Windows.Forms.Button();
			this.btnWithdraw = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblAccountName
			// 
			this.lblAccountName.AutoSize = true;
			this.lblAccountName.Location = new System.Drawing.Point(16, 47);
			this.lblAccountName.Name = "lblAccountName";
			this.lblAccountName.Size = new System.Drawing.Size(103, 13);
			this.lblAccountName.TabIndex = 0;
			this.lblAccountName.Text = "New Account Name";
			// 
			// txtAccountName
			// 
			this.txtAccountName.Location = new System.Drawing.Point(19, 63);
			this.txtAccountName.Name = "txtAccountName";
			this.txtAccountName.Size = new System.Drawing.Size(100, 20);
			this.txtAccountName.TabIndex = 1;
			// 
			// btnAddAccount
			// 
			this.btnAddAccount.Location = new System.Drawing.Point(19, 90);
			this.btnAddAccount.Name = "btnAddAccount";
			this.btnAddAccount.Size = new System.Drawing.Size(100, 23);
			this.btnAddAccount.TabIndex = 2;
			this.btnAddAccount.Text = "Add Account";
			this.btnAddAccount.UseVisualStyleBackColor = true;
			this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
			// 
			// lblCurrentAccounts
			// 
			this.lblCurrentAccounts.AutoSize = true;
			this.lblCurrentAccounts.Location = new System.Drawing.Point(16, 175);
			this.lblCurrentAccounts.Name = "lblCurrentAccounts";
			this.lblCurrentAccounts.Size = new System.Drawing.Size(89, 13);
			this.lblCurrentAccounts.TabIndex = 3;
			this.lblCurrentAccounts.Text = "Current Accounts";
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(14, 8);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(279, 24);
			this.lblTitle.TabIndex = 4;
			this.lblTitle.Text = "Wells Fargo Account Creator";
			// 
			// listCurrentAccounts
			// 
			this.listCurrentAccounts.FormattingEnabled = true;
			this.listCurrentAccounts.Location = new System.Drawing.Point(12, 191);
			this.listCurrentAccounts.Name = "listCurrentAccounts";
			this.listCurrentAccounts.Size = new System.Drawing.Size(120, 95);
			this.listCurrentAccounts.TabIndex = 6;
			this.listCurrentAccounts.SelectedIndexChanged += new System.EventHandler(this.listCurrentAccounts_SelectedIndexChanged);
			// 
			// txtDepositAmount
			// 
			this.txtDepositAmount.Location = new System.Drawing.Point(286, 191);
			this.txtDepositAmount.Name = "txtDepositAmount";
			this.txtDepositAmount.ReadOnly = true;
			this.txtDepositAmount.Size = new System.Drawing.Size(100, 20);
			this.txtDepositAmount.TabIndex = 7;
			// 
			// txtAccountBalance
			// 
			this.txtAccountBalance.Location = new System.Drawing.Point(286, 119);
			this.txtAccountBalance.Name = "txtAccountBalance";
			this.txtAccountBalance.ReadOnly = true;
			this.txtAccountBalance.Size = new System.Drawing.Size(100, 20);
			this.txtAccountBalance.TabIndex = 8;
			// 
			// txtWithdrawAmount
			// 
			this.txtWithdrawAmount.Location = new System.Drawing.Point(286, 217);
			this.txtWithdrawAmount.Name = "txtWithdrawAmount";
			this.txtWithdrawAmount.ReadOnly = true;
			this.txtWithdrawAmount.Size = new System.Drawing.Size(100, 20);
			this.txtWithdrawAmount.TabIndex = 9;
			// 
			// lblAccountBalance
			// 
			this.lblAccountBalance.AutoSize = true;
			this.lblAccountBalance.Location = new System.Drawing.Point(286, 100);
			this.lblAccountBalance.Name = "lblAccountBalance";
			this.lblAccountBalance.Size = new System.Drawing.Size(89, 13);
			this.lblAccountBalance.TabIndex = 10;
			this.lblAccountBalance.Text = "Account Balance";
			// 
			// lblAmount
			// 
			this.lblAmount.AutoSize = true;
			this.lblAmount.Location = new System.Drawing.Point(289, 172);
			this.lblAmount.Name = "lblAmount";
			this.lblAmount.Size = new System.Drawing.Size(43, 13);
			this.lblAmount.TabIndex = 11;
			this.lblAmount.Text = "Amount";
			// 
			// btnDeposit
			// 
			this.btnDeposit.Enabled = false;
			this.btnDeposit.Location = new System.Drawing.Point(205, 188);
			this.btnDeposit.Name = "btnDeposit";
			this.btnDeposit.Size = new System.Drawing.Size(75, 23);
			this.btnDeposit.TabIndex = 12;
			this.btnDeposit.Text = "Deposit";
			this.btnDeposit.UseVisualStyleBackColor = true;
			this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
			// 
			// btnWithdraw
			// 
			this.btnWithdraw.Enabled = false;
			this.btnWithdraw.Location = new System.Drawing.Point(205, 214);
			this.btnWithdraw.Name = "btnWithdraw";
			this.btnWithdraw.Size = new System.Drawing.Size(75, 23);
			this.btnWithdraw.TabIndex = 13;
			this.btnWithdraw.Text = "Withdraw";
			this.btnWithdraw.UseVisualStyleBackColor = true;
			this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(403, 306);
			this.Controls.Add(this.btnWithdraw);
			this.Controls.Add(this.btnDeposit);
			this.Controls.Add(this.lblAmount);
			this.Controls.Add(this.lblAccountBalance);
			this.Controls.Add(this.txtWithdrawAmount);
			this.Controls.Add(this.txtAccountBalance);
			this.Controls.Add(this.txtDepositAmount);
			this.Controls.Add(this.listCurrentAccounts);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.lblCurrentAccounts);
			this.Controls.Add(this.btnAddAccount);
			this.Controls.Add(this.txtAccountName);
			this.Controls.Add(this.lblAccountName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Wells Fargo Account Creator";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblAccountName;
		private System.Windows.Forms.TextBox txtAccountName;
		private System.Windows.Forms.Button btnAddAccount;
		private System.Windows.Forms.Label lblCurrentAccounts;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.ListBox listCurrentAccounts;
		private System.Windows.Forms.TextBox txtDepositAmount;
		private System.Windows.Forms.TextBox txtAccountBalance;
		private System.Windows.Forms.TextBox txtWithdrawAmount;
		private System.Windows.Forms.Label lblAccountBalance;
		private System.Windows.Forms.Label lblAmount;
		private System.Windows.Forms.Button btnDeposit;
		private System.Windows.Forms.Button btnWithdraw;
	}
}

