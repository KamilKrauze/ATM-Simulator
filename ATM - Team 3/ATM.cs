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
        private Account[] accounts = new Account[3];

        /**
         * contructor method for ATM form
         */
        public ATM_form()
        {
            accounts[0] = new Account(300, 1111, 111111);
            accounts[1] = new Account(750, 2222, 222222);
            accounts[2] = new Account(3000, 3333, 333333);

            InitializeComponent();
            this.Text = "ATM";
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
    }
}
