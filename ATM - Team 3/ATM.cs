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


        public ATM_form()
        {
            accounts[0] = new Account(300, 1111, 111111);
            accounts[1] = new Account(750, 2222, 222222);
            accounts[2] = new Account(3000, 3333, 333333);

            InitializeComponent();
            this.Text = "ATM";
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
