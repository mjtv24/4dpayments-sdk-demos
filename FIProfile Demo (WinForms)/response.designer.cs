namespace DPayments.Demos
{
  partial class ResponseDemo
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
      this.lvMessageSets = new System.Windows.Forms.ListView();
      this.MSName = new System.Windows.Forms.ColumnHeader();
      this.SecurityLevel = new System.Windows.Forms.ColumnHeader();
      this.TransportSecurity = new System.Windows.Forms.ColumnHeader();
      this.Recovery = new System.Windows.Forms.ColumnHeader();
      this.MSRefresh = new System.Windows.Forms.ColumnHeader();
      this.SyncMode = new System.Windows.Forms.ColumnHeader();
      this.TxImage = new System.Windows.Forms.ColumnHeader();
      this.ClosingInfo = new System.Windows.Forms.ColumnHeader();
      this.ClosingInfoImage = new System.Windows.Forms.ColumnHeader();
      this.Url = new System.Windows.Forms.ColumnHeader();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.lsvwGeneralInfo = new System.Windows.Forms.ListView();
      this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
      this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
      this.lsvwSignOnInfo = new System.Windows.Forms.ListView();
      this.ColumnHeader2 = new System.Windows.Forms.ColumnHeader();
      this.GroupBox2 = new System.Windows.Forms.GroupBox();
      this.btnOk = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.GroupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // lvMessageSets
      // 
      this.lvMessageSets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.lvMessageSets.BackColor = System.Drawing.SystemColors.ControlLight;
      this.lvMessageSets.CausesValidation = false;
      this.lvMessageSets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MSName,
            this.SecurityLevel,
            this.TransportSecurity,
            this.Recovery,
            this.MSRefresh,
            this.SyncMode,
            this.TxImage,
            this.ClosingInfo,
            this.ClosingInfoImage,
            this.Url});
      this.lvMessageSets.GridLines = true;
      this.lvMessageSets.Location = new System.Drawing.Point(10, 19);
      this.lvMessageSets.MultiSelect = false;
      this.lvMessageSets.Name = "lvMessageSets";
      this.lvMessageSets.Size = new System.Drawing.Size(892, 151);
      this.lvMessageSets.TabIndex = 0;
      this.lvMessageSets.UseCompatibleStateImageBehavior = false;
      this.lvMessageSets.View = System.Windows.Forms.View.Details;
      // 
      // MSName
      // 
      this.MSName.Text = "MessageSet Name";
      this.MSName.Width = 116;
      // 
      // SecurityLevel
      // 
      this.SecurityLevel.Text = "Security Level";
      this.SecurityLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.SecurityLevel.Width = 82;
      // 
      // TransportSecurity
      // 
      this.TransportSecurity.Text = "Transport Security";
      this.TransportSecurity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.TransportSecurity.Width = 101;
      // 
      // Recovery
      // 
      this.Recovery.Text = "Recovery";
      this.Recovery.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.Recovery.Width = 61;
      // 
      // MSRefresh
      // 
      this.MSRefresh.Text = "Refresh";
      this.MSRefresh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.MSRefresh.Width = 53;
      // 
      // SyncMode
      // 
      this.SyncMode.Text = "Sync Mode";
      this.SyncMode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.SyncMode.Width = 69;
      // 
      // TxImage
      // 
      this.TxImage.Text = "Tx Image";
      this.TxImage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.TxImage.Width = 59;
      // 
      // ClosingInfo
      // 
      this.ClosingInfo.Text = "Closing Info";
      this.ClosingInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.ClosingInfo.Width = 70;
      // 
      // ClosingInfoImage
      // 
      this.ClosingInfoImage.Text = "Closing Info Image";
      this.ClosingInfoImage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.ClosingInfoImage.Width = 102;
      // 
      // Url
      // 
      this.Url.Text = "Url";
      this.Url.Width = 160;
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.lsvwGeneralInfo);
      this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
      this.groupBox1.Location = new System.Drawing.Point(10, 13);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(450, 285);
      this.groupBox1.TabIndex = 5;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "General Information on FI Profile";
      // 
      // lsvwGeneralInfo
      // 
      this.lsvwGeneralInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.lsvwGeneralInfo.BackColor = System.Drawing.SystemColors.ControlLight;
      this.lsvwGeneralInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
      this.lsvwGeneralInfo.ForeColor = System.Drawing.Color.Brown;
      this.lsvwGeneralInfo.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
      this.lsvwGeneralInfo.Location = new System.Drawing.Point(10, 24);
      this.lsvwGeneralInfo.Name = "lsvwGeneralInfo";
      this.lsvwGeneralInfo.Size = new System.Drawing.Size(434, 245);
      this.lsvwGeneralInfo.TabIndex = 0;
      this.lsvwGeneralInfo.UseCompatibleStateImageBehavior = false;
      this.lsvwGeneralInfo.View = System.Windows.Forms.View.Details;
      // 
      // columnHeader3
      // 
      this.columnHeader3.Width = 140;
      // 
      // columnHeader4
      // 
      this.columnHeader4.Width = 270;
      // 
      // groupBox3
      // 
      this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox3.Controls.Add(this.lvMessageSets);
      this.groupBox3.ForeColor = System.Drawing.SystemColors.Desktop;
      this.groupBox3.Location = new System.Drawing.Point(10, 310);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(908, 176);
      this.groupBox3.TabIndex = 7;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Supported MessageSets";
      // 
      // ColumnHeader1
      // 
      this.ColumnHeader1.Width = 200;
      // 
      // lsvwSignOnInfo
      // 
      this.lsvwSignOnInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.lsvwSignOnInfo.BackColor = System.Drawing.SystemColors.ControlLight;
      this.lsvwSignOnInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2});
      this.lsvwSignOnInfo.ForeColor = System.Drawing.Color.Brown;
      this.lsvwSignOnInfo.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
      this.lsvwSignOnInfo.Location = new System.Drawing.Point(12, 24);
      this.lsvwSignOnInfo.Name = "lsvwSignOnInfo";
      this.lsvwSignOnInfo.Size = new System.Drawing.Size(432, 245);
      this.lsvwSignOnInfo.TabIndex = 0;
      this.lsvwSignOnInfo.UseCompatibleStateImageBehavior = false;
      this.lsvwSignOnInfo.View = System.Windows.Forms.View.Details;
      // 
      // ColumnHeader2
      // 
      this.ColumnHeader2.Width = 210;
      // 
      // GroupBox2
      // 
      this.GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.GroupBox2.Controls.Add(this.lsvwSignOnInfo);
      this.GroupBox2.ForeColor = System.Drawing.SystemColors.Desktop;
      this.GroupBox2.Location = new System.Drawing.Point(463, 13);
      this.GroupBox2.Name = "GroupBox2";
      this.GroupBox2.Size = new System.Drawing.Size(450, 285);
      this.GroupBox2.TabIndex = 6;
      this.GroupBox2.TabStop = false;
      this.GroupBox2.Text = "SignOn Information";
      // 
      // btnOk
      // 
      this.btnOk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnOk.Location = new System.Drawing.Point(407, 499);
      this.btnOk.Name = "btnOk";
      this.btnOk.Size = new System.Drawing.Size(118, 23);
      this.btnOk.TabIndex = 4;
      this.btnOk.Text = "OK";
      this.btnOk.UseVisualStyleBackColor = true;
      // 
      // ResponseDemo
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
      this.ClientSize = new System.Drawing.Size(929, 535);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.GroupBox2);
      this.Controls.Add(this.btnOk);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.Name = "ResponseDemo";
      this.Text = "FI Response";
      this.groupBox1.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      this.GroupBox2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    public fiprofileDemo MyForm1;
    public System.Windows.Forms.ListView lvMessageSets;
    private System.Windows.Forms.ColumnHeader MSName;
    private System.Windows.Forms.ColumnHeader SecurityLevel;
    private System.Windows.Forms.ColumnHeader TransportSecurity;
    private System.Windows.Forms.ColumnHeader Recovery;
    private System.Windows.Forms.ColumnHeader MSRefresh;
    private System.Windows.Forms.ColumnHeader SyncMode;
    private System.Windows.Forms.ColumnHeader TxImage;
    private System.Windows.Forms.ColumnHeader ClosingInfo;
    private System.Windows.Forms.ColumnHeader ClosingInfoImage;
    private System.Windows.Forms.ColumnHeader Url;
    internal System.Windows.Forms.GroupBox groupBox1;
    internal System.Windows.Forms.ListView lsvwGeneralInfo;
    internal System.Windows.Forms.ColumnHeader columnHeader3;
    internal System.Windows.Forms.ColumnHeader columnHeader4;
    internal System.Windows.Forms.GroupBox groupBox3;
    internal System.Windows.Forms.ColumnHeader ColumnHeader1;
    internal System.Windows.Forms.ListView lsvwSignOnInfo;
    internal System.Windows.Forms.ColumnHeader ColumnHeader2;
    internal System.Windows.Forms.GroupBox GroupBox2;
    private System.Windows.Forms.Button btnOk;
  }
}
