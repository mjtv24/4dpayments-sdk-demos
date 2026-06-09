namespace DPayments.Demos
{
  partial class bankstatementDemo
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bankstatementDemo));
      this.lblNotice = new System.Windows.Forms.Label();
      this.Label11 = new System.Windows.Forms.Label();
      this.btnRead = new System.Windows.Forms.Button();
      this.GroupBox2 = new System.Windows.Forms.GroupBox();
      this.txtFileName = new System.Windows.Forms.TextBox();
      this.lblAccountType = new System.Windows.Forms.Label();
      this.lblBankId = new System.Windows.Forms.Label();
      this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
      this.lblStartDate = new System.Windows.Forms.Label();
      this.bGetStatement = new System.Windows.Forms.Button();
      this.txtAccountNumber = new System.Windows.Forms.TextBox();
      this.gbAccount = new System.Windows.Forms.GroupBox();
      this.cmbBank = new System.Windows.Forms.ComboBox();
      this.lblBank = new System.Windows.Forms.Label();
      this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
      this.lblEndDate = new System.Windows.Forms.Label();
      this.txtFIId = new System.Windows.Forms.TextBox();
      this.Label5 = new System.Windows.Forms.Label();
      this.txtFIOrganization = new System.Windows.Forms.TextBox();
      this.Label4 = new System.Windows.Forms.Label();
      this.txtURL = new System.Windows.Forms.TextBox();
      this.Label1 = new System.Windows.Forms.Label();
      this.txtUserId = new System.Windows.Forms.TextBox();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.lblPassword = new System.Windows.Forms.Label();
      this.lblUserId = new System.Windows.Forms.Label();
      this.lblAccountNumber = new System.Windows.Forms.Label();
      this.txtBankId = new System.Windows.Forms.TextBox();
      this.cmbAccountType = new System.Windows.Forms.ComboBox();
      this.bankstatement1 = new DPayments.InEBank.Bankstatement(this.components);
      this.GroupBox2.SuspendLayout();
      this.gbAccount.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblNotice
      // 
      this.lblNotice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.lblNotice.ForeColor = System.Drawing.SystemColors.Highlight;
      this.lblNotice.Location = new System.Drawing.Point(8, 9);
      this.lblNotice.Name = "lblNotice";
      this.lblNotice.Size = new System.Drawing.Size(545, 62);
      this.lblNotice.TabIndex = 2;
      this.lblNotice.Text = resources.GetString("lblNotice.Text");
      // 
      // Label11
      // 
      this.Label11.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label11.Location = new System.Drawing.Point(110, 30);
      this.Label11.Name = "Label11";
      this.Label11.Size = new System.Drawing.Size(64, 23);
      this.Label11.TabIndex = 2;
      this.Label11.Text = "File Name:";
      this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // btnRead
      // 
      this.btnRead.ForeColor = System.Drawing.SystemColors.ControlText;
      this.btnRead.Location = new System.Drawing.Point(359, 30);
      this.btnRead.Name = "btnRead";
      this.btnRead.Size = new System.Drawing.Size(152, 23);
      this.btnRead.TabIndex = 1;
      this.btnRead.Text = "Read OFX File";
      this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
      // 
      // GroupBox2
      // 
      this.GroupBox2.Controls.Add(this.Label11);
      this.GroupBox2.Controls.Add(this.btnRead);
      this.GroupBox2.Controls.Add(this.txtFileName);
      this.GroupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
      this.GroupBox2.Location = new System.Drawing.Point(8, 435);
      this.GroupBox2.Name = "GroupBox2";
      this.GroupBox2.Size = new System.Drawing.Size(544, 70);
      this.GroupBox2.TabIndex = 1;
      this.GroupBox2.TabStop = false;
      this.GroupBox2.Text = "Read From OFX File";
      // 
      // txtFileName
      // 
      this.txtFileName.Location = new System.Drawing.Point(174, 31);
      this.txtFileName.Name = "txtFileName";
      this.txtFileName.Size = new System.Drawing.Size(152, 20);
      this.txtFileName.TabIndex = 0;
      this.txtFileName.Text = "..\\..\\statement.txt";
      // 
      // lblAccountType
      // 
      this.lblAccountType.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblAccountType.Location = new System.Drawing.Point(75, 249);
      this.lblAccountType.Name = "lblAccountType";
      this.lblAccountType.Size = new System.Drawing.Size(99, 23);
      this.lblAccountType.TabIndex = 20;
      this.lblAccountType.Text = "Account Type:";
      this.lblAccountType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lblBankId
      // 
      this.lblBankId.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblBankId.Location = new System.Drawing.Point(75, 134);
      this.lblBankId.Name = "lblBankId";
      this.lblBankId.Size = new System.Drawing.Size(99, 23);
      this.lblBankId.TabIndex = 16;
      this.lblBankId.Text = "Bank Id:";
      this.lblBankId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // dtpStartDate
      // 
      this.dtpStartDate.CustomFormat = "MM/dd/yyyy HH:mm:ss";
      this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtpStartDate.Location = new System.Drawing.Point(174, 281);
      this.dtpStartDate.Name = "dtpStartDate";
      this.dtpStartDate.Size = new System.Drawing.Size(152, 20);
      this.dtpStartDate.TabIndex = 9;
      this.dtpStartDate.Value = new System.DateTime(2009, 5, 1, 0, 0, 0, 0);
      // 
      // lblStartDate
      // 
      this.lblStartDate.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblStartDate.Location = new System.Drawing.Point(75, 280);
      this.lblStartDate.Name = "lblStartDate";
      this.lblStartDate.Size = new System.Drawing.Size(99, 23);
      this.lblStartDate.TabIndex = 21;
      this.lblStartDate.Text = "Start Date:";
      this.lblStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // bGetStatement
      // 
      this.bGetStatement.ForeColor = System.Drawing.SystemColors.ControlText;
      this.bGetStatement.Location = new System.Drawing.Point(359, 309);
      this.bGetStatement.Name = "bGetStatement";
      this.bGetStatement.Size = new System.Drawing.Size(152, 23);
      this.bGetStatement.TabIndex = 11;
      this.bGetStatement.Text = "Get Statement";
      this.bGetStatement.Click += new System.EventHandler(this.bGetStatement_Click);
      // 
      // txtAccountNumber
      // 
      this.txtAccountNumber.Location = new System.Drawing.Point(174, 222);
      this.txtAccountNumber.Name = "txtAccountNumber";
      this.txtAccountNumber.Size = new System.Drawing.Size(152, 20);
      this.txtAccountNumber.TabIndex = 7;
      // 
      // gbAccount
      // 
      this.gbAccount.Controls.Add(this.cmbBank);
      this.gbAccount.Controls.Add(this.lblBank);
      this.gbAccount.Controls.Add(this.dtpEndDate);
      this.gbAccount.Controls.Add(this.lblEndDate);
      this.gbAccount.Controls.Add(this.txtFIId);
      this.gbAccount.Controls.Add(this.Label5);
      this.gbAccount.Controls.Add(this.txtFIOrganization);
      this.gbAccount.Controls.Add(this.Label4);
      this.gbAccount.Controls.Add(this.txtURL);
      this.gbAccount.Controls.Add(this.Label1);
      this.gbAccount.Controls.Add(this.dtpStartDate);
      this.gbAccount.Controls.Add(this.lblStartDate);
      this.gbAccount.Controls.Add(this.bGetStatement);
      this.gbAccount.Controls.Add(this.txtAccountNumber);
      this.gbAccount.Controls.Add(this.txtUserId);
      this.gbAccount.Controls.Add(this.txtPassword);
      this.gbAccount.Controls.Add(this.lblPassword);
      this.gbAccount.Controls.Add(this.lblUserId);
      this.gbAccount.Controls.Add(this.lblAccountNumber);
      this.gbAccount.Controls.Add(this.txtBankId);
      this.gbAccount.Controls.Add(this.cmbAccountType);
      this.gbAccount.Controls.Add(this.lblBankId);
      this.gbAccount.Controls.Add(this.lblAccountType);
      this.gbAccount.ForeColor = System.Drawing.SystemColors.Highlight;
      this.gbAccount.Location = new System.Drawing.Point(8, 74);
      this.gbAccount.Name = "gbAccount";
      this.gbAccount.Size = new System.Drawing.Size(544, 355);
      this.gbAccount.TabIndex = 0;
      this.gbAccount.TabStop = false;
      this.gbAccount.Text = "Connect Directly to OFX Server";
      // 
      // cmbBank
      // 
      this.cmbBank.Items.AddRange(new object[] {
            "Bank of America",
            "Bank One - JPMorgan Chase",
            "BB&T - Branch Banking and Trust Company",
            "JPMorgan Chase Bank",
            "Mellon Bank",
            "SunTrust",
            "Wachovia Bank",
            "Wells Fargo",
            "Zions Bank",
            "(YOUR BANK NAME)"});
      this.cmbBank.Location = new System.Drawing.Point(174, 24);
      this.cmbBank.Name = "cmbBank";
      this.cmbBank.Size = new System.Drawing.Size(152, 21);
      this.cmbBank.TabIndex = 0;
      this.cmbBank.Text = "Wachovia";
      this.cmbBank.SelectedIndexChanged += new System.EventHandler(this.cmbBank_SelectedIndexChanged);
      // 
      // lblBank
      // 
      this.lblBank.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblBank.Location = new System.Drawing.Point(57, 22);
      this.lblBank.Name = "lblBank";
      this.lblBank.Size = new System.Drawing.Size(117, 23);
      this.lblBank.TabIndex = 12;
      this.lblBank.Text = "Bank Common Name:";
      this.lblBank.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // dtpEndDate
      // 
      this.dtpEndDate.CustomFormat = "MM/dd/yyyy HH:mm:ss";
      this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtpEndDate.Location = new System.Drawing.Point(174, 309);
      this.dtpEndDate.Name = "dtpEndDate";
      this.dtpEndDate.Size = new System.Drawing.Size(152, 20);
      this.dtpEndDate.TabIndex = 10;
      this.dtpEndDate.Value = new System.DateTime(2009, 9, 1, 0, 0, 0, 0);
      // 
      // lblEndDate
      // 
      this.lblEndDate.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblEndDate.Location = new System.Drawing.Point(75, 308);
      this.lblEndDate.Name = "lblEndDate";
      this.lblEndDate.Size = new System.Drawing.Size(99, 23);
      this.lblEndDate.TabIndex = 22;
      this.lblEndDate.Text = "End Date:";
      this.lblEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtFIId
      // 
      this.txtFIId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.txtFIId.Location = new System.Drawing.Point(174, 108);
      this.txtFIId.Name = "txtFIId";
      this.txtFIId.Size = new System.Drawing.Size(152, 20);
      this.txtFIId.TabIndex = 3;
      this.txtFIId.Text = "4309";
      // 
      // Label5
      // 
      this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label5.Location = new System.Drawing.Point(75, 108);
      this.Label5.Name = "Label5";
      this.Label5.Size = new System.Drawing.Size(99, 16);
      this.Label5.TabIndex = 15;
      this.Label5.Text = "FI ID:";
      this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtFIOrganization
      // 
      this.txtFIOrganization.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.txtFIOrganization.Location = new System.Drawing.Point(174, 80);
      this.txtFIOrganization.Name = "txtFIOrganization";
      this.txtFIOrganization.Size = new System.Drawing.Size(152, 20);
      this.txtFIOrganization.TabIndex = 2;
      this.txtFIOrganization.Text = "Wachovia";
      // 
      // Label4
      // 
      this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label4.Location = new System.Drawing.Point(67, 80);
      this.Label4.Name = "Label4";
      this.Label4.Size = new System.Drawing.Size(107, 16);
      this.Label4.TabIndex = 14;
      this.Label4.Text = "FI Organization:";
      this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtURL
      // 
      this.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.txtURL.Location = new System.Drawing.Point(174, 52);
      this.txtURL.Name = "txtURL";
      this.txtURL.Size = new System.Drawing.Size(364, 20);
      this.txtURL.TabIndex = 1;
      this.txtURL.Text = "https://pfmpw.wachovia.com/cgi-forte/fortecgi?servicename=ofx&pagename=PFM";
      // 
      // Label1
      // 
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.Location = new System.Drawing.Point(78, 53);
      this.Label1.Name = "Label1";
      this.Label1.Size = new System.Drawing.Size(96, 19);
      this.Label1.TabIndex = 13;
      this.Label1.Text = "FI URL:";
      this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtUserId
      // 
      this.txtUserId.Location = new System.Drawing.Point(174, 165);
      this.txtUserId.Name = "txtUserId";
      this.txtUserId.Size = new System.Drawing.Size(152, 20);
      this.txtUserId.TabIndex = 5;
      // 
      // txtPassword
      // 
      this.txtPassword.Location = new System.Drawing.Point(174, 193);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.PasswordChar = '*';
      this.txtPassword.Size = new System.Drawing.Size(152, 20);
      this.txtPassword.TabIndex = 6;
      // 
      // lblPassword
      // 
      this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblPassword.Location = new System.Drawing.Point(75, 191);
      this.lblPassword.Name = "lblPassword";
      this.lblPassword.Size = new System.Drawing.Size(99, 23);
      this.lblPassword.TabIndex = 18;
      this.lblPassword.Text = "Password:";
      this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lblUserId
      // 
      this.lblUserId.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblUserId.Location = new System.Drawing.Point(75, 163);
      this.lblUserId.Name = "lblUserId";
      this.lblUserId.Size = new System.Drawing.Size(99, 23);
      this.lblUserId.TabIndex = 17;
      this.lblUserId.Text = "User Id:";
      this.lblUserId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lblAccountNumber
      // 
      this.lblAccountNumber.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblAccountNumber.Location = new System.Drawing.Point(75, 220);
      this.lblAccountNumber.Name = "lblAccountNumber";
      this.lblAccountNumber.Size = new System.Drawing.Size(99, 23);
      this.lblAccountNumber.TabIndex = 19;
      this.lblAccountNumber.Text = "Account Number:";
      this.lblAccountNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtBankId
      // 
      this.txtBankId.Location = new System.Drawing.Point(174, 136);
      this.txtBankId.Name = "txtBankId";
      this.txtBankId.Size = new System.Drawing.Size(152, 20);
      this.txtBankId.TabIndex = 4;
      this.txtBankId.Text = "053000219";
      // 
      // cmbAccountType
      // 
      this.cmbAccountType.Items.AddRange(new object[] {
            "Checking",
            "Savings",
            "Money Market",
            "Line of Credit"});
      this.cmbAccountType.Location = new System.Drawing.Point(174, 251);
      this.cmbAccountType.Name = "cmbAccountType";
      this.cmbAccountType.Size = new System.Drawing.Size(152, 21);
      this.cmbAccountType.TabIndex = 8;
      // 
      // bankstatementDemo
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(561, 515);
      this.Controls.Add(this.lblNotice);
      this.Controls.Add(this.GroupBox2);
      this.Controls.Add(this.gbAccount);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.Name = "bankstatementDemo";
      this.Text = "Bank Statement Demo";
      this.Load += new System.EventHandler(this.bankstatementDemo_Load);
      this.GroupBox2.ResumeLayout(false);
      this.GroupBox2.PerformLayout();
      this.gbAccount.ResumeLayout(false);
      this.gbAccount.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label lblNotice;
    internal System.Windows.Forms.Label Label11;
    internal System.Windows.Forms.Button btnRead;
    internal System.Windows.Forms.GroupBox GroupBox2;
    internal System.Windows.Forms.TextBox txtFileName;
    private System.Windows.Forms.Label lblAccountType;
    private System.Windows.Forms.Label lblBankId;
    private System.Windows.Forms.DateTimePicker dtpStartDate;
    private System.Windows.Forms.Label lblStartDate;
    private System.Windows.Forms.Button bGetStatement;
    private System.Windows.Forms.TextBox txtAccountNumber;
    private System.Windows.Forms.TextBox txtUserId;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Label lblPassword;
    private System.Windows.Forms.Label lblUserId;
    private System.Windows.Forms.Label lblAccountNumber;
    private System.Windows.Forms.TextBox txtBankId;
    private System.Windows.Forms.ComboBox cmbAccountType;
    internal System.Windows.Forms.TextBox txtFIId;
    internal System.Windows.Forms.Label Label5;
    internal System.Windows.Forms.TextBox txtFIOrganization;
    internal System.Windows.Forms.Label Label4;
    internal System.Windows.Forms.TextBox txtURL;
    internal System.Windows.Forms.Label Label1;
    private System.Windows.Forms.DateTimePicker dtpEndDate;
    private System.Windows.Forms.Label lblEndDate;
    private DPayments.InEBank.Bankstatement bankstatement1;
    internal System.Windows.Forms.GroupBox gbAccount;
    internal System.Windows.Forms.ComboBox cmbBank;
    internal System.Windows.Forms.Label lblBank;
  }
}

