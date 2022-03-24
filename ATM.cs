using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

/**
 * AC22005 Assignment 2 Group 3
 * Ross Coombs: 2410466
 * Daniel Ferrier: 2413440
 * Kamil Krauze: 2414951
 */

namespace ATM_Team3
{
    public partial class ATM_form : Form
    {
        private Account[] accounts_ref_arr;
        private int account;
        private bool isAccountNoValid;
        private int attempts;
        private Banking_form bankObj;
        
        /**
         * Contructor method for ATM form
         */
        public ATM_form(Account[] account)
        {            
            this.accounts_ref_arr = account;
            this.account = -1;
            this.isAccountNoValid = false;
            this.attempts = 0;
            
            InitializeComponent();
            this.Text = "ATM";
            input_lbl.Text = "Account No: ";
        }

        /**
         * Method for button0 functionality
         */
        private void button0_Click(object sender, EventArgs e)
        {
            input.AppendText("0");
        }
        
        /**
         * Method for button1 functionality
         */
        private void button1_Click(object sender, EventArgs e)
        {
            input.AppendText("1");
        }
        
        /**
         * Method for button2 functionality
         */
        private void button2_Click(object sender, EventArgs e)
        {
            input.AppendText("2");
        }
        
        /**
         * Method for button3 functionality
         */
        private void button3_Click(object sender, EventArgs e)
        {
            input.AppendText("3");
        }
        
        /**
         * Method for button4 functionality
         */
        private void button4_Click(object sender, EventArgs e)
        {
            input.AppendText("4");
        }
        
        /**
         * Method for button5 functionality
         */
        private void button5_Click(object sender, EventArgs e)
        {
            input.AppendText("5");
        }
        
        /**
         * Method for button6 functionality
         */
        private void button6_Click(object sender, EventArgs e)
        {
            input.AppendText("6");
        }
        
        /**
         * Method for button7 functionality
         */
        private void button7_Click(object sender, EventArgs e)
        {
            input.AppendText("7");
        }
        
        /**
         * Method for button8 functionality
         */
        private void button8_Click(object sender, EventArgs e)
        {
            input.AppendText("8");
        }
        
        /**
         * Method for button9 functionality
         */
        private void button9_Click(object sender, EventArgs e)
        {
            input.AppendText("9");
        }
        
        /**
         * Method for clear button functionality
         */
        private void buttonClr_Click(object sender, EventArgs e)
        {
            input.Clear();
        }
        
        /**
         * Method for enter button functionality
         */
        private void buttonEnter_Click(object sender, EventArgs e)
        {           
            //check if account number is valid
            if (IsDigitsOnly(input.Text) && isAccountNoValid == false)
            {
                //check length
                if (input.Text.Length != 6)
                {
                    //display error message
                    MessageBox.Show("Please enter a 6 digit (ie. 123456) account number");
                    return;
                }
                //check if account number is real
                isAccountNoValid = checkAccountNumber();
            }
            //check if valid pin number
            else if (IsDigitsOnly(input.Text) && isAccountNoValid == true)
            {
                //check length
                if (input.Text.Length != 4)
                {
                    //display error message
                    MessageBox.Show("Please enter a 4 digit (ie. 1234) PIN");
                    return;
                }
                //if not wrong 3 times...
                if (attempts != 2)
                {
                    if (!accounts_ref_arr[account].checkPin(Int32.Parse(input.Text)))
                    {
                        //increase attempts
                        attempts++;
                    }
                    else
                    {
                        //create new thread for account
                        Thread account_t;
                        bankObj = new Banking_form(accounts_ref_arr[account]);
                        writeLog("Accessing account " + accounts_ref_arr[account].getAccountNum());
                        account_t = new Thread(runBankForm);
                        account_t.Start();
                        input.Clear();
                        //change label
                        input_lbl.Text = "Account No: ";
                        isAccountNoValid = false;
                    }
                }
                else
                {
                    //if too many attempts then shut down
                    MessageBox.Show("All attempts are invalid, temporarily locking system down...");
                    writeLog("Failed input correct PIN for account " + accounts_ref_arr[account].getAccountNum());
                    attempts = 0;
                    isAccountNoValid = false;
                    input_lbl.Text = "Account No: ";
                    input.Clear();
                    Thread.Sleep(3000);
                }
            }
            else
            {
                //display error message
                MessageBox.Show("Account number must only contain digits");
                return;
            }
        }

        // Functions for thread constructors
        private void runBankForm() // Function to run on thread
        {
            bankObj.ShowDialog();
        }

        // Helper functions
        
        /**
         * Method to check if account number if valid
         */
        private bool checkAccountNumber()
        {
            int accountNum = Int32.Parse(input.Text);
            for (int i=0; i< accounts_ref_arr.Length; i++)
            {
                if(accounts_ref_arr[i].getAccountNum() == accountNum)
                {
                    input_lbl.Text = "PIN:";
                    account = i;
                    input.Clear();
                    return true;
                }
            }
            return false;
        }        
        
        /**
         * Method to check if input is numbers only
         */
        private bool IsDigitsOnly(string text) // Check if string contains only digits - https://stackoverflow.com/questions/7461080/fastest-way-to-check-if-string-contains-only-digits-in-c-sharp - 22/03/2022
        {
            foreach (char chr in text)
            {
                if (chr < '0' || chr > '9')
                    return false;
            }

            return true;
        }

        // Writes events to a log file at specific file path
        private void writeLog(string message)
        {
            string fp = @"..\..\logs\log.txt";

            if(!File.Exists(fp))
            {
                // Create new file and write message
                using (StreamWriter sw = File.CreateText(fp))
                {
                    sw.WriteLine(message);
                    sw.Close();
                }
            }
            else
            {
                // Append message to existing file
                using (StreamWriter sw = File.AppendText(fp))
                {
                    sw.WriteLine(message);
                    sw.Close();
                }
            }
        }
    }
}
