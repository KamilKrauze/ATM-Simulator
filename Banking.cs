using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Team3
{
    public partial class Banking_form : Form
    {
        // account just for testing
        Account account_ref;
        
        // controls to add and remove as necessary
        Label lblBalance, lblSuccess;
        Button[] btnWithdrawAmounts;
        Timer tmrSuccess;

        public Banking_form(ref Account account)
        {
            Console.WriteLine("Account: {0}",account.getBalance());

            // account just for testing
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
            tmrSuccess = new Timer();
            tmrSuccess.Interval = 1500;
            tmrSuccess.Tick += new EventHandler(hideSuccessLabel);

            // initialise buttons for withdrawal balance amounts
            int[] amounts = { 10, 20, 50, 100, 500 };
            btnWithdrawAmounts = new Button[amounts.Length];

            int buttonHeight = 63;

            for (int i = 0; i < amounts.Length; i++)
            {
                btnWithdrawAmounts[i] = new Button();
                
                btnWithdrawAmounts[i].BackColor = Color.White;
                btnWithdrawAmounts[i].FlatAppearance.MouseDownBackColor = Color.Gray;
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

                buttonHeight += 56;
            }
        }

        /**
         * Method to view account balance
         */
        private void btnViewBalance_Click(object sender, EventArgs e)
        {

            //update label
            lblBalance.Text = "Balance:\n£" + accountTest.getBalance().ToString();

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
            if (accountTest.decrementBalance(amount))
            {
                lblSuccess.ForeColor = Color.LightGreen;
                lblSuccess.Text = "Withdrawal successful";
            }
            else
            {
                lblSuccess.ForeColor = Color.IndianRed;
                lblSuccess.Text = "Withdrawal failed";
            }
            Controls.Add(lblSuccess);
            tmrSuccess.Stop();
            tmrSuccess.Start();

        }

        /**
         * Method to remove success label
         */
        private void hideSuccessLabel(Object sender, EventArgs e)
        {
            tmrSuccess.Stop();
            Controls.Remove(lblSuccess);
        }

        // For threading since constructor cannot be called.

    }
}
