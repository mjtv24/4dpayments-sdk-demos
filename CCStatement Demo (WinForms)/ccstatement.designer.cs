namespace DPayments.Demos
{
  partial class ccstatementDemo
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ccstatementDemo));
      this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
      this.lblNotice = new System.Windows.Forms.Label();
      this.gbAccount = new System.Windows.Forms.GroupBox();
      this.cmbBank = new System.Windows.Forms.ComboBox();
      this.lblBank = new System.Windows.Forms.Label();
      this.lblEndDate = new System.Windows.Forms.Label();
      this.txtFIId = new System.Windows.Forms.TextBox();
      this.Label5 = new System.Windows.Forms.Label();
      this.txtFIOrganization = new System.Windows.Forms.TextBox();
      this.Label4 = new System.Windows.Forms.Label();
      this.txtURL = new System.Windows.Forms.TextBox();
      this.Label1 = new System.Windows.Forms.Label();
      this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
      this.lblStartDate = new System.Windows.Forms.Label();
      this.bGetStatement = new System.Windows.Forms.Button();
      this.txtCardNumber = new System.Windows.Forms.TextBox();
      this.txtUserId = new System.Windows.Forms.TextBox();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.lblPassword = new System.Windows.Forms.Label();
      this.lblUserId = new System.Windows.Forms.Label();
      this.lblAccountNumber = new System.Windows.Forms.Label();
      this.txtFileName = new System.Windows.Forms.TextBox();
      this.Label11 = new System.Windows.Forms.Label();
      this.btnRead = new System.Windows.Forms.Button();
      this.GroupBox2 = new System.Windows.Forms.GroupBox();
      this.ccstatement1 = new DPayments.InEBank.Ccstatement(this.components);
      this.gbAccount.SuspendLayout();
      this.GroupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // dtpEndDate
      // 
      this.dtpEndDate.CustomFormat = "MM/dd/yyyy HH:mm:ss";
      this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtpEndDate.Location = new System.Drawing.Point(174, 257);
      this.dtpEndDate.Name = "dtpEndDate";
      this.dtpEndDate.Size = new System.Drawing.Size(152, 20);
      this.dtpEndDate.TabIndex = 8;
      this.dtpEndDate.Value = new System.DateTime(2009, 9, 1, 0, 0, 0, 0);
      // 
      // lblNotice
      // 
      this.lblNotice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.lblNotice.ForeColor = System.Drawing.SystemColors.Highlight;
      this.lblNotice.Location = new System.Drawing.Point(9, 9);
      this.lblNotice.Name = "lblNotice";
      this.lblNotice.Size = new System.Drawing.Size(547, 58);
      this.lblNotice.TabIndex = 2;
      this.lblNotice.Text = resources.GetString("lblNotice.Text");
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
      this.gbAccount.Controls.Add(this.txtCardNumber);
      this.gbAccount.Controls.Add(this.txtUserId);
      this.gbAccount.Controls.Add(this.txtPassword);
      this.gbAccount.Controls.Add(this.lblPassword);
      this.gbAccount.Controls.Add(this.lblUserId);
      this.gbAccount.Controls.Add(this.lblAccountNumber);
      this.gbAccount.ForeColor = System.Drawing.SystemColors.Highlight;
      this.gbAccount.Location = new System.Drawing.Point(9, 79);
      this.gbAccount.Name = "gbAccount";
      this.gbAccount.Size = new System.Drawing.Size(544, 297);
      this.gbAccount.TabIndex = 0;
      this.gbAccount.TabStop = false;
      this.gbAccount.Text = "Connect Directly to OFX Server";
      // 
      // cmbBank
      // 
      this.cmbBank.Items.AddRange(new object[] {
            "American Express",
            "Bank of America",
            "Bank One - JPMorgan Chase",
            "BB&T - Branch Banking and Trust Company",
            "Chase (credit card)",
            "JPMorgan Chase Bank",
            "Mellon Bank",
            "SunTrust",
            "Wachovia Bank",
            "Wells Fargo",
            "Zions Bank"});
      this.cmbBank.Location = new System.Drawing.Point(174, 30);
      this.cmbBank.Name = "cmbBank";
      this.cmbBank.Size = new System.Drawing.Size(364, 21);
      this.cmbBank.TabIndex = 0;
      this.cmbBank.Text = "American Express";
      this.cmbBank.SelectedIndexChanged += new System.EventHandler(this.cmbBank_SelectedIndexChanged);
      // 
      // lblBank
      // 
      this.lblBank.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblBank.Location = new System.Drawing.Point(57, 28);
      this.lblBank.Name = "lblBank";
      this.lblBank.Size = new System.Drawing.Size(117, 23);
      this.lblBank.TabIndex = 10;
      this.lblBank.Text = "Bank Common Name:";
      this.lblBank.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lblEndDate
      // 
      this.lblEndDate.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblEndDate.Location = new System.Drawing.Point(75, 256);
      this.lblEndDate.Name = "lblEndDate";
      this.lblEndDate.Size = new System.Drawing.Size(99, 23);
      this.lblEndDate.TabIndex = 18;
      this.lblEndDate.Text = "End Date:";
      this.lblEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtFIId
      // 
      this.txtFIId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.txtFIId.Location = new System.Drawing.Point(174, 116);
      this.txtFIId.Name = "txtFIId";
      this.txtFIId.Size = new System.Drawing.Size(152, 20);
      this.txtFIId.TabIndex = 3;
      this.txtFIId.Text = "3101";
      // 
      // Label5
      // 
      this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label5.Location = new System.Drawing.Point(75, 116);
      this.Label5.Name = "Label5";
      this.Label5.Size = new System.Drawing.Size(99, 16);
      this.Label5.TabIndex = 13;
      this.Label5.Text = "FI ID:";
      this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtFIOrganization
      // 
      this.txtFIOrganization.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.txtFIOrganization.Location = new System.Drawing.Point(174, 88);
      this.txtFIOrganization.Name = "txtFIOrganization";
      this.txtFIOrganization.Size = new System.Drawing.Size(152, 20);
      this.txtFIOrganization.TabIndex = 2;
      this.txtFIOrganization.Text = "AMEX";
      // 
      // Label4
      // 
      this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label4.Location = new System.Drawing.Point(67, 88);
      this.Label4.Name = "Label4";
      this.Label4.Size = new System.Drawing.Size(107, 16);
      this.Label4.TabIndex = 12;
      this.Label4.Text = "FI Organization:";
      this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtURL
      // 
      this.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.txtURL.Location = new System.Drawing.Point(174, 60);
      this.txtURL.Name = "txtURL";
      this.txtURL.Size = new System.Drawing.Size(364, 20);
      this.txtURL.TabIndex = 1;
      this.txtURL.Text = "https://online.americanexpress.com/myca/ofxdl/desktop/desktopDownload.do?request_type=nl_ofxdownload";
      // 
      // Label1
      // 
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.Location = new System.Drawing.Point(78, 61);
      this.Label1.Name = "Label1";
      this.Label1.Size = new System.Drawing.Size(96, 19);
      this.Label1.TabIndex = 11;
      this.Label1.Text = "FI URL:";
      this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // dtpStartDate
      // 
      this.dtpStartDate.CustomFormat = "MM/dd/yyyy HH:mm:ss";
      this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtpStartDate.Location = new System.Drawing.Point(174, 229);
      this.dtpStartDate.Name = "dtpStartDate";
      this.dtpStartDate.Size = new System.Drawing.Size(152, 20);
      this.dtpStartDate.TabIndex = 7;
      this.dtpStartDate.Value = new System.DateTime(2009, 5, 1, 0, 0, 0, 0);
      // 
      // lblStartDate
      // 
      this.lblStartDate.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblStartDate.Location = new System.Drawing.Point(75, 228);
      this.lblStartDate.Name = "lblStartDate";
      this.lblStartDate.Size = new System.Drawing.Size(99, 23);
      this.lblStartDate.TabIndex = 17;
      this.lblStartDate.Text = "Start Date:";
      this.lblStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // bGetStatement
      // 
      this.bGetStatement.ForeColor = System.Drawing.SystemColors.ControlText;
      this.bGetStatement.Location = new System.Drawing.Point(365, 254);
      this.bGetStatement.Name = "bGetStatement";
      this.bGetStatement.Size = new System.Drawing.Size(152, 23);
      this.bGetStatement.TabIndex = 9;
      this.bGetStatement.Text = "Get Statement";
      this.bGetStatement.Click += new System.EventHandler(this.bGetStatement_Click);
      // 
      // txtCardNumber
      // 
      this.txtCardNumber.Location = new System.Drawing.Point(174, 201);
      this.txtCardNumber.Name = "txtCardNumber";
      this.txtCardNumber.Size = new System.Drawing.Size(152, 20);
      this.txtCardNumber.TabIndex = 6;
      // 
      // txtUserId
      // 
      this.txtUserId.Location = new System.Drawing.Point(174, 144);
      this.txtUserId.Name = "txtUserId";
      this.txtUserId.Size = new System.Drawing.Size(152, 20);
      this.txtUserId.TabIndex = 4;
      // 
      // txtPassword
      // 
      this.txtPassword.Location = new System.Drawing.Point(174, 172);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.PasswordChar = '*';
      this.txtPassword.Size = new System.Drawing.Size(152, 20);
      this.txtPassword.TabIndex = 5;
      // 
      // lblPassword
      // 
      this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblPassword.Location = new System.Drawing.Point(75, 170);
      this.lblPassword.Name = "lblPassword";
      this.lblPassword.Size = new System.Drawing.Size(99, 23);
      this.lblPassword.TabIndex = 15;
      this.lblPassword.Text = "Password:";
      this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lblUserId
      // 
      this.lblUserId.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblUserId.Location = new System.Drawing.Point(75, 142);
      this.lblUserId.Name = "lblUserId";
      this.lblUserId.Size = new System.Drawing.Size(99, 23);
      this.lblUserId.TabIndex = 14;
      this.lblUserId.Text = "User Id:";
      this.lblUserId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lblAccountNumber
      // 
      this.lblAccountNumber.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblAccountNumber.Location = new System.Drawing.Point(46, 199);
      this.lblAccountNumber.Name = "lblAccountNumber";
      this.lblAccountNumber.Size = new System.Drawing.Size(128, 23);
      this.lblAccountNumber.TabIndex = 16;
      this.lblAccountNumber.Text = "Credit Card Number:";
      this.lblAccountNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtFileName
      // 
      this.txtFileName.Location = new System.Drawing.Point(174, 28);
      this.txtFileName.Name = "txtFileName";
      this.txtFileName.Size = new System.Drawing.Size(152, 20);
      this.txtFileName.TabIndex = 0;
      this.txtFileName.Text = "..\\..\\statement.txt";
      // 
      // Label11
      // 
      this.Label11.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label11.Location = new System.Drawing.Point(110, 26);
      this.Label11.Name = "Label11";
      this.Label11.Size = new System.Drawing.Size(64, 23);
      this.Label11.TabIndex = 2;
      this.Label11.Text = "File Name:";
      this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // btnRead
      // 
      this.btnRead.ForeColor = System.Drawing.SystemColors.ControlText;
      this.btnRead.Location = new System.Drawing.Point(365, 25);
      this.btnRead.Name = "btnRead";
      this.btnRead.Size = new System.Drawing.Size(152, 23);
      this.btnRead.TabIndex = 1;
      this.btnRead.Text = "Read OFX File";
      this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
      // 
      // GroupBox2
      // 
      this.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.GroupBox2.Controls.Add(this.Label11);
      this.GroupBox2.Controls.Add(this.btnRead);
      this.GroupBox2.Controls.Add(this.txtFileName);
      this.GroupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
      this.GroupBox2.Location = new System.Drawing.Point(10, 392);
      this.GroupBox2.Name = "GroupBox2";
      this.GroupBox2.Size = new System.Drawing.Size(544, 66);
      this.GroupBox2.TabIndex = 1;
      this.GroupBox2.TabStop = false;
      this.GroupBox2.Text = "Read From OFX File";
      // 
      // ccstatementDemo
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(565, 470);
      this.Controls.Add(this.lblNotice);
      this.Controls.Add(this.gbAccount);
      this.Controls.Add(this.GroupBox2);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.Name = "ccstatementDemo";
      this.Text = "Credit Card Statement Demo";
      this.gbAccount.ResumeLayout(false);
      this.gbAccount.PerformLayout();
      this.GroupBox2.ResumeLayout(false);
      this.GroupBox2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DateTimePicker dtpEndDate;
    private System.Windows.Forms.Label lblNotice;
    internal System.Windows.Forms.GroupBox gbAccount;
    private System.Windows.Forms.Label lblEndDate;
    internal System.Windows.Forms.TextBox txtFIId;
    internal System.Windows.Forms.Label Label5;
    internal System.Windows.Forms.TextBox txtFIOrganization;
    internal System.Windows.Forms.Label Label4;
    internal System.Windows.Forms.TextBox txtURL;
    internal System.Windows.Forms.Label Label1;
    private System.Windows.Forms.DateTimePicker dtpStartDate;
    private System.Windows.Forms.Label lblStartDate;
    private System.Windows.Forms.Button bGetStatement;
    private System.Windows.Forms.TextBox txtCardNumber;
    private System.Windows.Forms.TextBox txtUserId;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Label lblPassword;
    private System.Windows.Forms.Label lblUserId;
    private System.Windows.Forms.Label lblAccountNumber;
    internal System.Windows.Forms.TextBox txtFileName;
    internal System.Windows.Forms.Label Label11;
    internal System.Windows.Forms.Button btnRead;
    internal System.Windows.Forms.GroupBox GroupBox2;
    private DPayments.InEBank.Ccstatement ccstatement1;
    internal System.Windows.Forms.ComboBox cmbBank;
    internal System.Windows.Forms.Label lblBank;
  }
}

