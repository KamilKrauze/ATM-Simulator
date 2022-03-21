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
            if(input_lbl.Text == "")
            {
                // Dialog message
            }
            // TODO: Do other checks and update the label if valid.
        }
    }
}
