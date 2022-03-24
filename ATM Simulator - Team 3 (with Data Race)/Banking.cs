using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 * AC22005 Assignment 2 Group 3
 * Ross Coombs: 2410466
 * Daniel Ferrier: 2413440
 * Kamil Krauze: 2414951
 */

namespace ATM_Simulator___Team_3__with_Data_Race_
{
    public partial class Banking_form : Form
    {
        // reference to account with which form is open
        Account account_ref;

        // instance variable for new amount
        int newAmount;
        
        // controls to add and remove as necessary
        Label lblBalance, lblSuccess;
        Button[] btnWithdrawAmounts;
        System.Windows.Forms.Timer tmrSuccess;

        /**
         * Constructor method, taking account as parameter
         */
        public Banking_form(Account account)
        {
            Console.WriteLine("Account: {0}",account.getBalance());

            // assign account reference to instance variable
            account_ref = account;

            InitializeComponent();

            // initialise label for balance
            lblBalance = new Label();
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(168, 63);
            lblBalance.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblBalance.ForeColor = SystemColors.ControlLight;
            lblBalance.Text = "Balance:\n£" + account_ref.getBalance().ToString();

            // initialise label for withdrawal success/failure
            lblSuccess = new Label();
            lblSuccess.AutoSize = true;
            lblSuccess.Location = new Point(12, 388);
            lblSuccess.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSuccess.ForeColor = Color.IndianRed;
            lblSuccess.Text = "";

            // initialise timer for label disappearing
            tmrSuccess = new System.Windows.Forms.Timer();
            tmrSuccess.Interval = 3000;
            tmrSuccess.Tick += new EventHandler(hideSuccessLabel);

            // initialise buttons for withdrawal balance amounts
            int[] amounts = { 10, 20, 50, 100, 500 };
            btnWithdrawAmounts = new Button[amounts.Length];

            int buttonHeight = 55;

            for (int i = 0; i < amounts.Length; i++)
            {
                btnWithdrawAmounts[i] = new Button();
                
                btnWithdrawAmounts[i].BackColor = Color.White;
                btnWithdrawAmounts[i].FlatAppearance.MouseDownBackColor = Color.FromArgb(255,0,192,192);
                btnWithdrawAmounts[i].FlatAppearance.MouseOverBackColor = Color.Silver;
                btnWithdrawAmounts[i].FlatStyle = FlatStyle.Flat;
                btnWithdrawAmounts[i].Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
                btnWithdrawAmounts[i].Location = new Point(168, buttonHeight);
                btnWithdrawAmounts[i].Size = new Size(150, 50);
                btnWithdrawAmounts[i].Text = "£" + amounts[i].ToString();

                // temp variable to send value of button as parameter to event handler
                int amountArg = amounts[i];
                btnWithdrawAmounts[i].Click += delegate(object sender, EventArgs e)
                {
                    btnWithdrawAmount_Click(sender, e, amountArg);
                };

                buttonHeight += 55;
            }
        }

        /**
         * Method to view account balance
         */
        private void btnViewBalance_Click(object sender, EventArgs e)
        {
            
            //update label
            lblBalance.Text = "Balance:\n£" + account_ref.getBalance().ToString();

            // swap controls in view as necessary
            Controls.Remove(lblSuccess);
            for (int i = 0; i < btnWithdrawAmounts.Length; i++)
            {
                Controls.Remove(btnWithdrawAmounts[i]);
            }
            Controls.Add(lblBalance);
        }

        /**
         * Method to show withdrawal options
         */
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            Controls.Remove(lblBalance);
            for (int i = 0; i < btnWithdrawAmounts.Length; i++)
            {
                Controls.Add(btnWithdrawAmounts[i]);
            }
        }

        /**
         * Method to withdraw money
         */
        private void btnWithdrawAmount_Click(object sender, EventArgs e, int amount)
        {
            // put button colours back to default
            for (int i = 0; i < btnWithdrawAmounts.Length; i++)
            {
                btnWithdrawAmounts[i].BackColor = Color.White;
            }

            Button thisButton = (Button)sender;

            // get balance and assign to instance variable
            newAmount = account_ref.getBalance();
            
            // check that account has high enough balance and change success label appropriately
            if (account_ref.getBalance() >= amount)
            {
                lblSuccess.ForeColor = Color.LightGreen;
                lblSuccess.Text = "Withdrawing...";
                thisButton.BackColor = Color.Lime;
                newAmount -= amount;
            }
            else
            {
                lblSuccess.ForeColor = Color.IndianRed;
                lblSuccess.Text = "Insufficient funds";
                thisButton.BackColor = Color.Red;
            }

            Controls.Add(lblSuccess);

            // reset success label
            tmrSuccess.Stop();
            tmrSuccess.Start();
        }

        /**
         * Method to remove success label
         */
        private void hideSuccessLabel(Object sender, EventArgs e)
        {
            tmrSuccess.Stop();

            // set account to have new balance
            account_ref.setBalance(newAmount);

            Controls.Remove(lblSuccess);
            this.Close();
        }
    }
}
