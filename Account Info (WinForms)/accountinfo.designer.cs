namespace DPayments.Demos
{
  partial class accountinfoDemo
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(accountinfoDemo));
      this.btnGetAccountInfo = new System.Windows.Forms.Button();
      this.gbBank = new System.Windows.Forms.GroupBox();
      this.cmbBank = new System.Windows.Forms.ComboBox();
      this.lblBank = new System.Windows.Forms.Label();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.lblPassword = new System.Windows.Forms.Label();
      this.txtUserId = new System.Windows.Forms.TextBox();
      this.lblUserId = new System.Windows.Forms.Label();
      this.txtUrl = new System.Windows.Forms.TextBox();
      this.Label1 = new System.Windows.Forms.Label();
      this.txtFIOrganization = new System.Windows.Forms.TextBox();
      this.txtFIId = new System.Windows.Forms.TextBox();
      this.lblBankId = new System.Windows.Forms.Label();
      this.lblFIOrganization = new System.Windows.Forms.Label();
      this.AccTrDestination = new System.Windows.Forms.ColumnHeader();
      this.AccTrSource = new System.Windows.Forms.ColumnHeader();
      this.AccStatus = new System.Windows.Forms.ColumnHeader();
      this.lblNotice = new System.Windows.Forms.Label();
      this.AccDesc = new System.Windows.Forms.ColumnHeader();
      this.AccBankId = new System.Windows.Forms.ColumnHeader();
      this.AccType = new System.Windows.Forms.ColumnHeader();
      this.AccNmb = new System.Windows.Forms.ColumnHeader();
      this.lvAccounts = new System.Windows.Forms.ListView();
      this.gbAccountinfo = new System.Windows.Forms.GroupBox();
      this.account1 = new DPayments.InEBank.Account(this.components);
      this.gbBank.SuspendLayout();
      this.gbAccountinfo.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnGetAccountInfo
      // 
      this.btnGetAccountInfo.ForeColor = System.Drawing.SystemColors.ControlText;
      this.btnGetAccountInfo.Location = new System.Drawing.Point(242, 193);
      this.btnGetAccountInfo.Name = "btnGetAccountInfo";
      this.btnGetAccountInfo.Size = new System.Drawing.Size(116, 23);
      this.btnGetAccountInfo.TabIndex = 6;
      this.btnGetAccountInfo.Text = "Get Account Info";
      this.btnGetAccountInfo.Click += new System.EventHandler(this.btnGetAccountInfo_Click);
      // 
      // gbBank
      // 
      this.gbBank.Controls.Add(this.cmbBank);
      this.gbBank.Controls.Add(this.lblBank);
      this.gbBank.Controls.Add(this.txtPassword);
      this.gbBank.Controls.Add(this.lblPassword);
      this.gbBank.Controls.Add(this.btnGetAccountInfo);
      this.gbBank.Controls.Add(this.txtUserId);
      this.gbBank.Controls.Add(this.lblUserId);
      this.gbBank.Controls.Add(this.txtUrl);
      this.gbBank.Controls.Add(this.Label1);
      this.gbBank.Controls.Add(this.txtFIOrganization);
      this.gbBank.Controls.Add(this.txtFIId);
      this.gbBank.Controls.Add(this.lblBankId);
      this.gbBank.Controls.Add(this.lblFIOrganization);
      this.gbBank.ForeColor = System.Drawing.SystemColors.Desktop;
      this.gbBank.Location = new System.Drawing.Point(13, 60);
      this.gbBank.Name = "gbBank";
      this.gbBank.Size = new System.Drawing.Size(612, 234);
      this.gbBank.TabIndex = 0;
      this.gbBank.TabStop = false;
      this.gbBank.Text = "Account Information Request";
      // 
      // cmbBank
      // 
      this.cmbBank.Items.AddRange(new object[] {
            "American Express",
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
      this.cmbBank.Location = new System.Drawing.Point(158, 25);
      this.cmbBank.Name = "cmbBank";
      this.cmbBank.Size = new System.Drawing.Size(448, 21);
      this.cmbBank.TabIndex = 0;
      this.cmbBank.Text = "Wachovia Bank";
      this.cmbBank.SelectedIndexChanged += new System.EventHandler(this.cmbBank_SelectedIndexChanged);
      // 
      // lblBank
      // 
      this.lblBank.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblBank.Location = new System.Drawing.Point(41, 23);
      this.lblBank.Name = "lblBank";
      this.lblBank.Size = new System.Drawing.Size(117, 23);
      this.lblBank.TabIndex = 7;
      this.lblBank.Text = "Bank Common Name:";
      this.lblBank.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtPassword
      // 
      this.txtPassword.Location = new System.Drawing.Point(242, 156);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.PasswordChar = '*';
      this.txtPassword.Size = new System.Drawing.Size(116, 20);
      this.txtPassword.TabIndex = 5;
      // 
      // lblPassword
      // 
      this.lblPassword.ForeColor = System.Drawing.Color.Maroon;
      this.lblPassword.Location = new System.Drawing.Point(179, 153);
      this.lblPassword.Name = "lblPassword";
      this.lblPassword.Size = new System.Drawing.Size(57, 23);
      this.lblPassword.TabIndex = 12;
      this.lblPassword.Text = "Password:";
      this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtUserId
      // 
      this.txtUserId.Location = new System.Drawing.Point(242, 130);
      this.txtUserId.Name = "txtUserId";
      this.txtUserId.Size = new System.Drawing.Size(116, 20);
      this.txtUserId.TabIndex = 4;
      // 
      // lblUserId
      // 
      this.lblUserId.ForeColor = System.Drawing.Color.Maroon;
      this.lblUserId.Location = new System.Drawing.Point(191, 130);
      this.lblUserId.Name = "lblUserId";
      this.lblUserId.Size = new System.Drawing.Size(45, 23);
      this.lblUserId.TabIndex = 11;
      this.lblUserId.Text = "User Id:";
      this.lblUserId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtUrl
      // 
      this.txtUrl.Location = new System.Drawing.Point(158, 52);
      this.txtUrl.Name = "txtUrl";
      this.txtUrl.Size = new System.Drawing.Size(448, 20);
      this.txtUrl.TabIndex = 1;
      this.txtUrl.Text = "https://pfmpw.wachovia.com/cgi-forte/fortecgi?servicename=ofx&pagename=PFM\"";
      // 
      // Label1
      // 
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.Location = new System.Drawing.Point(105, 53);
      this.Label1.Name = "Label1";
      this.Label1.Size = new System.Drawing.Size(47, 14);
      this.Label1.TabIndex = 8;
      this.Label1.Text = "FI URL:";
      this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtFIOrganization
      // 
      this.txtFIOrganization.Location = new System.Drawing.Point(242, 78);
      this.txtFIOrganization.Name = "txtFIOrganization";
      this.txtFIOrganization.Size = new System.Drawing.Size(116, 20);
      this.txtFIOrganization.TabIndex = 2;
      this.txtFIOrganization.Text = "Wachovia";
      // 
      // txtFIId
      // 
      this.txtFIId.Location = new System.Drawing.Point(242, 104);
      this.txtFIId.Name = "txtFIId";
      this.txtFIId.Size = new System.Drawing.Size(116, 20);
      this.txtFIId.TabIndex = 3;
      this.txtFIId.Text = "4309";
      // 
      // lblBankId
      // 
      this.lblBankId.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblBankId.Location = new System.Drawing.Point(189, 110);
      this.lblBankId.Name = "lblBankId";
      this.lblBankId.Size = new System.Drawing.Size(47, 11);
      this.lblBankId.TabIndex = 10;
      this.lblBankId.Text = "FI ID:";
      this.lblBankId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lblFIOrganization
      // 
      this.lblFIOrganization.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblFIOrganization.Location = new System.Drawing.Point(141, 81);
      this.lblFIOrganization.Name = "lblFIOrganization";
      this.lblFIOrganization.Size = new System.Drawing.Size(95, 17);
      this.lblFIOrganization.TabIndex = 9;
      this.lblFIOrganization.Text = "FI Organization:";
      this.lblFIOrganization.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // AccTrDestination
      // 
      this.AccTrDestination.Text = "Is Transfer Destination";
      this.AccTrDestination.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.AccTrDestination.Width = 102;
      // 
      // AccTrSource
      // 
      this.AccTrSource.Text = "Is Transfer Source";
      this.AccTrSource.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.AccTrSource.Width = 102;
      // 
      // AccStatus
      // 
      this.AccStatus.Text = "Status";
      this.AccStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.AccStatus.Width = 56;
      // 
      // lblNotice
      // 
      this.lblNotice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.lblNotice.ForeColor = System.Drawing.SystemColors.Highlight;
      this.lblNotice.Location = new System.Drawing.Point(13, 12);
      this.lblNotice.Name = "lblNotice";
      this.lblNotice.Size = new System.Drawing.Size(615, 40);
      this.lblNotice.TabIndex = 1;
      this.lblNotice.Text = resources.GetString("lblNotice.Text");
      // 
      // AccDesc
      // 
      this.AccDesc.Text = "Account Desc.";
      this.AccDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.AccDesc.Width = 86;
      // 
      // AccBankId
      // 
      this.AccBankId.Text = "Bank Id";
      this.AccBankId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.AccBankId.Width = 63;
      // 
      // AccType
      // 
      this.AccType.Text = "Account Type";
      this.AccType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.AccType.Width = 85;
      // 
      // AccNmb
      // 
      this.AccNmb.Text = "Account #";
      this.AccNmb.Width = 101;
      // 
      // lvAccounts
      // 
      this.lvAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.lvAccounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AccNmb,
            this.AccType,
            this.AccBankId,
            this.AccDesc,
            this.AccStatus,
            this.AccTrSource,
            this.AccTrDestination});
      this.lvAccounts.GridLines = true;
      this.lvAccounts.Location = new System.Drawing.Point(6, 19);
      this.lvAccounts.Name = "lvAccounts";
      this.lvAccounts.Size = new System.Drawing.Size(601, 197);
      this.lvAccounts.TabIndex = 0;
      this.lvAccounts.UseCompatibleStateImageBehavior = false;
      this.lvAccounts.View = System.Windows.Forms.View.Details;
      // 
      // gbAccountinfo
      // 
      this.gbAccountinfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.gbAccountinfo.Controls.Add(this.lvAccounts);
      this.gbAccountinfo.ForeColor = System.Drawing.Color.Maroon;
      this.gbAccountinfo.Location = new System.Drawing.Point(13, 300);
      this.gbAccountinfo.Name = "gbAccountinfo";
      this.gbAccountinfo.Size = new System.Drawing.Size(613, 222);
      this.gbAccountinfo.TabIndex = 2;
      this.gbAccountinfo.TabStop = false;
      this.gbAccountinfo.Text = "Response on Account(s) Information";
      // 
      // accountinfoDemo
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(641, 539);
      this.Controls.Add(this.gbBank);
      this.Controls.Add(this.lblNotice);
      this.Controls.Add(this.gbAccountinfo);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.Name = "accountinfoDemo";
      this.Text = "Account Info Demo";
      this.gbBank.ResumeLayout(false);
      this.gbBank.PerformLayout();
      this.gbAccountinfo.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    internal System.Windows.Forms.Button btnGetAccountInfo;
    internal System.Windows.Forms.GroupBox gbBank;
    internal System.Windows.Forms.TextBox txtUrl;
    internal System.Windows.Forms.Label Label1;
    internal System.Windows.Forms.TextBox txtFIOrganization;
    internal System.Windows.Forms.TextBox txtFIId;
    internal System.Windows.Forms.Label lblBankId;
    internal System.Windows.Forms.Label lblFIOrganization;
    internal System.Windows.Forms.ColumnHeader AccTrDestination;
    internal System.Windows.Forms.ColumnHeader AccTrSource;
    internal System.Windows.Forms.ColumnHeader AccStatus;
    internal System.Windows.Forms.Label lblNotice;
    internal System.Windows.Forms.ColumnHeader AccDesc;
    internal System.Windows.Forms.ColumnHeader AccBankId;
    internal System.Windows.Forms.ColumnHeader AccType;
    internal System.Windows.Forms.TextBox txtUserId;
    internal System.Windows.Forms.Label lblUserId;
    internal System.Windows.Forms.TextBox txtPassword;
    internal System.Windows.Forms.Label lblPassword;
    internal System.Windows.Forms.ColumnHeader AccNmb;
    internal System.Windows.Forms.ListView lvAccounts;
    internal System.Windows.Forms.GroupBox gbAccountinfo;
    private DPayments.InEBank.Account account1;
    internal System.Windows.Forms.ComboBox cmbBank;
    internal System.Windows.Forms.Label lblBank;
  }
}

