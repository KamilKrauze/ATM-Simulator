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

namespace ATM_Team3
{
    public partial class BankComputer_form : Form
    {
        private ATM_form atm;
        
        private Account[] account = new Account[3];

        private Thread atm_thread;

        public BankComputer_form()
        {
            atm_thread = new Thread(showForm); // Initializes thread.

            // Initialize accounts
            account[0] = new Account(300, 1111, 111111);
            account[1] = new Account(750, 2222, 222222);
            account[2] = new Account(3000, 3333, 333333);

            InitializeComponent();
            title_lbl.Location = new Point(Width/3, 10);

            InitializeDataGrid();
        }

        // Initializes the data grid with values from account
        private void InitializeDataGrid()
        {
            for(int i=0; i<account.Length; i++)
            {
                accountDataGrid.Rows.Add
                    (
                        account[i].getAccountNum().ToString(),
                        account[i].getBalance().ToString()
                    );
            }
        }

        private void updateDataGrid()
        {
            for (int i = 0; i < account.Length; i++)
            {
                accountDataGrid.Rows[i].Cells["AccountNo"].Value = account[i].getAccountNum().ToString();
                accountDataGrid.Rows[i].Cells["Balance"].Value = account[i].getBalance().ToString();
            }
        }

        private void startATM_buttonClick(object sender, EventArgs e)
        {
            atm = new ATM_form(account);
            atm_thread.Start();
            Thread.Sleep(1500);
        }

        private void BankComputer_Activate(object sender, System.EventArgs e)
        {
            Console.WriteLine("Thread Status: {0}", atm_thread.ThreadState);
            if (atm_thread.ThreadState == ThreadState.Stopped)
            {
                updateDataGrid();
            }
        }

        //Helper function to show form for when the thread starts
        private void showForm()
        {
            atm.ShowDialog();
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            updateDataGrid();
        }
    }
}
