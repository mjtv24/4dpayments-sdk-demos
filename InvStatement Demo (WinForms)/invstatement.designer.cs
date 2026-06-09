namespace DPayments.Demos
{
  partial class InvStatementDemo
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvStatementDemo));
      this.txtURL = new System.Windows.Forms.TextBox();
      this.Label10 = new System.Windows.Forms.Label();
      this.txtBrokerName = new System.Windows.Forms.TextBox();
      this.Label9 = new System.Windows.Forms.Label();
      this.GroupBox2 = new System.Windows.Forms.GroupBox();
      this.Label11 = new System.Windows.Forms.Label();
      this.btnRead = new System.Windows.Forms.Button();
      this.txtFileName = new System.Windows.Forms.TextBox();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.Label1 = new System.Windows.Forms.Label();
      this.txtUserID = new System.Windows.Forms.TextBox();
      this.Label4 = new System.Windows.Forms.Label();
      this.Label5 = new System.Windows.Forms.Label();
      this.txtBrokerId = new System.Windows.Forms.TextBox();
      this.txtAccountNumber = new System.Windows.Forms.TextBox();
      this.GroupBox1 = new System.Windows.Forms.GroupBox();
      this.Label3 = new System.Windows.Forms.Label();
      this.Label2 = new System.Windows.Forms.Label();
      this.chkbInclTx = new System.Windows.Forms.CheckBox();
      this.chkbInclPos = new System.Windows.Forms.CheckBox();
      this.chkbInclOpnOrd = new System.Windows.Forms.CheckBox();
      this.chkbInclBal = new System.Windows.Forms.CheckBox();
      this.btnGetStatement = new System.Windows.Forms.Button();
      this.invstatement1 = new DPayments.InEBank.Invstatement(this.components);
      this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
      this.lblEndDate = new System.Windows.Forms.Label();
      this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
      this.lblStartDate = new System.Windows.Forms.Label();
      this.GroupBox2.SuspendLayout();
      this.GroupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // txtURL
      // 
      this.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.txtURL.Location = new System.Drawing.Point(120, 32);
      this.txtURL.Name = "txtURL";
      this.txtURL.Size = new System.Drawing.Size(480, 20);
      this.txtURL.TabIndex = 0;
      this.txtURL.Text = "https://ofxs.ameritrade.com/cgi-bin/apps/OFX";
      // 
      // Label10
      // 
      this.Label10.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label10.Location = new System.Drawing.Point(72, 32);
      this.Label10.Name = "Label10";
      this.Label10.Size = new System.Drawing.Size(48, 23);
      this.Label10.TabIndex = 13;
      this.Label10.Text = "FI URL:";
      this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtBrokerName
      // 
      this.txtBrokerName.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.txtBrokerName.Location = new System.Drawing.Point(120, 56);
      this.txtBrokerName.Name = "txtBrokerName";
      this.txtBrokerName.Size = new System.Drawing.Size(152, 20);
      this.txtBrokerName.TabIndex = 1;
      this.txtBrokerName.Text = "Ameritrade";
      // 
      // Label9
      // 
      this.Label9.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label9.Location = new System.Drawing.Point(8, 56);
      this.Label9.Name = "Label9";
      this.Label9.Size = new System.Drawing.Size(112, 23);
      this.Label9.TabIndex = 14;
      this.Label9.Text = "Organization Name:";
      this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // GroupBox2
      // 
      this.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.GroupBox2.Controls.Add(this.Label11);
      this.GroupBox2.Controls.Add(this.btnRead);
      this.GroupBox2.Controls.Add(this.txtFileName);
      this.GroupBox2.ForeColor = System.Drawing.SystemColors.Desktop;
      this.GroupBox2.Location = new System.Drawing.Point(8, 323);
      this.GroupBox2.Name = "GroupBox2";
      this.GroupBox2.Size = new System.Drawing.Size(640, 83);
      this.GroupBox2.TabIndex = 1;
      this.GroupBox2.TabStop = false;
      this.GroupBox2.Text = "Read From OFX File";
      // 
      // Label11
      // 
      this.Label11.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.Label11.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label11.Location = new System.Drawing.Point(56, 27);
      this.Label11.Name = "Label11";
      this.Label11.Size = new System.Drawing.Size(64, 23);
      this.Label11.TabIndex = 2;
      this.Label11.Text = "File Name:";
      this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // btnRead
      // 
      this.btnRead.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnRead.ForeColor = System.Drawing.SystemColors.ControlText;
      this.btnRead.Location = new System.Drawing.Point(336, 27);
      this.btnRead.Name = "btnRead";
      this.btnRead.Size = new System.Drawing.Size(208, 23);
      this.btnRead.TabIndex = 1;
      this.btnRead.Text = "Read OFX File";
      this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
      // 
      // txtFileName
      // 
      this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.txtFileName.Location = new System.Drawing.Point(120, 27);
      this.txtFileName.Name = "txtFileName";
      this.txtFileName.Size = new System.Drawing.Size(152, 20);
      this.txtFileName.TabIndex = 0;
      this.txtFileName.Text = "..\\..\\investment.txt";
      // 
      // txtPassword
      // 
      this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.txtPassword.Location = new System.Drawing.Point(120, 152);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.PasswordChar = '*';
      this.txtPassword.Size = new System.Drawing.Size(152, 20);
      this.txtPassword.TabIndex = 5;
      // 
      // Label1
      // 
      this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.Label1.ForeColor = System.Drawing.SystemColors.Highlight;
      this.Label1.Location = new System.Drawing.Point(5, 10);
      this.Label1.Name = "Label1";
      this.Label1.Size = new System.Drawing.Size(648, 56);
      this.Label1.TabIndex = 2;
      this.Label1.Text = resources.GetString("Label1.Text");
      // 
      // txtUserID
      // 
      this.txtUserID.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.txtUserID.Location = new System.Drawing.Point(120, 128);
      this.txtUserID.Name = "txtUserID";
      this.txtUserID.Size = new System.Drawing.Size(152, 20);
      this.txtUserID.TabIndex = 4;
      // 
      // Label4
      // 
      this.Label4.ForeColor = System.Drawing.Color.DarkRed;
      this.Label4.Location = new System.Drawing.Point(24, 128);
      this.Label4.Name = "Label4";
      this.Label4.Size = new System.Drawing.Size(96, 23);
      this.Label4.TabIndex = 17;
      this.Label4.Text = "User ID:";
      this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // Label5
      // 
      this.Label5.ForeColor = System.Drawing.Color.DarkRed;
      this.Label5.Location = new System.Drawing.Point(24, 152);
      this.Label5.Name = "Label5";
      this.Label5.Size = new System.Drawing.Size(96, 23);
      this.Label5.TabIndex = 18;
      this.Label5.Text = "Password:";
      this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtBrokerId
      // 
      this.txtBrokerId.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.txtBrokerId.Location = new System.Drawing.Point(120, 80);
      this.txtBrokerId.Name = "txtBrokerId";
      this.txtBrokerId.Size = new System.Drawing.Size(152, 20);
      this.txtBrokerId.TabIndex = 2;
      this.txtBrokerId.Text = "ameritrade";
      // 
      // txtAccountNumber
      // 
      this.txtAccountNumber.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.txtAccountNumber.Location = new System.Drawing.Point(120, 104);
      this.txtAccountNumber.Name = "txtAccountNumber";
      this.txtAccountNumber.Size = new System.Drawing.Size(152, 20);
      this.txtAccountNumber.TabIndex = 3;
      // 
      // GroupBox1
      // 
      this.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.GroupBox1.Controls.Add(this.dtpEndDate);
      this.GroupBox1.Controls.Add(this.lblEndDate);
      this.GroupBox1.Controls.Add(this.dtpStartDate);
      this.GroupBox1.Controls.Add(this.lblStartDate);
      this.GroupBox1.Controls.Add(this.txtURL);
      this.GroupBox1.Controls.Add(this.Label10);
      this.GroupBox1.Controls.Add(this.txtBrokerName);
      this.GroupBox1.Controls.Add(this.Label9);
      this.GroupBox1.Controls.Add(this.txtPassword);
      this.GroupBox1.Controls.Add(this.txtUserID);
      this.GroupBox1.Controls.Add(this.Label4);
      this.GroupBox1.Controls.Add(this.Label5);
      this.GroupBox1.Controls.Add(this.txtAccountNumber);
      this.GroupBox1.Controls.Add(this.txtBrokerId);
      this.GroupBox1.Controls.Add(this.Label3);
      this.GroupBox1.Controls.Add(this.Label2);
      this.GroupBox1.Controls.Add(this.chkbInclTx);
      this.GroupBox1.Controls.Add(this.chkbInclPos);
      this.GroupBox1.Controls.Add(this.chkbInclOpnOrd);
      this.GroupBox1.Controls.Add(this.chkbInclBal);
      this.GroupBox1.Controls.Add(this.btnGetStatement);
      this.GroupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
      this.GroupBox1.Location = new System.Drawing.Point(8, 69);
      this.GroupBox1.Name = "GroupBox1";
      this.GroupBox1.Size = new System.Drawing.Size(640, 248);
      this.GroupBox1.TabIndex = 0;
      this.GroupBox1.TabStop = false;
      this.GroupBox1.Text = "Connect Directly To OFX Server";
      // 
      // Label3
      // 
      this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label3.Location = new System.Drawing.Point(24, 80);
      this.Label3.Name = "Label3";
      this.Label3.Size = new System.Drawing.Size(96, 23);
      this.Label3.TabIndex = 15;
      this.Label3.Text = "Broker ID:";
      this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // Label2
      // 
      this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label2.Location = new System.Drawing.Point(24, 104);
      this.Label2.Name = "Label2";
      this.Label2.Size = new System.Drawing.Size(96, 23);
      this.Label2.TabIndex = 16;
      this.Label2.Text = "Account Number:";
      this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // chkbInclTx
      // 
      this.chkbInclTx.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.chkbInclTx.Checked = true;
      this.chkbInclTx.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chkbInclTx.ForeColor = System.Drawing.SystemColors.ControlText;
      this.chkbInclTx.Location = new System.Drawing.Point(336, 64);
      this.chkbInclTx.Name = "chkbInclTx";
      this.chkbInclTx.Size = new System.Drawing.Size(192, 24);
      this.chkbInclTx.TabIndex = 8;
      this.chkbInclTx.Text = "Include Investment Transactions";
      // 
      // chkbInclPos
      // 
      this.chkbInclPos.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.chkbInclPos.Checked = true;
      this.chkbInclPos.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chkbInclPos.ForeColor = System.Drawing.SystemColors.ControlText;
      this.chkbInclPos.Location = new System.Drawing.Point(336, 88);
      this.chkbInclPos.Name = "chkbInclPos";
      this.chkbInclPos.Size = new System.Drawing.Size(136, 24);
      this.chkbInclPos.TabIndex = 9;
      this.chkbInclPos.Text = "Include Positions";
      // 
      // chkbInclOpnOrd
      // 
      this.chkbInclOpnOrd.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.chkbInclOpnOrd.Checked = true;
      this.chkbInclOpnOrd.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chkbInclOpnOrd.ForeColor = System.Drawing.SystemColors.ControlText;
      this.chkbInclOpnOrd.Location = new System.Drawing.Point(336, 112);
      this.chkbInclOpnOrd.Name = "chkbInclOpnOrd";
      this.chkbInclOpnOrd.Size = new System.Drawing.Size(136, 24);
      this.chkbInclOpnOrd.TabIndex = 10;
      this.chkbInclOpnOrd.Text = "Include Open Orders";
      // 
      // chkbInclBal
      // 
      this.chkbInclBal.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.chkbInclBal.Checked = true;
      this.chkbInclBal.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chkbInclBal.ForeColor = System.Drawing.SystemColors.ControlText;
      this.chkbInclBal.Location = new System.Drawing.Point(336, 136);
      this.chkbInclBal.Name = "chkbInclBal";
      this.chkbInclBal.Size = new System.Drawing.Size(136, 24);
      this.chkbInclBal.TabIndex = 11;
      this.chkbInclBal.Text = "Include Balances";
      // 
      // btnGetStatement
      // 
      this.btnGetStatement.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnGetStatement.ForeColor = System.Drawing.SystemColors.ControlText;
      this.btnGetStatement.Location = new System.Drawing.Point(336, 197);
      this.btnGetStatement.Name = "btnGetStatement";
      this.btnGetStatement.Size = new System.Drawing.Size(208, 23);
      this.btnGetStatement.TabIndex = 12;
      this.btnGetStatement.Text = "Get Statement From OFX Server";
      this.btnGetStatement.Click += new System.EventHandler(this.btnGetStatement_Click);
      // 
      // dtpEndDate
      // 
      this.dtpEndDate.CustomFormat = "MM/dd/yyyy HH:mm:ss";
      this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtpEndDate.Location = new System.Drawing.Point(120, 206);
      this.dtpEndDate.Name = "dtpEndDate";
      this.dtpEndDate.Size = new System.Drawing.Size(152, 20);
      this.dtpEndDate.TabIndex = 7;
      this.dtpEndDate.Value = new System.DateTime(2009, 9, 1, 0, 0, 0, 0);
      // 
      // lblEndDate
      // 
      this.lblEndDate.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblEndDate.Location = new System.Drawing.Point(21, 205);
      this.lblEndDate.Name = "lblEndDate";
      this.lblEndDate.Size = new System.Drawing.Size(99, 23);
      this.lblEndDate.TabIndex = 20;
      this.lblEndDate.Text = "End Date:";
      this.lblEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // dtpStartDate
      // 
      this.dtpStartDate.CustomFormat = "MM/dd/yyyy HH:mm:ss";
      this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtpStartDate.Location = new System.Drawing.Point(120, 178);
      this.dtpStartDate.Name = "dtpStartDate";
      this.dtpStartDate.Size = new System.Drawing.Size(152, 20);
      this.dtpStartDate.TabIndex = 6;
      this.dtpStartDate.Value = new System.DateTime(2009, 5, 1, 0, 0, 0, 0);
      // 
      // lblStartDate
      // 
      this.lblStartDate.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblStartDate.Location = new System.Drawing.Point(21, 177);
      this.lblStartDate.Name = "lblStartDate";
      this.lblStartDate.Size = new System.Drawing.Size(99, 23);
      this.lblStartDate.TabIndex = 19;
      this.lblStartDate.Text = "Start Date:";
      this.lblStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // InvStatementDemo
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(658, 418);
      this.Controls.Add(this.GroupBox2);
      this.Controls.Add(this.Label1);
      this.Controls.Add(this.GroupBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.Name = "InvStatementDemo";
      this.Text = "Investment Statement Demo";
      this.GroupBox2.ResumeLayout(false);
      this.GroupBox2.PerformLayout();
      this.GroupBox1.ResumeLayout(false);
      this.GroupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    internal System.Windows.Forms.TextBox txtURL;
    internal System.Windows.Forms.Label Label10;
    internal System.Windows.Forms.TextBox txtBrokerName;
    internal System.Windows.Forms.Label Label9;
    internal System.Windows.Forms.GroupBox GroupBox2;
    internal System.Windows.Forms.Label Label11;
    internal System.Windows.Forms.Button btnRead;
    internal System.Windows.Forms.TextBox txtFileName;
    internal System.Windows.Forms.TextBox txtPassword;
    internal System.Windows.Forms.Label Label1;
    internal System.Windows.Forms.TextBox txtUserID;
    internal System.Windows.Forms.Label Label4;
    internal System.Windows.Forms.Label Label5;
    internal System.Windows.Forms.TextBox txtBrokerId;
    internal System.Windows.Forms.TextBox txtAccountNumber;
    internal System.Windows.Forms.GroupBox GroupBox1;
    internal System.Windows.Forms.Label Label3;
    internal System.Windows.Forms.Label Label2;
    internal System.Windows.Forms.CheckBox chkbInclTx;
    internal System.Windows.Forms.CheckBox chkbInclPos;
    internal System.Windows.Forms.CheckBox chkbInclOpnOrd;
    internal System.Windows.Forms.CheckBox chkbInclBal;
    internal System.Windows.Forms.Button btnGetStatement;
    private DPayments.InEBank.Invstatement invstatement1;
    private System.Windows.Forms.DateTimePicker dtpEndDate;
    private System.Windows.Forms.Label lblEndDate;
    private System.Windows.Forms.DateTimePicker dtpStartDate;
    private System.Windows.Forms.Label lblStartDate;
  }
}

