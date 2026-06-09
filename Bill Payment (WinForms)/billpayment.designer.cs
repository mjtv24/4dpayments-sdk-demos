namespace DPayments.Demos
{
  partial class billpaymentDemo
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(billpaymentDemo));
      this.GroupBox4 = new System.Windows.Forms.GroupBox();
      this.cbName = new System.Windows.Forms.ComboBox();
      this.tbAccount = new System.Windows.Forms.TextBox();
      this.Label22 = new System.Windows.Forms.Label();
      this.tbPhone = new System.Windows.Forms.TextBox();
      this.Label21 = new System.Windows.Forms.Label();
      this.Label20 = new System.Windows.Forms.Label();
      this.tbPostalCode = new System.Windows.Forms.TextBox();
      this.tbState = new System.Windows.Forms.TextBox();
      this.Label19 = new System.Windows.Forms.Label();
      this.tbCity = new System.Windows.Forms.TextBox();
      this.Label18 = new System.Windows.Forms.Label();
      this.tbAddr2 = new System.Windows.Forms.TextBox();
      this.Label16 = new System.Windows.Forms.Label();
      this.Label2 = new System.Windows.Forms.Label();
      this.tbAddr1 = new System.Windows.Forms.TextBox();
      this.Label17 = new System.Windows.Forms.Label();
      this.GroupBox3 = new System.Windows.Forms.GroupBox();
      this.lblCurrency = new System.Windows.Forms.Label();
      this.Label25 = new System.Windows.Forms.Label();
      this.lblPaymentId = new System.Windows.Forms.Label();
      this.Label15 = new System.Windows.Forms.Label();
      this.lblStatus = new System.Windows.Forms.Label();
      this.lblPaymentDate = new System.Windows.Forms.Label();
      this.lblCheckNumber = new System.Windows.Forms.Label();
      this.Label13 = new System.Windows.Forms.Label();
      this.Label12 = new System.Windows.Forms.Label();
      this.Label11 = new System.Windows.Forms.Label();
      this.gbAddTransfer = new System.Windows.Forms.GroupBox();
      this.Label23 = new System.Windows.Forms.Label();
      this.tbMemo = new System.Windows.Forms.TextBox();
      this.Label9 = new System.Windows.Forms.Label();
      this.tbAmount = new System.Windows.Forms.TextBox();
      this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
      this.Label3 = new System.Windows.Forms.Label();
      this.bPayBill = new System.Windows.Forms.Button();
      this.gbLogin = new System.Windows.Forms.GroupBox();
      this.tbFromBankId = new System.Windows.Forms.TextBox();
      this.Label7 = new System.Windows.Forms.Label();
      this.tbFIUrl = new System.Windows.Forms.TextBox();
      this.Label1 = new System.Windows.Forms.Label();
      this.tbFIOrganization = new System.Windows.Forms.TextBox();
      this.tbFIId = new System.Windows.Forms.TextBox();
      this.lblBankId = new System.Windows.Forms.Label();
      this.lblFIOrganization = new System.Windows.Forms.Label();
      this.bLogin = new System.Windows.Forms.Button();
      this.Label5 = new System.Windows.Forms.Label();
      this.cbFromAccountType = new System.Windows.Forms.ComboBox();
      this.tbFromAccountId = new System.Windows.Forms.TextBox();
      this.Label4 = new System.Windows.Forms.Label();
      this.tbUserId = new System.Windows.Forms.TextBox();
      this.lblUserId = new System.Windows.Forms.Label();
      this.tbPassword = new System.Windows.Forms.TextBox();
      this.lblPassword = new System.Windows.Forms.Label();
      this.lblNotice = new System.Windows.Forms.Label();
      this.billpayment1 = new DPayments.InEBank.Billpayment(this.components);
      this.GroupBox4.SuspendLayout();
      this.GroupBox3.SuspendLayout();
      this.gbAddTransfer.SuspendLayout();
      this.gbLogin.SuspendLayout();
      this.SuspendLayout();
      // 
      // GroupBox4
      // 
      this.GroupBox4.Controls.Add(this.cbName);
      this.GroupBox4.Controls.Add(this.tbAccount);
      this.GroupBox4.Controls.Add(this.Label22);
      this.GroupBox4.Controls.Add(this.tbPhone);
      this.GroupBox4.Controls.Add(this.Label21);
      this.GroupBox4.Controls.Add(this.Label20);
      this.GroupBox4.Controls.Add(this.tbPostalCode);
      this.GroupBox4.Controls.Add(this.tbState);
      this.GroupBox4.Controls.Add(this.Label19);
      this.GroupBox4.Controls.Add(this.tbCity);
      this.GroupBox4.Controls.Add(this.Label18);
      this.GroupBox4.Controls.Add(this.tbAddr2);
      this.GroupBox4.Controls.Add(this.Label16);
      this.GroupBox4.Controls.Add(this.Label2);
      this.GroupBox4.Controls.Add(this.tbAddr1);
      this.GroupBox4.Controls.Add(this.Label17);
      this.GroupBox4.ForeColor = System.Drawing.SystemColors.Desktop;
      this.GroupBox4.Location = new System.Drawing.Point(7, 313);
      this.GroupBox4.Name = "GroupBox4";
      this.GroupBox4.Size = new System.Drawing.Size(520, 158);
      this.GroupBox4.TabIndex = 5;
      this.GroupBox4.TabStop = false;
      this.GroupBox4.Text = "Payee Information";
      // 
      // cbName
      // 
      this.cbName.FormattingEnabled = true;
      this.cbName.Location = new System.Drawing.Point(123, 25);
      this.cbName.Name = "cbName";
      this.cbName.Size = new System.Drawing.Size(384, 21);
      this.cbName.TabIndex = 5;
      this.cbName.SelectedIndexChanged += new System.EventHandler(this.cbName_SelectedIndexChanged);
      // 
      // tbAccount
      // 
      this.tbAccount.Location = new System.Drawing.Point(262, 131);
      this.tbAccount.Name = "tbAccount";
      this.tbAccount.Size = new System.Drawing.Size(245, 20);
      this.tbAccount.TabIndex = 12;
      this.tbAccount.Text = "test";
      // 
      // Label22
      // 
      this.Label22.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label22.Location = new System.Drawing.Point(206, 128);
      this.Label22.Name = "Label22";
      this.Label22.Size = new System.Drawing.Size(55, 23);
      this.Label22.TabIndex = 25;
      this.Label22.Text = "Account*:";
      this.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // tbPhone
      // 
      this.tbPhone.Location = new System.Drawing.Point(123, 131);
      this.tbPhone.Name = "tbPhone";
      this.tbPhone.Size = new System.Drawing.Size(81, 20);
      this.tbPhone.TabIndex = 11;
      // 
      // Label21
      // 
      this.Label21.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label21.Location = new System.Drawing.Point(62, 128);
      this.Label21.Name = "Label21";
      this.Label21.Size = new System.Drawing.Size(55, 23);
      this.Label21.TabIndex = 23;
      this.Label21.Text = "Phone*:";
      this.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // Label20
      // 
      this.Label20.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label20.Location = new System.Drawing.Point(349, 103);
      this.Label20.Name = "Label20";
      this.Label20.Size = new System.Drawing.Size(73, 23);
      this.Label20.TabIndex = 21;
      this.Label20.Text = "Postal Code*:";
      this.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // tbPostalCode
      // 
      this.tbPostalCode.Location = new System.Drawing.Point(425, 103);
      this.tbPostalCode.Name = "tbPostalCode";
      this.tbPostalCode.Size = new System.Drawing.Size(82, 20);
      this.tbPostalCode.TabIndex = 10;
      // 
      // tbState
      // 
      this.tbState.Location = new System.Drawing.Point(314, 105);
      this.tbState.Name = "tbState";
      this.tbState.Size = new System.Drawing.Size(32, 20);
      this.tbState.TabIndex = 9;
      // 
      // Label19
      // 
      this.Label19.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label19.Location = new System.Drawing.Point(272, 105);
      this.Label19.Name = "Label19";
      this.Label19.Size = new System.Drawing.Size(41, 23);
      this.Label19.TabIndex = 19;
      this.Label19.Text = "State*:";
      this.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // tbCity
      // 
      this.tbCity.Location = new System.Drawing.Point(122, 105);
      this.tbCity.Name = "tbCity";
      this.tbCity.Size = new System.Drawing.Size(141, 20);
      this.tbCity.TabIndex = 8;
      // 
      // Label18
      // 
      this.Label18.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label18.Location = new System.Drawing.Point(75, 102);
      this.Label18.Name = "Label18";
      this.Label18.Size = new System.Drawing.Size(41, 23);
      this.Label18.TabIndex = 17;
      this.Label18.Text = "City*:";
      this.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // tbAddr2
      // 
      this.tbAddr2.Location = new System.Drawing.Point(122, 79);
      this.tbAddr2.Name = "tbAddr2";
      this.tbAddr2.Size = new System.Drawing.Size(385, 20);
      this.tbAddr2.TabIndex = 7;
      // 
      // Label16
      // 
      this.Label16.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label16.Location = new System.Drawing.Point(24, 76);
      this.Label16.Name = "Label16";
      this.Label16.Size = new System.Drawing.Size(92, 23);
      this.Label16.TabIndex = 15;
      this.Label16.Text = "Address Line 2:";
      this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // Label2
      // 
      this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label2.Location = new System.Drawing.Point(58, 23);
      this.Label2.Name = "Label2";
      this.Label2.Size = new System.Drawing.Size(58, 23);
      this.Label2.TabIndex = 13;
      this.Label2.Text = "Name*:";
      this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // tbAddr1
      // 
      this.tbAddr1.Location = new System.Drawing.Point(122, 52);
      this.tbAddr1.Name = "tbAddr1";
      this.tbAddr1.Size = new System.Drawing.Size(385, 20);
      this.tbAddr1.TabIndex = 6;
      // 
      // Label17
      // 
      this.Label17.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label17.Location = new System.Drawing.Point(24, 49);
      this.Label17.Name = "Label17";
      this.Label17.Size = new System.Drawing.Size(92, 23);
      this.Label17.TabIndex = 9;
      this.Label17.Text = "Address Line 1*:";
      this.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // GroupBox3
      // 
      this.GroupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
      this.GroupBox3.Controls.Add(this.lblCurrency);
      this.GroupBox3.Controls.Add(this.Label25);
      this.GroupBox3.Controls.Add(this.lblPaymentId);
      this.GroupBox3.Controls.Add(this.Label15);
      this.GroupBox3.Controls.Add(this.lblStatus);
      this.GroupBox3.Controls.Add(this.lblPaymentDate);
      this.GroupBox3.Controls.Add(this.lblCheckNumber);
      this.GroupBox3.Controls.Add(this.Label13);
      this.GroupBox3.Controls.Add(this.Label12);
      this.GroupBox3.Controls.Add(this.Label11);
      this.GroupBox3.ForeColor = System.Drawing.SystemColors.Desktop;
      this.GroupBox3.Location = new System.Drawing.Point(7, 566);
      this.GroupBox3.Name = "GroupBox3";
      this.GroupBox3.Size = new System.Drawing.Size(520, 111);
      this.GroupBox3.TabIndex = 7;
      this.GroupBox3.TabStop = false;
      this.GroupBox3.Text = "Server Response";
      // 
      // lblCurrency
      // 
      this.lblCurrency.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblCurrency.Location = new System.Drawing.Point(185, 62);
      this.lblCurrency.Name = "lblCurrency";
      this.lblCurrency.Size = new System.Drawing.Size(75, 24);
      this.lblCurrency.TabIndex = 27;
      this.lblCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // Label25
      // 
      this.Label25.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label25.Location = new System.Drawing.Point(127, 62);
      this.Label25.Name = "Label25";
      this.Label25.Size = new System.Drawing.Size(55, 23);
      this.Label25.TabIndex = 26;
      this.Label25.Text = "Currency:";
      this.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lblPaymentId
      // 
      this.lblPaymentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      this.lblPaymentId.ForeColor = System.Drawing.Color.Maroon;
      this.lblPaymentId.Location = new System.Drawing.Point(185, 15);
      this.lblPaymentId.Name = "lblPaymentId";
      this.lblPaymentId.Size = new System.Drawing.Size(222, 24);
      this.lblPaymentId.TabIndex = 25;
      this.lblPaymentId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // Label15
      // 
      this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      this.Label15.ForeColor = System.Drawing.Color.Maroon;
      this.Label15.Location = new System.Drawing.Point(91, 15);
      this.Label15.Name = "Label15";
      this.Label15.Size = new System.Drawing.Size(91, 24);
      this.Label15.TabIndex = 24;
      this.Label15.Text = "Payment Id:";
      this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lblStatus
      // 
      this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblStatus.Location = new System.Drawing.Point(357, 39);
      this.lblStatus.Name = "lblStatus";
      this.lblStatus.Size = new System.Drawing.Size(157, 24);
      this.lblStatus.TabIndex = 22;
      this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblPaymentDate
      // 
      this.lblPaymentDate.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblPaymentDate.Location = new System.Drawing.Point(357, 61);
      this.lblPaymentDate.Name = "lblPaymentDate";
      this.lblPaymentDate.Size = new System.Drawing.Size(157, 24);
      this.lblPaymentDate.TabIndex = 21;
      this.lblPaymentDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblCheckNumber
      // 
      this.lblCheckNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      this.lblCheckNumber.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblCheckNumber.Location = new System.Drawing.Point(185, 39);
      this.lblCheckNumber.Name = "lblCheckNumber";
      this.lblCheckNumber.Size = new System.Drawing.Size(72, 24);
      this.lblCheckNumber.TabIndex = 20;
      this.lblCheckNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // Label13
      // 
      this.Label13.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label13.Location = new System.Drawing.Point(261, 39);
      this.Label13.Name = "Label13";
      this.Label13.Size = new System.Drawing.Size(90, 23);
      this.Label13.TabIndex = 18;
      this.Label13.Text = "Payment Status:";
      this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // Label12
      // 
      this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      this.Label12.ForeColor = System.Drawing.Color.Black;
      this.Label12.Location = new System.Drawing.Point(91, 38);
      this.Label12.Name = "Label12";
      this.Label12.Size = new System.Drawing.Size(91, 24);
      this.Label12.TabIndex = 17;
      this.Label12.Text = "Check Number:";
      this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // Label11
      // 
      this.Label11.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label11.Location = new System.Drawing.Point(260, 61);
      this.Label11.Name = "Label11";
      this.Label11.Size = new System.Drawing.Size(91, 24);
      this.Label11.TabIndex = 14;
      this.Label11.Text = "Payment Date:";
      this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // gbAddTransfer
      // 
      this.gbAddTransfer.Controls.Add(this.Label23);
      this.gbAddTransfer.Controls.Add(this.tbMemo);
      this.gbAddTransfer.Controls.Add(this.Label9);
      this.gbAddTransfer.Controls.Add(this.tbAmount);
      this.gbAddTransfer.Controls.Add(this.dtpDueDate);
      this.gbAddTransfer.Controls.Add(this.Label3);
      this.gbAddTransfer.Controls.Add(this.bPayBill);
      this.gbAddTransfer.ForeColor = System.Drawing.SystemColors.Desktop;
      this.gbAddTransfer.Location = new System.Drawing.Point(7, 478);
      this.gbAddTransfer.Name = "gbAddTransfer";
      this.gbAddTransfer.Size = new System.Drawing.Size(520, 81);
      this.gbAddTransfer.TabIndex = 6;
      this.gbAddTransfer.TabStop = false;
      this.gbAddTransfer.Text = "Payment Request";
      // 
      // Label23
      // 
      this.Label23.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label23.Location = new System.Drawing.Point(249, 18);
      this.Label23.Name = "Label23";
      this.Label23.Size = new System.Drawing.Size(58, 23);
      this.Label23.TabIndex = 18;
      this.Label23.Text = "Memo:";
      this.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // tbMemo
      // 
      this.tbMemo.Location = new System.Drawing.Point(313, 20);
      this.tbMemo.Name = "tbMemo";
      this.tbMemo.Size = new System.Drawing.Size(194, 20);
      this.tbMemo.TabIndex = 15;
      this.tbMemo.Text = "bill payment_test";
      // 
      // Label9
      // 
      this.Label9.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label9.Location = new System.Drawing.Point(58, 17);
      this.Label9.Name = "Label9";
      this.Label9.Size = new System.Drawing.Size(58, 23);
      this.Label9.TabIndex = 16;
      this.Label9.Text = "Amount*:";
      this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // tbAmount
      // 
      this.tbAmount.Location = new System.Drawing.Point(122, 19);
      this.tbAmount.Name = "tbAmount";
      this.tbAmount.Size = new System.Drawing.Size(91, 20);
      this.tbAmount.TabIndex = 13;
      // 
      // dtpDueDate
      // 
      this.dtpDueDate.CustomFormat = "MM/dd/yyyy HH:mm:ss";
      this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpDueDate.Location = new System.Drawing.Point(122, 46);
      this.dtpDueDate.Name = "dtpDueDate";
      this.dtpDueDate.Size = new System.Drawing.Size(91, 20);
      this.dtpDueDate.TabIndex = 14;
      this.dtpDueDate.Value = new System.DateTime(2007, 5, 1, 0, 0, 0, 0);
      // 
      // Label3
      // 
      this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label3.Location = new System.Drawing.Point(58, 46);
      this.Label3.Name = "Label3";
      this.Label3.Size = new System.Drawing.Size(58, 23);
      this.Label3.TabIndex = 14;
      this.Label3.Text = "Due Date:";
      this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // bPayBill
      // 
      this.bPayBill.ForeColor = System.Drawing.SystemColors.ControlText;
      this.bPayBill.Location = new System.Drawing.Point(432, 52);
      this.bPayBill.Name = "bPayBill";
      this.bPayBill.Size = new System.Drawing.Size(75, 23);
      this.bPayBill.TabIndex = 16;
      this.bPayBill.Text = "Pay Bill";
      this.bPayBill.UseVisualStyleBackColor = true;
      this.bPayBill.Click += new System.EventHandler(this.bPayBill_Click);
      // 
      // gbLogin
      // 
      this.gbLogin.Controls.Add(this.tbFromBankId);
      this.gbLogin.Controls.Add(this.Label7);
      this.gbLogin.Controls.Add(this.tbFIUrl);
      this.gbLogin.Controls.Add(this.Label1);
      this.gbLogin.Controls.Add(this.tbFIOrganization);
      this.gbLogin.Controls.Add(this.tbFIId);
      this.gbLogin.Controls.Add(this.lblBankId);
      this.gbLogin.Controls.Add(this.lblFIOrganization);
      this.gbLogin.Controls.Add(this.bLogin);
      this.gbLogin.Controls.Add(this.Label5);
      this.gbLogin.Controls.Add(this.cbFromAccountType);
      this.gbLogin.Controls.Add(this.tbFromAccountId);
      this.gbLogin.Controls.Add(this.Label4);
      this.gbLogin.Controls.Add(this.tbUserId);
      this.gbLogin.Controls.Add(this.lblUserId);
      this.gbLogin.Controls.Add(this.tbPassword);
      this.gbLogin.Controls.Add(this.lblPassword);
      this.gbLogin.ForeColor = System.Drawing.SystemColors.Desktop;
      this.gbLogin.Location = new System.Drawing.Point(7, 104);
      this.gbLogin.Name = "gbLogin";
      this.gbLogin.Size = new System.Drawing.Size(520, 203);
      this.gbLogin.TabIndex = 2;
      this.gbLogin.TabStop = false;
      this.gbLogin.Text = "Login Information";
      // 
      // tbFromBankId
      // 
      this.tbFromBankId.Location = new System.Drawing.Point(77, 84);
      this.tbFromBankId.Name = "tbFromBankId";
      this.tbFromBankId.Size = new System.Drawing.Size(117, 20);
      this.tbFromBankId.TabIndex = 20;
      this.tbFromBankId.Text = "053000219";
      // 
      // Label7
      // 
      this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label7.Location = new System.Drawing.Point(6, 78);
      this.Label7.Name = "Label7";
      this.Label7.Size = new System.Drawing.Size(64, 26);
      this.Label7.TabIndex = 29;
      this.Label7.Text = "Bank Id*:";
      this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // tbFIUrl
      // 
      this.tbFIUrl.Location = new System.Drawing.Point(75, 58);
      this.tbFIUrl.Name = "tbFIUrl";
      this.tbFIUrl.Size = new System.Drawing.Size(432, 20);
      this.tbFIUrl.TabIndex = 19;
      this.tbFIUrl.Text = "https://pfmpw.wachovia.com/cgi-forte/fortecgi?servicename=ofx&pagename=PFM\"";
      // 
      // Label1
      // 
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.Location = new System.Drawing.Point(11, 61);
      this.Label1.Name = "Label1";
      this.Label1.Size = new System.Drawing.Size(58, 17);
      this.Label1.TabIndex = 27;
      this.Label1.Text = "FI URL:";
      this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // tbFIOrganization
      // 
      this.tbFIOrganization.Location = new System.Drawing.Point(75, 30);
      this.tbFIOrganization.Name = "tbFIOrganization";
      this.tbFIOrganization.Size = new System.Drawing.Size(117, 20);
      this.tbFIOrganization.TabIndex = 17;
      this.tbFIOrganization.Text = "Wachovia";
      // 
      // tbFIId
      // 
      this.tbFIId.Location = new System.Drawing.Point(251, 30);
      this.tbFIId.Name = "tbFIId";
      this.tbFIId.Size = new System.Drawing.Size(79, 20);
      this.tbFIId.TabIndex = 18;
      this.tbFIId.Text = "4309";
      this.tbFIId.TextChanged += new System.EventHandler(this.tbFIId_TextChanged);
      // 
      // lblBankId
      // 
      this.lblBankId.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblBankId.Location = new System.Drawing.Point(198, 34);
      this.lblBankId.Name = "lblBankId";
      this.lblBankId.Size = new System.Drawing.Size(47, 11);
      this.lblBankId.TabIndex = 26;
      this.lblBankId.Text = "FI ID:";
      this.lblBankId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lblFIOrganization
      // 
      this.lblFIOrganization.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblFIOrganization.Location = new System.Drawing.Point(16, 33);
      this.lblFIOrganization.Name = "lblFIOrganization";
      this.lblFIOrganization.Size = new System.Drawing.Size(53, 17);
      this.lblFIOrganization.TabIndex = 23;
      this.lblFIOrganization.Text = "Bank:";
      this.lblFIOrganization.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // bLogin
      // 
      this.bLogin.Location = new System.Drawing.Point(432, 167);
      this.bLogin.Name = "bLogin";
      this.bLogin.Size = new System.Drawing.Size(75, 23);
      this.bLogin.TabIndex = 4;
      this.bLogin.Text = "Login";
      this.bLogin.UseVisualStyleBackColor = true;
      this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
      // 
      // Label5
      // 
      this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label5.Location = new System.Drawing.Point(213, 138);
      this.Label5.Name = "Label5";
      this.Label5.Size = new System.Drawing.Size(95, 23);
      this.Label5.TabIndex = 19;
      this.Label5.Text = "Account Type*:";
      this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // cbFromAccountType
      // 
      this.cbFromAccountType.Items.AddRange(new object[] {
            "Checking",
            "Savings",
            "Money Market",
            "Line of Credit",
            "Credit Card"});
      this.cbFromAccountType.Location = new System.Drawing.Point(314, 140);
      this.cbFromAccountType.Name = "cbFromAccountType";
      this.cbFromAccountType.Size = new System.Drawing.Size(193, 21);
      this.cbFromAccountType.TabIndex = 3;
      this.cbFromAccountType.Text = "Checking";
      // 
      // tbFromAccountId
      // 
      this.tbFromAccountId.Location = new System.Drawing.Point(314, 84);
      this.tbFromAccountId.Name = "tbFromAccountId";
      this.tbFromAccountId.Size = new System.Drawing.Size(193, 20);
      this.tbFromAccountId.TabIndex = 0;
      // 
      // Label4
      // 
      this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label4.Location = new System.Drawing.Point(213, 81);
      this.Label4.Name = "Label4";
      this.Label4.Size = new System.Drawing.Size(95, 23);
      this.Label4.TabIndex = 18;
      this.Label4.Text = "Account Number*:";
      this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // tbUserId
      // 
      this.tbUserId.Location = new System.Drawing.Point(77, 140);
      this.tbUserId.Name = "tbUserId";
      this.tbUserId.Size = new System.Drawing.Size(117, 20);
      this.tbUserId.TabIndex = 1;
      // 
      // lblUserId
      // 
      this.lblUserId.ForeColor = System.Drawing.Color.Maroon;
      this.lblUserId.Location = new System.Drawing.Point(10, 137);
      this.lblUserId.Name = "lblUserId";
      this.lblUserId.Size = new System.Drawing.Size(60, 23);
      this.lblUserId.TabIndex = 2;
      this.lblUserId.Text = "User Id*:";
      this.lblUserId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // tbPassword
      // 
      this.tbPassword.Location = new System.Drawing.Point(77, 166);
      this.tbPassword.Name = "tbPassword";
      this.tbPassword.PasswordChar = '*';
      this.tbPassword.Size = new System.Drawing.Size(117, 20);
      this.tbPassword.TabIndex = 2;
      // 
      // lblPassword
      // 
      this.lblPassword.ForeColor = System.Drawing.Color.Maroon;
      this.lblPassword.Location = new System.Drawing.Point(2, 164);
      this.lblPassword.Name = "lblPassword";
      this.lblPassword.Size = new System.Drawing.Size(69, 23);
      this.lblPassword.TabIndex = 3;
      this.lblPassword.Text = "Password*:";
      this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lblNotice
      // 
      this.lblNotice.ForeColor = System.Drawing.SystemColors.Highlight;
      this.lblNotice.Location = new System.Drawing.Point(13, 10);
      this.lblNotice.Name = "lblNotice";
      this.lblNotice.Size = new System.Drawing.Size(514, 91);
      this.lblNotice.TabIndex = 0;
      this.lblNotice.Text = resources.GetString("lblNotice.Text");
      // 
      // billpayment1
      // 
      this.billpayment1.Payee.Country = "US";
      this.billpayment1.OnSyncPayees += new DPayments.InEBank.Billpayment.OnSyncPayeesHandler(this.billpayment1_OnSyncPayees);
      // 
      // billpaymentDemo
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(532, 679);
      this.Controls.Add(this.GroupBox4);
      this.Controls.Add(this.GroupBox3);
      this.Controls.Add(this.gbAddTransfer);
      this.Controls.Add(this.gbLogin);
      this.Controls.Add(this.lblNotice);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.Name = "billpaymentDemo";
      this.Text = "Bill Payment Demo";
      this.Load += new System.EventHandler(this.BillPayment_Load);
      this.GroupBox4.ResumeLayout(false);
      this.GroupBox4.PerformLayout();
      this.GroupBox3.ResumeLayout(false);
      this.gbAddTransfer.ResumeLayout(false);
      this.gbAddTransfer.PerformLayout();
      this.gbLogin.ResumeLayout(false);
      this.gbLogin.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    internal System.Windows.Forms.GroupBox GroupBox4;
    internal System.Windows.Forms.TextBox tbAccount;
    internal System.Windows.Forms.Label Label22;
    internal System.Windows.Forms.TextBox tbPhone;
    internal System.Windows.Forms.Label Label21;
    internal System.Windows.Forms.Label Label20;
    internal System.Windows.Forms.TextBox tbPostalCode;
    internal System.Windows.Forms.TextBox tbState;
    internal System.Windows.Forms.Label Label19;
    internal System.Windows.Forms.TextBox tbCity;
    internal System.Windows.Forms.Label Label18;
    internal System.Windows.Forms.TextBox tbAddr2;
    internal System.Windows.Forms.Label Label16;
    internal System.Windows.Forms.Label Label2;
    internal System.Windows.Forms.TextBox tbAddr1;
    internal System.Windows.Forms.Label Label17;
    internal System.Windows.Forms.GroupBox GroupBox3;
    internal System.Windows.Forms.Label lblCurrency;
    internal System.Windows.Forms.Label Label25;
    internal System.Windows.Forms.Label lblPaymentId;
    internal System.Windows.Forms.Label Label15;
    internal System.Windows.Forms.Label lblStatus;
    internal System.Windows.Forms.Label lblPaymentDate;
    internal System.Windows.Forms.Label lblCheckNumber;
    internal System.Windows.Forms.Label Label13;
    internal System.Windows.Forms.Label Label12;
    internal System.Windows.Forms.Label Label11;
    internal System.Windows.Forms.GroupBox gbAddTransfer;
    internal System.Windows.Forms.Label Label23;
    internal System.Windows.Forms.TextBox tbMemo;
    internal System.Windows.Forms.Label Label9;
    internal System.Windows.Forms.TextBox tbAmount;
    internal System.Windows.Forms.DateTimePicker dtpDueDate;
    internal System.Windows.Forms.Label Label3;
    internal System.Windows.Forms.Button bPayBill;
    internal System.Windows.Forms.GroupBox gbLogin;
    internal System.Windows.Forms.TextBox tbUserId;
    internal System.Windows.Forms.Label lblUserId;
    internal System.Windows.Forms.TextBox tbPassword;
    internal System.Windows.Forms.Label lblPassword;
    internal System.Windows.Forms.Label lblNotice;
    private DPayments.InEBank.Billpayment billpayment1;
    private System.Windows.Forms.ComboBox cbName;
    internal System.Windows.Forms.TextBox tbFromBankId;
    internal System.Windows.Forms.Label Label7;
    internal System.Windows.Forms.TextBox tbFIUrl;
    internal System.Windows.Forms.Label Label1;
    internal System.Windows.Forms.TextBox tbFIOrganization;
    internal System.Windows.Forms.TextBox tbFIId;
    internal System.Windows.Forms.Label lblBankId;
    internal System.Windows.Forms.Label lblFIOrganization;
    private System.Windows.Forms.Button bLogin;
    internal System.Windows.Forms.Label Label5;
    internal System.Windows.Forms.ComboBox cbFromAccountType;
    internal System.Windows.Forms.TextBox tbFromAccountId;
    internal System.Windows.Forms.Label Label4;
  }
}

