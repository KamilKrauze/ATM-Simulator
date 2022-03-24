
namespace ATM_Simulator___Team_3__with_Data_Race_
{
    partial class Banking_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Banking_form));
            this.btnViewBalance = new System.Windows.Forms.Button();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewBalance
            // 
            this.btnViewBalance.BackColor = System.Drawing.Color.White;
            this.btnViewBalance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewBalance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnViewBalance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnViewBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewBalance.Font = new System.Drawing.Font("Consolas", 9F);
            this.btnViewBalance.Location = new System.Drawing.Point(10, 55);
            this.btnViewBalance.Name = "btnViewBalance";
            this.btnViewBalance.Size = new System.Drawing.Size(150, 50);
            this.btnViewBalance.TabIndex = 0;
            this.btnViewBalance.Text = "View balance";
            this.btnViewBalance.UseVisualStyleBackColor = false;
            this.btnViewBalance.Click += new System.EventHandler(this.btnViewBalance_Click);
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Font = new System.Drawing.Font("Consolas", 20.25F);
            this.lblPrompt.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPrompt.Location = new System.Drawing.Point(10, 8);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(375, 32);
            this.lblPrompt.TabIndex = 1;
            this.lblPrompt.Text = "Please select an option:";
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.Color.White;
            this.btnWithdraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWithdraw.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnWithdraw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdraw.Font = new System.Drawing.Font("Consolas", 9F);
            this.btnWithdraw.Location = new System.Drawing.Point(10, 110);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(150, 50);
            this.btnWithdraw.TabIndex = 2;
            this.btnWithdraw.Text = "Withdraw cash";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // Banking_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(393, 465);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.btnViewBalance);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Banking_form";
            this.Text = "Banking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewBalance;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.Button btnWithdraw;
    }
}