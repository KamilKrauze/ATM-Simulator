using System;
using System.IO;
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
    public partial class BankComputer_form : Form
    {

        private ATM_form atm;
        private Account[] account = new Account[3];

        // Initializes variables
        public BankComputer_form()
        {
            // Initialize accounts
            account[0] = new Account(300, 1111, 111111);
            account[1] = new Account(750, 2222, 222222);
            account[2] = new Account(3000, 3333, 333333);

            InitializeComponent();
            title_lbl.Location = new Point(Width / 3, 10);

            InitializeDataGrid();
        }

        // Creates the ATM input panel for the user input the account number and PIN
        private void startATM_buttonClick(object sender, EventArgs e)
        {
            Thread atm_thread = new Thread(showForm);
            atm = new ATM_form(account);
            atm_thread.Start();
            Thread.Sleep(1500);
        }
        
        // Updates DataGrid on button press
        private void refresh_button_Click(object sender, EventArgs e)
        {
            updateDataGrid();
            updateListBox();
        }

        // When the form is focused/pressed on, an event fires this function to update the DataGrid
        private void BankComputer_Activate(object sender, System.EventArgs e)
        {
            updateDataGrid();
        }

        //Helper function to show form for when the thread starts
        private void showForm()
        {
            atm.ShowDialog();
        }

        // DataGrid helper functions
        // Initializes the data grid with values from account
        private void InitializeDataGrid()
        {
            for (int i = 0; i < account.Length; i++)
            {
                accountDataGrid.Rows.Add
                    (
                        account[i].getAccountNum().ToString(),
                        account[i].getBalance().ToString()
                    );
            }
        }

        // Updates the data grid to make sure with account balance is up-to-date
        private void updateDataGrid()
        {
            for (int i = 0; i < account.Length; i++)
            {
                accountDataGrid.Rows[i].Cells["AccountNo"].Value = account[i].getAccountNum().ToString();
                accountDataGrid.Rows[i].Cells["Balance"].Value = account[i].getBalance().ToString();
            }
        }

        // Update listbox with contents from log.txt
        private void updateListBox()
        {
            eventLog_listBox.Items.Clear();
            string fp = @"..\..\logs\log.txt";

            if (File.Exists(fp))
            {
                // Open the file to read from.
                using (StreamReader sr = File.OpenText(fp))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        eventLog_listBox.Items.Add(s);
                    }
                    sr.Close();
                }
            }
            else
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(fp))
                {
                    sw.WriteLine("");
                    sw.Close();
                }
            }
        }
    }
}
