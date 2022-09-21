namespace AccountsApp
{
    partial class Form1
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
            this.grbDetails = new System.Windows.Forms.GroupBox();
            this.grbType = new System.Windows.Forms.GroupBox();
            this.rbtnSaving = new System.Windows.Forms.RadioButton();
            this.rbtnChecking = new System.Windows.Forms.RadioButton();
            this.lblInterest = new System.Windows.Forms.Label();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.lblWithdraw = new System.Windows.Forms.Label();
            this.txtWithdraw = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.lblAccountNo = new System.Windows.Forms.Label();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grbDetails.SuspendLayout();
            this.grbType.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDetails
            // 
            this.grbDetails.Controls.Add(this.grbType);
            this.grbDetails.Controls.Add(this.lblInterest);
            this.grbDetails.Controls.Add(this.txtInterest);
            this.grbDetails.Controls.Add(this.lblWithdraw);
            this.grbDetails.Controls.Add(this.txtWithdraw);
            this.grbDetails.Controls.Add(this.lblBalance);
            this.grbDetails.Controls.Add(this.txtBalance);
            this.grbDetails.Controls.Add(this.lblClient);
            this.grbDetails.Controls.Add(this.txtClient);
            this.grbDetails.Controls.Add(this.lblAccountNo);
            this.grbDetails.Controls.Add(this.txtAccountNo);
            this.grbDetails.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.grbDetails.Location = new System.Drawing.Point(32, 35);
            this.grbDetails.Name = "grbDetails";
            this.grbDetails.Size = new System.Drawing.Size(794, 430);
            this.grbDetails.TabIndex = 0;
            this.grbDetails.TabStop = false;
            this.grbDetails.Text = "Account Details";
            this.grbDetails.Enter += new System.EventHandler(this.grbDetails_Enter);
            // 
            // grbType
            // 
            this.grbType.Controls.Add(this.rbtnSaving);
            this.grbType.Controls.Add(this.rbtnChecking);
            this.grbType.Location = new System.Drawing.Point(514, 65);
            this.grbType.Name = "grbType";
            this.grbType.Size = new System.Drawing.Size(250, 142);
            this.grbType.TabIndex = 10;
            this.grbType.TabStop = false;
            this.grbType.Text = "Type of Account";
            // 
            // rbtnSaving
            // 
            this.rbtnSaving.AutoSize = true;
            this.rbtnSaving.Location = new System.Drawing.Point(33, 97);
            this.rbtnSaving.Name = "rbtnSaving";
            this.rbtnSaving.Size = new System.Drawing.Size(73, 19);
            this.rbtnSaving.TabIndex = 1;
            this.rbtnSaving.TabStop = true;
            this.rbtnSaving.Text = "Saving";
            this.rbtnSaving.UseVisualStyleBackColor = true;
            this.rbtnSaving.CheckedChanged += new System.EventHandler(this.rbtnSaving_CheckedChanged);
            // 
            // rbtnChecking
            // 
            this.rbtnChecking.AutoSize = true;
            this.rbtnChecking.Location = new System.Drawing.Point(33, 52);
            this.rbtnChecking.Name = "rbtnChecking";
            this.rbtnChecking.Size = new System.Drawing.Size(88, 19);
            this.rbtnChecking.TabIndex = 0;
            this.rbtnChecking.TabStop = true;
            this.rbtnChecking.Text = "Checking";
            this.rbtnChecking.UseVisualStyleBackColor = true;
            this.rbtnChecking.CheckedChanged += new System.EventHandler(this.rbtnChecking_CheckedChanged);
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Location = new System.Drawing.Point(61, 361);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(99, 15);
            this.lblInterest.TabIndex = 9;
            this.lblInterest.Text = "Interest Rate :";
            this.lblInterest.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtInterest
            // 
            this.txtInterest.Location = new System.Drawing.Point(182, 357);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(179, 25);
            this.txtInterest.TabIndex = 8;
            this.txtInterest.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblWithdraw
            // 
            this.lblWithdraw.AutoSize = true;
            this.lblWithdraw.Location = new System.Drawing.Point(13, 284);
            this.lblWithdraw.Name = "lblWithdraw";
            this.lblWithdraw.Size = new System.Drawing.Size(147, 15);
            this.lblWithdraw.TabIndex = 7;
            this.lblWithdraw.Text = "Daily Withdraw Limit :";
            // 
            // txtWithdraw
            // 
            this.txtWithdraw.Location = new System.Drawing.Point(182, 281);
            this.txtWithdraw.Name = "txtWithdraw";
            this.txtWithdraw.Size = new System.Drawing.Size(179, 25);
            this.txtWithdraw.TabIndex = 6;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(90, 207);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(70, 15);
            this.lblBalance.TabIndex = 5;
            this.lblBalance.Text = "Balance :";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(182, 207);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(179, 25);
            this.txtBalance.TabIndex = 4;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(66, 130);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(94, 15);
            this.lblClient.TabIndex = 3;
            this.lblClient.Text = "Client Name :";
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(182, 127);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(295, 25);
            this.txtClient.TabIndex = 2;
            // 
            // lblAccountNo
            // 
            this.lblAccountNo.AutoSize = true;
            this.lblAccountNo.Location = new System.Drawing.Point(36, 62);
            this.lblAccountNo.Name = "lblAccountNo";
            this.lblAccountNo.Size = new System.Drawing.Size(124, 15);
            this.lblAccountNo.TabIndex = 1;
            this.lblAccountNo.Text = "Account Number :";
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Location = new System.Drawing.Point(182, 56);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(179, 25);
            this.txtAccountNo.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCreate.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCreate.Location = new System.Drawing.Point(630, 484);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(195, 45);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create Account";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSearch.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.Location = new System.Drawing.Point(432, 489);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(169, 39);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 543);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.grbDetails);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbDetails.ResumeLayout(false);
            this.grbDetails.PerformLayout();
            this.grbType.ResumeLayout(false);
            this.grbType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDetails;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.Label lblWithdraw;
        private System.Windows.Forms.TextBox txtWithdraw;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Label lblAccountNo;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.GroupBox grbType;
        private System.Windows.Forms.RadioButton rbtnSaving;
        private System.Windows.Forms.RadioButton rbtnChecking;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnSearch;
    }
}

