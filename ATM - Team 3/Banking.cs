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
        Account accountTest;
        Label lblBalance;
        Button[] btnWithdrawAmounts;

        public Banking_form()
        {
            accountTest = new Account(300, 1111, 111111);
            InitializeComponent();

            lblBalance = new Label();
            lblBalance.Size = new Size(200, 50);
            lblBalance.Location = new Point(168, 63);
            lblBalance.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblBalance.ForeColor = SystemColors.ControlLight;
            lblBalance.Location = new Point(168, 63);
            lblBalance.Text = accountTest.getBalance().ToString();

            btnWithdrawAmounts = new Button[3];

            int buttonHeight = 63;

            for (int i = 0; i < btnWithdrawAmounts.Length; i++)
            {
                btnWithdrawAmounts[i] = new Button();
                
                btnWithdrawAmounts[i].BackColor = Color.White;
                btnWithdrawAmounts[i].FlatAppearance.MouseDownBackColor = Color.Gray;
                btnWithdrawAmounts[i].FlatAppearance.MouseOverBackColor = Color.Silver;
                btnWithdrawAmounts[i].FlatStyle = FlatStyle.Flat;
                btnWithdrawAmounts[i].Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
                btnWithdrawAmounts[i].Location = new Point(168, buttonHeight);
                btnWithdrawAmounts[i].Size = new Size(150, 50);
                btnWithdrawAmounts[i].Text = "amount" + i.ToString();
                //btnWithdrawAmounts[i].Click += new EventHandler();
                buttonHeight += 56;
            }
        }

        private void btnViewBalance_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < btnWithdrawAmounts.Length; i++)
            {
                Controls.Remove(btnWithdrawAmounts[i]);
            }
            Controls.Add(lblBalance);
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            Controls.Remove(lblBalance);
            for (int i = 0; i < btnWithdrawAmounts.Length; i++)
            {
                Controls.Add(btnWithdrawAmounts[i]);
            }
        }
    }
}
