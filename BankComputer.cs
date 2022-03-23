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
        private int threadCount;

        public BankComputer_form()
        {
            threadCount = 0;

            // Initialize accounts
            account[0] = new Account(300, 1111, 111111);
            account[1] = new Account(750, 2222, 222222);
            account[2] = new Account(3000, 3333, 333333);

            InitializeComponent();
            title_lbl.Location = new Point(Width/3, 10);

            initDataGrid();
        }

        // Initialized data grid with values from account
        private void initDataGrid()
        {
            for(int i=0; i<account.Length; i++)
            {
                accountDataGrid.Rows.Add
                    (
                        account[i].getAccountNum().ToString(),
                        account[i].getBalance().ToString(),
                        "0"
                    );
            }
        }

        private void startATM_buttonClick(object sender, EventArgs e)
        {
            Thread atm_thread = new Thread(showForm);
            atm = new ATM_form(account);
            atm_thread.Name = "ATM " + threadCount;
            atm_thread.Start();
            eventLog_lstBox.Items.Add(atm_thread.Name + " is Running");
            Thread.Sleep(1500);
        }

        //Helper function to show form for when the thread starts
        private void showForm()
        {
            threadCount++;
            atm.ShowDialog();
        }
    }
}
