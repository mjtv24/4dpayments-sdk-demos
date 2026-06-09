namespace DPayments.Demos
{
  partial class banktransferDemo
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(banktransferDemo));
      this.banktransfer1 = new DPayments.InEBank.Banktransfer(this.components);
      this.Label9 = new System.Windows.Forms.Label();
      this.txtAmount = new System.Windows.Forms.TextBox();
      this.btnTransfer = new System.Windows.Forms.Button();
      this.GroupBox3 = new System.Windows.Forms.GroupBox();
      this.lblTransferId = new System.Windows.Forms.Label();
      this.Label15 = new System.Windows.Forms.Label();
      this.lblCurrency = new System.Windows.Forms.Label();
      this.lblStatus = new System.Windows.Forms.Label();
      this.lblTransferDate = new System.Windows.Forms.Label();
      this.lblDatePosted = new System.Windows.Forms.Label();
      this.Label10 = new System.Windows.Forms.Label();
      this.Label13 = new System.Windows.Forms.Label();
      this.Label12 = new System.Windows.Forms.Label();
      this.Label11 = new System.Windows.Forms.Label();
      this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
      this.Label3 = new System.Windows.Forms.Label();
      this.txtFromBankId = new System.Windows.Forms.TextBox();
      this.Label2 = new System.Windows.Forms.Label();
      this.Label4 = new System.Windows.Forms.Label();
      this.txtFromAccountId = new System.Windows.Forms.TextBox();
      this.cmbFromAccountType = new System.Windows.Forms.ComboBox();
      this.lblNotice = new System.Windows.Forms.Label();
      this.gbBank = new System.Windows.Forms.GroupBox();
      this.cmbBankName = new System.Windows.Forms.ComboBox();
      this.lblBank = new System.Windows.Forms.Label();
      this.txtFIUrl = new System.Windows.Forms.TextBox();
      this.Label1 = new System.Windows.Forms.Label();
      this.txtFIId = new System.Windows.Forms.TextBox();
      this.label14 = new System.Windows.Forms.Label();
      this.txtFIOrganization = new System.Windows.Forms.TextBox();
      this.label16 = new System.Windows.Forms.Label();
      this.txtUserId = new System.Windows.Forms.TextBox();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.label17 = new System.Windows.Forms.Label();
      this.label18 = new System.Windows.Forms.Label();
      this.cmbToAccountType = new System.Windows.Forms.ComboBox();
      this.GroupBox1 = new System.Windows.Forms.GroupBox();
      this.txtToBankId = new System.Windows.Forms.TextBox();
      this.Label5 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.Label6 = new System.Windows.Forms.Label();
      this.txtToAccountId = new System.Windows.Forms.TextBox();
      this.Label8 = new System.Windows.Forms.Label();
      this.GroupBox3.SuspendLayout();
      this.gbBank.SuspendLayout();
      this.GroupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // Label9
      // 
      this.Label9.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label9.Location = new System.Drawing.Point(285, 18);
      this.Label9.Name = "Label9";
      this.Label9.Size = new System.Drawing.Size(58, 23);
      this.Label9.TabIndex = 15;
      this.Label9.Text = "Amount:";
      this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtAmount
      // 
      this.txtAmount.Location = new System.Drawing.Point(349, 20);
      this.txtAmount.Name = "txtAmount";
      this.txtAmount.Size = new System.Drawing.Size(106, 20);
      this.txtAmount.TabIndex = 6;
      // 
      // btnTransfer
      // 
      this.btnTransfer.Location = new System.Drawing.Point(328, 150);
      this.btnTransfer.Name = "btnTransfer";
      this.btnTransfer.Size = new System.Drawing.Size(127, 23);
      this.btnTransfer.TabIndex = 8;
      this.btnTransfer.Text = "Request Transfer";
      this.btnTransfer.Click += new System.EventHandler(this.bTransfer_Click);
      // 
      // GroupBox3
      // 
      this.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.GroupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
      this.GroupBox3.Controls.Add(this.lblTransferId);
      this.GroupBox3.Controls.Add(this.Label15);
      this.GroupBox3.Controls.Add(this.lblCurrency);
      this.GroupBox3.Controls.Add(this.lblStatus);
      this.GroupBox3.Controls.Add(this.lblTransferDate);
      this.GroupBox3.Controls.Add(this.lblDatePosted);
      this.GroupBox3.Controls.Add(this.Label10);
      this.GroupBox3.Controls.Add(this.Label13);
      this.GroupBox3.Controls.Add(this.Label12);
      this.GroupBox3.Controls.Add(this.Label11);
      this.GroupBox3.ForeColor = System.Drawing.SystemColors.Desktop;
      this.GroupBox3.Location = new System.Drawing.Point(13, 472);
      this.GroupBox3.Name = "GroupBox3";
      this.GroupBox3.Size = new System.Drawing.Size(520, 107);
      this.GroupBox3.TabIndex = 2;
      this.GroupBox3.TabStop = false;
      this.GroupBox3.Text = "Transfer Response";
      // 
      // lblTransferId
      // 
      this.lblTransferId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTransferId.ForeColor = System.Drawing.Color.Maroon;
      this.lblTransferId.Location = new System.Drawing.Point(177, 15);
      this.lblTransferId.Name = "lblTransferId";
      this.lblTransferId.Size = new System.Drawing.Size(222, 24);
      this.lblTransferId.TabIndex = 0;
      this.lblTransferId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // Label15
      // 
      this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Label15.ForeColor = System.Drawing.Color.Maroon;
      this.Label15.Location = new System.Drawing.Point(83, 15);
      this.Label15.Name = "Label15";
      this.Label15.Size = new System.Drawing.Size(91, 24);
      this.Label15.TabIndex = 5;
      this.Label15.Text = "Transfer Id:";
      this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lblCurrency
      // 
      this.lblCurrency.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblCurrency.Location = new System.Drawing.Point(177, 63);
      this.lblCurrency.Name = "lblCurrency";
      this.lblCurrency.Size = new System.Drawing.Size(86, 24);
      this.lblCurrency.TabIndex = 2;
      this.lblCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblStatus
      // 
      this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblStatus.Location = new System.Drawing.Point(408, 39);
      this.lblStatus.Name = "lblStatus";
      this.lblStatus.Size = new System.Drawing.Size(106, 24);
      this.lblStatus.TabIndex = 3;
      this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblTransferDate
      // 
      this.lblTransferDate.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblTransferDate.Location = new System.Drawing.Point(408, 61);
      this.lblTransferDate.Name = "lblTransferDate";
      this.lblTransferDate.Size = new System.Drawing.Size(98, 24);
      this.lblTransferDate.TabIndex = 4;
      this.lblTransferDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblDatePosted
      // 
      this.lblDatePosted.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblDatePosted.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblDatePosted.Location = new System.Drawing.Point(177, 39);
      this.lblDatePosted.Name = "lblDatePosted";
      this.lblDatePosted.Size = new System.Drawing.Size(129, 24);
      this.lblDatePosted.TabIndex = 1;
      this.lblDatePosted.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // Label10
      // 
      this.Label10.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label10.Location = new System.Drawing.Point(119, 62);
      this.Label10.Name = "Label10";
      this.Label10.Size = new System.Drawing.Size(55, 23);
      this.Label10.TabIndex = 7;
      this.Label10.Text = "Currency:";
      this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // Label13
      // 
      this.Label13.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label13.Location = new System.Drawing.Point(319, 39);
      this.Label13.Name = "Label13";
      this.Label13.Size = new System.Drawing.Size(83, 23);
      this.Label13.TabIndex = 8;
      this.Label13.Text = "Transfer Status:";
      this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // Label12
      // 
      this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Label12.ForeColor = System.Drawing.Color.Black;
      this.Label12.Location = new System.Drawing.Point(83, 38);
      this.Label12.Name = "Label12";
      this.Label12.Size = new System.Drawing.Size(91, 24);
      this.Label12.TabIndex = 6;
      this.Label12.Text = "Date Posted:";
      this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // Label11
      // 
      this.Label11.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label11.Location = new System.Drawing.Point(311, 61);
      this.Label11.Name = "Label11";
      this.Label11.Size = new System.Drawing.Size(91, 24);
      this.Label11.TabIndex = 9;
      this.Label11.Text = "Transfer Date:";
      this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // dtpDueDate
      // 
      this.dtpDueDate.CustomFormat = "MM/dd/yyyy HH:mm:ss";
      this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpDueDate.Location = new System.Drawing.Point(349, 47);
      this.dtpDueDate.Name = "dtpDueDate";
      this.dtpDueDate.Size = new System.Drawing.Size(106, 20);
      this.dtpDueDate.TabIndex = 7;
      this.dtpDueDate.Value = new System.DateTime(2009, 9, 30, 0, 0, 0, 0);
      // 
      // Label3
      // 
      this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label3.Location = new System.Drawing.Point(285, 47);
      this.Label3.Name = "Label3";
      this.Label3.Size = new System.Drawing.Size(58, 23);
      this.Label3.TabIndex = 16;
      this.Label3.Text = "Due Date:";
      this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtFromBankId
      // 
      this.txtFromBankId.Location = new System.Drawing.Point(135, 19);
      this.txtFromBankId.Name = "txtFromBankId";
      this.txtFromBankId.Size = new System.Drawing.Size(124, 20);
      this.txtFromBankId.TabIndex = 0;
      this.txtFromBankId.Text = "053000219";
      // 
      // Label2
      // 
      this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label2.Location = new System.Drawing.Point(17, 17);
      this.Label2.Name = "Label2";
      this.Label2.Size = new System.Drawing.Size(118, 23);
      this.Label2.TabIndex = 9;
      this.Label2.Text = "From Bank Id:";
      this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // Label4
      // 
      this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label4.Location = new System.Drawing.Point(14, 43);
      this.Label4.Name = "Label4";
      this.Label4.Size = new System.Drawing.Size(121, 23);
      this.Label4.TabIndex = 10;
      this.Label4.Text = "From Account Number:";
      this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtFromAccountId
      // 
      this.txtFromAccountId.Location = new System.Drawing.Point(135, 45);
      this.txtFromAccountId.Name = "txtFromAccountId";
      this.txtFromAccountId.Size = new System.Drawing.Size(124, 20);
      this.txtFromAccountId.TabIndex = 1;
      // 
      // cmbFromAccountType
      // 
      this.cmbFromAccountType.Items.AddRange(new object[] {
            "Checking",
            "Savings",
            "Money Market",
            "Line of Credit",
            "Credit Card"});
      this.cmbFromAccountType.Location = new System.Drawing.Point(135, 71);
      this.cmbFromAccountType.Name = "cmbFromAccountType";
      this.cmbFromAccountType.Size = new System.Drawing.Size(124, 21);
      this.cmbFromAccountType.TabIndex = 2;
      // 
      // lblNotice
      // 
      this.lblNotice.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.lblNotice.ForeColor = System.Drawing.SystemColors.Highlight;
      this.lblNotice.Location = new System.Drawing.Point(13, 9);
      this.lblNotice.Name = "lblNotice";
      this.lblNotice.Size = new System.Drawing.Size(520, 59);
      this.lblNotice.TabIndex = 3;
      this.lblNotice.Text = resources.GetString("lblNotice.Text");
      // 
      // gbBank
      // 
      this.gbBank.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.gbBank.Controls.Add(this.cmbBankName);
      this.gbBank.Controls.Add(this.lblBank);
      this.gbBank.Controls.Add(this.txtFIUrl);
      this.gbBank.Controls.Add(this.Label1);
      this.gbBank.Controls.Add(this.txtFIId);
      this.gbBank.Controls.Add(this.label14);
      this.gbBank.Controls.Add(this.txtFIOrganization);
      this.gbBank.Controls.Add(this.label16);
      this.gbBank.Controls.Add(this.txtUserId);
      this.gbBank.Controls.Add(this.txtPassword);
      this.gbBank.Controls.Add(this.label17);
      this.gbBank.Controls.Add(this.label18);
      this.gbBank.ForeColor = System.Drawing.SystemColors.Desktop;
      this.gbBank.Location = new System.Drawing.Point(13, 71);
      this.gbBank.Name = "gbBank";
      this.gbBank.Size = new System.Drawing.Size(520, 196);
      this.gbBank.TabIndex = 0;
      this.gbBank.TabStop = false;
      this.gbBank.Text = "FI Login Information";
      // 
      // cmbBankName
      // 
      this.cmbBankName.Items.AddRange(new object[] {
            "Bank of America",
            "Bank One - JPMorgan Chase",
            "BB&T - Branch Banking and Trust Company",
            "JPMorgan Chase Bank",
            "Mellon Bank",
            "SunTrust",
            "Wachovia Bank",
            "Wells Fargo",
            "Zions Bank"});
      this.cmbBankName.Location = new System.Drawing.Point(137, 23);
      this.cmbBankName.Name = "cmbBankName";
      this.cmbBankName.Size = new System.Drawing.Size(364, 21);
      this.cmbBankName.TabIndex = 0;
      this.cmbBankName.Text = "Wachovia Bank";
      this.cmbBankName.SelectedIndexChanged += new System.EventHandler(this.cmbBankName_SelectedIndexChanged);
      // 
      // lblBank
      // 
      this.lblBank.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblBank.Location = new System.Drawing.Point(25, 21);
      this.lblBank.Name = "lblBank";
      this.lblBank.Size = new System.Drawing.Size(112, 23);
      this.lblBank.TabIndex = 6;
      this.lblBank.Text = "Bank Common Name:";
      this.lblBank.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtFIUrl
      // 
      this.txtFIUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.txtFIUrl.Location = new System.Drawing.Point(137, 50);
      this.txtFIUrl.Name = "txtFIUrl";
      this.txtFIUrl.Size = new System.Drawing.Size(364, 20);
      this.txtFIUrl.TabIndex = 1;
      this.txtFIUrl.Text = "https://pfmpw.wachovia.com/cgi-forte/fortecgi?servicename=ofx&pagename=PFM";
      // 
      // Label1
      // 
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.Location = new System.Drawing.Point(28, 51);
      this.Label1.Name = "Label1";
      this.Label1.Size = new System.Drawing.Size(109, 19);
      this.Label1.TabIndex = 7;
      this.Label1.Text = "FI URL:";
      this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtFIId
      // 
      this.txtFIId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.txtFIId.Location = new System.Drawing.Point(137, 104);
      this.txtFIId.Name = "txtFIId";
      this.txtFIId.Size = new System.Drawing.Size(124, 20);
      this.txtFIId.TabIndex = 3;
      this.txtFIId.Text = "4309";
      // 
      // label14
      // 
      this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label14.Location = new System.Drawing.Point(38, 104);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(99, 16);
      this.label14.TabIndex = 9;
      this.label14.Text = "FI ID:";
      this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtFIOrganization
      // 
      this.txtFIOrganization.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.txtFIOrganization.Location = new System.Drawing.Point(137, 76);
      this.txtFIOrganization.Name = "txtFIOrganization";
      this.txtFIOrganization.Size = new System.Drawing.Size(124, 20);
      this.txtFIOrganization.TabIndex = 2;
      this.txtFIOrganization.Text = "Wachovia";
      // 
      // label16
      // 
      this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label16.Location = new System.Drawing.Point(30, 76);
      this.label16.Name = "label16";
      this.label16.Size = new System.Drawing.Size(107, 16);
      this.label16.TabIndex = 8;
      this.label16.Text = "FI Organization:";
      this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtUserId
      // 
      this.txtUserId.Location = new System.Drawing.Point(137, 131);
      this.txtUserId.Name = "txtUserId";
      this.txtUserId.Size = new System.Drawing.Size(124, 20);
      this.txtUserId.TabIndex = 4;
      // 
      // txtPassword
      // 
      this.txtPassword.Location = new System.Drawing.Point(137, 159);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.PasswordChar = '*';
      this.txtPassword.Size = new System.Drawing.Size(124, 20);
      this.txtPassword.TabIndex = 5;
      // 
      // label17
      // 
      this.label17.ForeColor = System.Drawing.Color.Maroon;
      this.label17.Location = new System.Drawing.Point(38, 157);
      this.label17.Name = "label17";
      this.label17.Size = new System.Drawing.Size(99, 23);
      this.label17.TabIndex = 11;
      this.label17.Text = "Password:";
      this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label18
      // 
      this.label18.ForeColor = System.Drawing.Color.Maroon;
      this.label18.Location = new System.Drawing.Point(38, 129);
      this.label18.Name = "label18";
      this.label18.Size = new System.Drawing.Size(99, 23);
      this.label18.TabIndex = 10;
      this.label18.Text = "User Id:";
      this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // cmbToAccountType
      // 
      this.cmbToAccountType.Items.AddRange(new object[] {
            "Checking",
            "Savings",
            "Money Market",
            "Line of Credit",
            "Credit Card"});
      this.cmbToAccountType.Location = new System.Drawing.Point(135, 150);
      this.cmbToAccountType.Name = "cmbToAccountType";
      this.cmbToAccountType.Size = new System.Drawing.Size(124, 21);
      this.cmbToAccountType.TabIndex = 5;
      // 
      // GroupBox1
      // 
      this.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.GroupBox1.Controls.Add(this.btnTransfer);
      this.GroupBox1.Controls.Add(this.Label9);
      this.GroupBox1.Controls.Add(this.txtToBankId);
      this.GroupBox1.Controls.Add(this.txtAmount);
      this.GroupBox1.Controls.Add(this.Label5);
      this.GroupBox1.Controls.Add(this.label7);
      this.GroupBox1.Controls.Add(this.dtpDueDate);
      this.GroupBox1.Controls.Add(this.Label3);
      this.GroupBox1.Controls.Add(this.cmbFromAccountType);
      this.GroupBox1.Controls.Add(this.Label6);
      this.GroupBox1.Controls.Add(this.txtFromBankId);
      this.GroupBox1.Controls.Add(this.cmbToAccountType);
      this.GroupBox1.Controls.Add(this.Label2);
      this.GroupBox1.Controls.Add(this.txtToAccountId);
      this.GroupBox1.Controls.Add(this.Label8);
      this.GroupBox1.Controls.Add(this.txtFromAccountId);
      this.GroupBox1.Controls.Add(this.Label4);
      this.GroupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
      this.GroupBox1.Location = new System.Drawing.Point(15, 273);
      this.GroupBox1.Name = "GroupBox1";
      this.GroupBox1.Size = new System.Drawing.Size(518, 193);
      this.GroupBox1.TabIndex = 1;
      this.GroupBox1.TabStop = false;
      this.GroupBox1.Text = "Transfer Details";
      // 
      // txtToBankId
      // 
      this.txtToBankId.Location = new System.Drawing.Point(135, 98);
      this.txtToBankId.Name = "txtToBankId";
      this.txtToBankId.Size = new System.Drawing.Size(124, 20);
      this.txtToBankId.TabIndex = 3;
      this.txtToBankId.Text = "053000219";
      // 
      // Label5
      // 
      this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label5.Location = new System.Drawing.Point(14, 69);
      this.Label5.Name = "Label5";
      this.Label5.Size = new System.Drawing.Size(121, 23);
      this.Label5.TabIndex = 11;
      this.Label5.Text = "From Account Type:";
      this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label7
      // 
      this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label7.Location = new System.Drawing.Point(39, 96);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(95, 23);
      this.label7.TabIndex = 12;
      this.label7.Text = "To Bank Id:";
      this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // Label6
      // 
      this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label6.Location = new System.Drawing.Point(19, 148);
      this.Label6.Name = "Label6";
      this.Label6.Size = new System.Drawing.Size(115, 23);
      this.Label6.TabIndex = 14;
      this.Label6.Text = "To Account Type:";
      this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtToAccountId
      // 
      this.txtToAccountId.Location = new System.Drawing.Point(135, 124);
      this.txtToAccountId.Name = "txtToAccountId";
      this.txtToAccountId.Size = new System.Drawing.Size(124, 20);
      this.txtToAccountId.TabIndex = 4;
      // 
      // Label8
      // 
      this.Label8.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label8.Location = new System.Drawing.Point(16, 122);
      this.Label8.Name = "Label8";
      this.Label8.Size = new System.Drawing.Size(118, 23);
      this.Label8.TabIndex = 13;
      this.Label8.Text = "To Account Number:";
      this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // banktransferDemo
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(547, 598);
      this.Controls.Add(this.GroupBox3);
      this.Controls.Add(this.lblNotice);
      this.Controls.Add(this.gbBank);
      this.Controls.Add(this.GroupBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.Name = "banktransferDemo";
      this.Text = "Bank Transfer Demo";
      this.Load += new System.EventHandler(this.banktransferDemo_Load);
      this.GroupBox3.ResumeLayout(false);
      this.gbBank.ResumeLayout(false);
      this.gbBank.PerformLayout();
      this.GroupBox1.ResumeLayout(false);
      this.GroupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private DPayments.InEBank.Banktransfer banktransfer1;
    internal System.Windows.Forms.Label Label9;
    internal System.Windows.Forms.TextBox txtAmount;
    internal System.Windows.Forms.Button btnTransfer;
    internal System.Windows.Forms.GroupBox GroupBox3;
    internal System.Windows.Forms.Label lblTransferId;
    internal System.Windows.Forms.Label Label15;
    internal System.Windows.Forms.Label lblCurrency;
    internal System.Windows.Forms.Label lblStatus;
    internal System.Windows.Forms.Label lblTransferDate;
    internal System.Windows.Forms.Label lblDatePosted;
    internal System.Windows.Forms.Label Label10;
    internal System.Windows.Forms.Label Label13;
    internal System.Windows.Forms.Label Label12;
    internal System.Windows.Forms.Label Label11;
    internal System.Windows.Forms.DateTimePicker dtpDueDate;
    internal System.Windows.Forms.Label Label3;
    internal System.Windows.Forms.TextBox txtFromBankId;
    internal System.Windows.Forms.Label Label2;
    internal System.Windows.Forms.Label Label4;
    internal System.Windows.Forms.TextBox txtFromAccountId;
    internal System.Windows.Forms.ComboBox cmbFromAccountType;
    internal System.Windows.Forms.Label lblNotice;
    internal System.Windows.Forms.GroupBox gbBank;
    internal System.Windows.Forms.ComboBox cmbToAccountType;
    internal System.Windows.Forms.GroupBox GroupBox1;
    internal System.Windows.Forms.Label Label5;
    internal System.Windows.Forms.Label Label6;
    internal System.Windows.Forms.TextBox txtToAccountId;
    internal System.Windows.Forms.Label Label8;
    internal System.Windows.Forms.ComboBox cmbBankName;
    internal System.Windows.Forms.Label lblBank;
    internal System.Windows.Forms.TextBox txtFIUrl;
    internal System.Windows.Forms.Label Label1;
    internal System.Windows.Forms.TextBox txtFIId;
    internal System.Windows.Forms.Label label14;
    internal System.Windows.Forms.TextBox txtFIOrganization;
    internal System.Windows.Forms.Label label16;
    private System.Windows.Forms.TextBox txtUserId;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Label label17;
    private System.Windows.Forms.Label label18;
    internal System.Windows.Forms.TextBox txtToBankId;
    internal System.Windows.Forms.Label label7;
  }
}

