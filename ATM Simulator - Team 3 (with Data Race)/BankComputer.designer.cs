
namespace ATM_Simulator___Team_3__with_Data_Race_
{
    partial class BankComputer_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankComputer_form));
            this.title_lbl = new System.Windows.Forms.Label();
            this.StartATM_button = new System.Windows.Forms.Button();
            this.accountDataGrid = new System.Windows.Forms.DataGridView();
            this.AccountNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountView_lbl = new System.Windows.Forms.Label();
            this.refresh_button = new System.Windows.Forms.Button();
            this.eventLog_listBox = new System.Windows.Forms.ListBox();
            this.eventLog_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // title_lbl
            // 
            this.title_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Gill Sans MT", 22F, System.Drawing.FontStyle.Bold);
            this.title_lbl.ForeColor = System.Drawing.Color.White;
            this.title_lbl.Location = new System.Drawing.Point(323, 6);
            this.title_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(319, 42);
            this.title_lbl.TabIndex = 0;
            this.title_lbl.Text = "Bank Main Computer";
            this.title_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartATM_button
            // 
            this.StartATM_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartATM_button.BackColor = System.Drawing.Color.White;
            this.StartATM_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartATM_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartATM_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StartATM_button.FlatAppearance.BorderSize = 2;
            this.StartATM_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.StartATM_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.StartATM_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartATM_button.Location = new System.Drawing.Point(724, 71);
            this.StartATM_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartATM_button.Name = "StartATM_button";
            this.StartATM_button.Size = new System.Drawing.Size(167, 49);
            this.StartATM_button.TabIndex = 1;
            this.StartATM_button.Text = "Start ATM";
            this.StartATM_button.UseVisualStyleBackColor = false;
            this.StartATM_button.Click += new System.EventHandler(this.startATM_buttonClick);
            // 
            // accountDataGrid
            // 
            this.accountDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.accountDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountNo,
            this.Balance});
            this.accountDataGrid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.accountDataGrid.Location = new System.Drawing.Point(13, 71);
            this.accountDataGrid.Name = "accountDataGrid";
            this.accountDataGrid.RowHeadersWidth = 62;
            this.accountDataGrid.Size = new System.Drawing.Size(359, 354);
            this.accountDataGrid.TabIndex = 4;
            // 
            // AccountNo
            // 
            this.AccountNo.HeaderText = "Account Number";
            this.AccountNo.MinimumWidth = 8;
            this.AccountNo.Name = "AccountNo";
            this.AccountNo.ReadOnly = true;
            this.AccountNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AccountNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Balance
            // 
            this.Balance.HeaderText = "Account Balance";
            this.Balance.MinimumWidth = 8;
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            this.Balance.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Balance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // accountView_lbl
            // 
            this.accountView_lbl.AutoSize = true;
            this.accountView_lbl.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountView_lbl.ForeColor = System.Drawing.Color.White;
            this.accountView_lbl.Location = new System.Drawing.Point(13, 52);
            this.accountView_lbl.Name = "accountView_lbl";
            this.accountView_lbl.Size = new System.Drawing.Size(101, 18);
            this.accountView_lbl.TabIndex = 5;
            this.accountView_lbl.Text = "Accounts View";
            // 
            // refresh_button
            // 
            this.refresh_button.BackColor = System.Drawing.Color.White;
            this.refresh_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refresh_button.BackgroundImage")));
            this.refresh_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refresh_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.refresh_button.FlatAppearance.BorderSize = 2;
            this.refresh_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.refresh_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.refresh_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh_button.Location = new System.Drawing.Point(807, 344);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(83, 81);
            this.refresh_button.TabIndex = 6;
            this.refresh_button.UseVisualStyleBackColor = false;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // eventLog_listBox
            // 
            this.eventLog_listBox.FormattingEnabled = true;
            this.eventLog_listBox.Location = new System.Drawing.Point(377, 71);
            this.eventLog_listBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eventLog_listBox.Name = "eventLog_listBox";
            this.eventLog_listBox.Size = new System.Drawing.Size(323, 355);
            this.eventLog_listBox.TabIndex = 7;
            // 
            // eventLog_label
            // 
            this.eventLog_label.AutoSize = true;
            this.eventLog_label.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventLog_label.ForeColor = System.Drawing.Color.White;
            this.eventLog_label.Location = new System.Drawing.Point(374, 52);
            this.eventLog_label.Name = "eventLog_label";
            this.eventLog_label.Size = new System.Drawing.Size(70, 18);
            this.eventLog_label.TabIndex = 8;
            this.eventLog_label.Text = "Event Log";
            // 
            // BankComputer_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(913, 445);
            this.Controls.Add(this.eventLog_label);
            this.Controls.Add(this.eventLog_listBox);
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.accountView_lbl);
            this.Controls.Add(this.accountDataGrid);
            this.Controls.Add(this.StartATM_button);
            this.Controls.Add(this.title_lbl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(933, 484);
            this.MinimumSize = new System.Drawing.Size(623, 484);
            this.Name = "BankComputer_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Main Computer";
            this.Activated += new System.EventHandler(this.BankComputer_Activate);
            ((System.ComponentModel.ISupportInitialize)(this.accountDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Button StartATM_button;
        private System.Windows.Forms.DataGridView accountDataGrid;
        private System.Windows.Forms.Label accountView_lbl;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.ListBox eventLog_listBox;
        private System.Windows.Forms.Label eventLog_label;
    }
}