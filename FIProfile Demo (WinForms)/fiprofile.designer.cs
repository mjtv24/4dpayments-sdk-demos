namespace DPayments.Demos
{
  partial class fiprofileDemo
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fiprofileDemo));
      this.btnGet = new System.Windows.Forms.Button();
      this.txtFIId = new System.Windows.Forms.TextBox();
      this.GroupBox1 = new System.Windows.Forms.GroupBox();
      this.Label4 = new System.Windows.Forms.Label();
      this.cmbBank = new System.Windows.Forms.ComboBox();
      this.lblBank = new System.Windows.Forms.Label();
      this.txtURL = new System.Windows.Forms.TextBox();
      this.Label1 = new System.Windows.Forms.Label();
      this.Label5 = new System.Windows.Forms.Label();
      this.txtUserID = new System.Windows.Forms.TextBox();
      this.Label2 = new System.Windows.Forms.Label();
      this.txtFIOrganization = new System.Windows.Forms.TextBox();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.Label3 = new System.Windows.Forms.Label();
      this.lblHeader = new System.Windows.Forms.Label();
      this.fiprofile1 = new DPayments.InEBank.Fiprofile(this.components);
      this.GroupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnGet
      // 
      this.btnGet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnGet.ForeColor = System.Drawing.SystemColors.ControlText;
      this.btnGet.Location = new System.Drawing.Point(409, 154);
      this.btnGet.Name = "btnGet";
      this.btnGet.Size = new System.Drawing.Size(152, 23);
      this.btnGet.TabIndex = 6;
      this.btnGet.Text = "Get FI Profile";
      this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
      // 
      // txtFIId
      // 
      this.txtFIId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.txtFIId.Location = new System.Drawing.Point(138, 104);
      this.txtFIId.Name = "txtFIId";
      this.txtFIId.Size = new System.Drawing.Size(204, 20);
      this.txtFIId.TabIndex = 3;
      this.txtFIId.Text = "3101";
      // 
      // GroupBox1
      // 
      this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.GroupBox1.Controls.Add(this.Label4);
      this.GroupBox1.Controls.Add(this.cmbBank);
      this.GroupBox1.Controls.Add(this.lblBank);
      this.GroupBox1.Controls.Add(this.txtURL);
      this.GroupBox1.Controls.Add(this.Label1);
      this.GroupBox1.Controls.Add(this.btnGet);
      this.GroupBox1.Controls.Add(this.txtFIId);
      this.GroupBox1.Controls.Add(this.Label5);
      this.GroupBox1.Controls.Add(this.txtUserID);
      this.GroupBox1.Controls.Add(this.Label2);
      this.GroupBox1.Controls.Add(this.txtFIOrganization);
      this.GroupBox1.Controls.Add(this.txtPassword);
      this.GroupBox1.Controls.Add(this.Label3);
      this.GroupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
      this.GroupBox1.Location = new System.Drawing.Point(9, 65);
      this.GroupBox1.Name = "GroupBox1";
      this.GroupBox1.Size = new System.Drawing.Size(598, 197);
      this.GroupBox1.TabIndex = 0;
      this.GroupBox1.TabStop = false;
      this.GroupBox1.Text = "FI Profile Request";
      // 
      // Label4
      // 
      this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label4.Location = new System.Drawing.Point(26, 79);
      this.Label4.Name = "Label4";
      this.Label4.Size = new System.Drawing.Size(112, 16);
      this.Label4.TabIndex = 9;
      this.Label4.Text = "FI Organization:";
      this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // cmbBank
      // 
      this.cmbBank.Items.AddRange(new object[] {
            "American Express",
            "Bank of America",
            "Bank One - JPMorgan Chase",
            "BB&T - Branch Banking and Trust Company",
            "Chase (credit card)",
            "E*TRADE",
            "Edward Jones",
            "Fidelity Investments",
            "Merrill Lynch & Co.",
            "Regions Bank",
            "TD Ameritrade",
            "Wachovia Bank",
            "Wells Fargo Investments",
            "(YOUR BANK NAME)"});
      this.cmbBank.Location = new System.Drawing.Point(138, 25);
      this.cmbBank.Name = "cmbBank";
      this.cmbBank.Size = new System.Drawing.Size(450, 21);
      this.cmbBank.TabIndex = 0;
      this.cmbBank.Text = "American Express";
      this.cmbBank.SelectedIndexChanged += new System.EventHandler(this.cmbBank_SelectedIndexChanged);
      // 
      // lblBank
      // 
      this.lblBank.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblBank.Location = new System.Drawing.Point(21, 23);
      this.lblBank.Name = "lblBank";
      this.lblBank.Size = new System.Drawing.Size(117, 23);
      this.lblBank.TabIndex = 7;
      this.lblBank.Text = "Bank Common Name:";
      this.lblBank.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtURL
      // 
      this.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.txtURL.Location = new System.Drawing.Point(138, 52);
      this.txtURL.Name = "txtURL";
      this.txtURL.Size = new System.Drawing.Size(450, 20);
      this.txtURL.TabIndex = 1;
      this.txtURL.Text = "https://online.americanexpress.com/myca/ofxdl/desktop/desktopDownload.do?request_type=nl_ofxdownload";
      // 
      // Label1
      // 
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.Location = new System.Drawing.Point(60, 53);
      this.Label1.Name = "Label1";
      this.Label1.Size = new System.Drawing.Size(78, 16);
      this.Label1.TabIndex = 8;
      this.Label1.Text = "FI URL:";
      this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // Label5
      // 
      this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label5.Location = new System.Drawing.Point(34, 104);
      this.Label5.Name = "Label5";
      this.Label5.Size = new System.Drawing.Size(104, 16);
      this.Label5.TabIndex = 10;
      this.Label5.Text = "FI ID:";
      this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtUserID
      // 
      this.txtUserID.Location = new System.Drawing.Point(138, 130);
      this.txtUserID.Name = "txtUserID";
      this.txtUserID.Size = new System.Drawing.Size(204, 20);
      this.txtUserID.TabIndex = 4;
      this.txtUserID.Text = "anonymous00000000000000000000000";
      // 
      // Label2
      // 
      this.Label2.ForeColor = System.Drawing.Color.Maroon;
      this.Label2.Location = new System.Drawing.Point(90, 131);
      this.Label2.Name = "Label2";
      this.Label2.Size = new System.Drawing.Size(48, 16);
      this.Label2.TabIndex = 11;
      this.Label2.Text = "UserID:";
      this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtFIOrganization
      // 
      this.txtFIOrganization.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.txtFIOrganization.Location = new System.Drawing.Point(138, 78);
      this.txtFIOrganization.Name = "txtFIOrganization";
      this.txtFIOrganization.Size = new System.Drawing.Size(204, 20);
      this.txtFIOrganization.TabIndex = 2;
      this.txtFIOrganization.Text = "AMEX";
      // 
      // txtPassword
      // 
      this.txtPassword.Location = new System.Drawing.Point(138, 156);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.PasswordChar = '*';
      this.txtPassword.Size = new System.Drawing.Size(204, 20);
      this.txtPassword.TabIndex = 5;
      this.txtPassword.Text = "anonymous00000000000000000000000";
      // 
      // Label3
      // 
      this.Label3.ForeColor = System.Drawing.Color.Maroon;
      this.Label3.Location = new System.Drawing.Point(74, 157);
      this.Label3.Name = "Label3";
      this.Label3.Size = new System.Drawing.Size(64, 16);
      this.Label3.TabIndex = 12;
      this.Label3.Text = "Password:";
      this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lblHeader
      // 
      this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.lblHeader.ForeColor = System.Drawing.SystemColors.Highlight;
      this.lblHeader.Location = new System.Drawing.Point(9, 9);
      this.lblHeader.Name = "lblHeader";
      this.lblHeader.Size = new System.Drawing.Size(598, 40);
      this.lblHeader.TabIndex = 1;
      this.lblHeader.Text = resources.GetString("lblHeader.Text");
      // 
      // fiprofileDemo
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(616, 274);
      this.Controls.Add(this.GroupBox1);
      this.Controls.Add(this.lblHeader);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.Name = "fiprofileDemo";
      this.Text = "FI Profile Demo";
      this.GroupBox1.ResumeLayout(false);
      this.GroupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    internal System.Windows.Forms.Button btnGet;
    internal System.Windows.Forms.TextBox txtFIId;
    internal System.Windows.Forms.GroupBox GroupBox1;
    internal System.Windows.Forms.Label Label5;
    internal System.Windows.Forms.TextBox txtUserID;
    internal System.Windows.Forms.Label Label2;
    internal System.Windows.Forms.TextBox txtFIOrganization;
    internal System.Windows.Forms.TextBox txtPassword;
    internal System.Windows.Forms.Label Label3;
    internal System.Windows.Forms.Label lblHeader;
    private DPayments.InEBank.Fiprofile fiprofile1;
    internal System.Windows.Forms.Label Label4;
    internal System.Windows.Forms.ComboBox cmbBank;
    internal System.Windows.Forms.Label lblBank;
    internal System.Windows.Forms.TextBox txtURL;
    internal System.Windows.Forms.Label Label1;
  }
}

