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
    public partial class ATM_form : Form
    {
        private Account[] accounts_ref;
        private int account;
        private bool isAccountNoValid;
        private int attempts;

        public ATM_form(Account[] account)
        {
            this.accounts_ref = account;
            this.account = -1;
            this.isAccountNoValid = false;
            this.attempts = 0;

            InitializeComponent();
            this.Text = "ATM";
            input_lbl.Text = "Account No: ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {
            input.AppendText("0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            input.AppendText("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            input.AppendText("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            input.AppendText("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            input.AppendText("4");
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            input.AppendText("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            input.AppendText("6");
        }
        
        private void button7_Click(object sender, EventArgs e)
        {
            input.AppendText("7");
        }
        
        private void button8_Click(object sender, EventArgs e)
        {
            input.AppendText("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            input.AppendText("9");
        }

        private void buttonClr_Click(object sender, EventArgs e)
        {
            input.Clear();
        }

        private void output_Click(object sender, EventArgs e)
        {

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {           
            if (IsDigitsOnly(input.Text) && isAccountNoValid == false)
            {
                if (input.Text.Length != 6)
                {
                    System.Windows.Forms.MessageBox.Show("Please enter a 6 digit (ie. 123456) account number");
                    return;
                }
                isAccountNoValid = checkAccountNumber();
            }
            else if (IsDigitsOnly(input.Text) && isAccountNoValid == true)
            {
                if (input.Text.Length != 4)
                {
                    System.Windows.Forms.MessageBox.Show("Please enter a 4 digit (ie. 1234) PIN");
                    return;
                }

                if (attempts != 3)
                {
                    if (!accounts_ref[account].checkPin(Int32.Parse(input.Text)))
                    {
                        attempts++;
                    }
                    else
                    {
                        Banking_form bankObj = new Banking_form(ref accounts_ref[account]);
                        bankObj.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("All attempts are invalid, temporarily locking system down...");
                    attempts = 0;
                    isAccountNoValid = false;
                    input_lbl.Text = "Account No: ";
                    input.Clear();
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Account number must only contain digits");
                return;
            }
        }

        // Helper functions
        private bool checkAccountNumber()
        {
            int accountNum = Int32.Parse(input.Text);
            for (int i=0; i<accounts_ref.GetLength(0); i++)
            {
                if(accounts_ref[i].getAccountNum() == accountNum)
                {
                    input_lbl.Text = "PIN:";
                    account = i;
                    input.Clear();
                    return true;
                }
            }
            return false;
        }
        private bool IsDigitsOnly(string text) // Check if string contains only digits - https://stackoverflow.com/questions/7461080/fastest-way-to-check-if-string-contains-only-digits-in-c-sharp - 22/03/2022
        {
            foreach (char chr in text)
            {
                if (chr < '0' || chr > '9')
                    return false;
            }

            return true;
        }
    }
}
