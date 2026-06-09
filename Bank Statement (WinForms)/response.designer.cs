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
      this.gbStatement = new System.Windows.Forms.GroupBox();
      this.lsvwTransactions = new System.Windows.Forms.ListView();
      this.chDate = new System.Windows.Forms.ColumnHeader();
      this.chType = new System.Windows.Forms.ColumnHeader();
      this.chCheckNum = new System.Windows.Forms.ColumnHeader();
      this.chAmount = new System.Windows.Forms.ColumnHeader();
      this.chPayee = new System.Windows.Forms.ColumnHeader();
      this.lblAvailableBalanceDate = new System.Windows.Forms.Label();
      this.lblPostedBalanceDate = new System.Windows.Forms.Label();
      this.lblAvailableBalanceDateLabel = new System.Windows.Forms.Label();
      this.lblPostedBalanceDateLabel = new System.Windows.Forms.Label();
      this.lblAvailableBalance = new System.Windows.Forms.Label();
      this.lblPostedBalance = new System.Windows.Forms.Label();
      this.lblAvailableBalanceLabel = new System.Windows.Forms.Label();
      this.lblPostedBalanceLabel = new System.Windows.Forms.Label();
      this.btnOK = new System.Windows.Forms.Button();
      this.gbStatement.SuspendLayout();
      this.SuspendLayout();
      // 
      // gbStatement
      // 
      this.gbStatement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.gbStatement.Controls.Add(this.lsvwTransactions);
      this.gbStatement.Controls.Add(this.lblAvailableBalanceDate);
      this.gbStatement.Controls.Add(this.lblPostedBalanceDate);
      this.gbStatement.Controls.Add(this.lblAvailableBalanceDateLabel);
      this.gbStatement.Controls.Add(this.lblPostedBalanceDateLabel);
      this.gbStatement.Controls.Add(this.lblAvailableBalance);
      this.gbStatement.Controls.Add(this.lblPostedBalance);
      this.gbStatement.Controls.Add(this.lblAvailableBalanceLabel);
      this.gbStatement.Controls.Add(this.lblPostedBalanceLabel);
      this.gbStatement.Location = new System.Drawing.Point(12, 12);
      this.gbStatement.Name = "gbStatement";
      this.gbStatement.Size = new System.Drawing.Size(576, 497);
      this.gbStatement.TabIndex = 1;
      this.gbStatement.TabStop = false;
      this.gbStatement.Text = "Statement";
      // 
      // lsvwTransactions
      // 
      this.lsvwTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.lsvwTransactions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDate,
            this.chType,
            this.chCheckNum,
            this.chAmount,
            this.chPayee});
      this.lsvwTransactions.GridLines = true;
      this.lsvwTransactions.Location = new System.Drawing.Point(8, 88);
      this.lsvwTransactions.Name = "lsvwTransactions";
      this.lsvwTransactions.Size = new System.Drawing.Size(560, 401);
      this.lsvwTransactions.TabIndex = 8;
      this.lsvwTransactions.UseCompatibleStateImageBehavior = false;
      this.lsvwTransactions.View = System.Windows.Forms.View.Details;
      // 
      // chDate
      // 
      this.chDate.Text = "Date";
      this.chDate.Width = 114;
      // 
      // chType
      // 
      this.chType.Text = "Type";
      this.chType.Width = 78;
      // 
      // chCheckNum
      // 
      this.chCheckNum.Text = "Check#";
      this.chCheckNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.chCheckNum.Width = 55;
      // 
      // chAmount
      // 
      this.chAmount.Text = "Amount";
      this.chAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.chAmount.Width = 70;
      // 
      // chPayee
      // 
      this.chPayee.Text = "Payee";
      this.chPayee.Width = 220;
      // 
      // lblAvailableBalanceDate
      // 
      this.lblAvailableBalanceDate.ForeColor = System.Drawing.SystemColors.Highlight;
      this.lblAvailableBalanceDate.Location = new System.Drawing.Point(296, 56);
      this.lblAvailableBalanceDate.Name = "lblAvailableBalanceDate";
      this.lblAvailableBalanceDate.Size = new System.Drawing.Size(156, 23);
      this.lblAvailableBalanceDate.TabIndex = 7;
      this.lblAvailableBalanceDate.Text = "01/01/2005";
      // 
      // lblPostedBalanceDate
      // 
      this.lblPostedBalanceDate.ForeColor = System.Drawing.SystemColors.Highlight;
      this.lblPostedBalanceDate.Location = new System.Drawing.Point(296, 24);
      this.lblPostedBalanceDate.Name = "lblPostedBalanceDate";
      this.lblPostedBalanceDate.Size = new System.Drawing.Size(156, 23);
      this.lblPostedBalanceDate.TabIndex = 5;
      this.lblPostedBalanceDate.Text = "01/01/2005";
      // 
      // lblAvailableBalanceDateLabel
      // 
      this.lblAvailableBalanceDateLabel.Location = new System.Drawing.Point(248, 56);
      this.lblAvailableBalanceDateLabel.Name = "lblAvailableBalanceDateLabel";
      this.lblAvailableBalanceDateLabel.Size = new System.Drawing.Size(40, 23);
      this.lblAvailableBalanceDateLabel.TabIndex = 6;
      this.lblAvailableBalanceDateLabel.Text = "as of:";
      // 
      // lblPostedBalanceDateLabel
      // 
      this.lblPostedBalanceDateLabel.Location = new System.Drawing.Point(248, 24);
      this.lblPostedBalanceDateLabel.Name = "lblPostedBalanceDateLabel";
      this.lblPostedBalanceDateLabel.Size = new System.Drawing.Size(40, 23);
      this.lblPostedBalanceDateLabel.TabIndex = 4;
      this.lblPostedBalanceDateLabel.Text = "as of:";
      // 
      // lblAvailableBalance
      // 
      this.lblAvailableBalance.ForeColor = System.Drawing.SystemColors.Highlight;
      this.lblAvailableBalance.Location = new System.Drawing.Point(128, 56);
      this.lblAvailableBalance.Name = "lblAvailableBalance";
      this.lblAvailableBalance.Size = new System.Drawing.Size(112, 23);
      this.lblAvailableBalance.TabIndex = 3;
      this.lblAvailableBalance.Text = "$0.00";
      // 
      // lblPostedBalance
      // 
      this.lblPostedBalance.ForeColor = System.Drawing.SystemColors.Highlight;
      this.lblPostedBalance.Location = new System.Drawing.Point(128, 24);
      this.lblPostedBalance.Name = "lblPostedBalance";
      this.lblPostedBalance.Size = new System.Drawing.Size(112, 23);
      this.lblPostedBalance.TabIndex = 1;
      this.lblPostedBalance.Text = "$0.00";
      // 
      // lblAvailableBalanceLabel
      // 
      this.lblAvailableBalanceLabel.Location = new System.Drawing.Point(16, 56);
      this.lblAvailableBalanceLabel.Name = "lblAvailableBalanceLabel";
      this.lblAvailableBalanceLabel.Size = new System.Drawing.Size(104, 23);
      this.lblAvailableBalanceLabel.TabIndex = 2;
      this.lblAvailableBalanceLabel.Text = "Available Balance:";
      // 
      // lblPostedBalanceLabel
      // 
      this.lblPostedBalanceLabel.Location = new System.Drawing.Point(16, 24);
      this.lblPostedBalanceLabel.Name = "lblPostedBalanceLabel";
      this.lblPostedBalanceLabel.Size = new System.Drawing.Size(104, 23);
      this.lblPostedBalanceLabel.TabIndex = 0;
      this.lblPostedBalanceLabel.Text = "Posted Balance:";
      // 
      // btnOK
      // 
      this.btnOK.Location = new System.Drawing.Point(248, 534);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(118, 23);
      this.btnOK.TabIndex = 0;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = true;
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // ResponseDemo
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(592, 578);
      this.Controls.Add(this.btnOK);
      this.Controls.Add(this.gbStatement);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.Name = "ResponseDemo";
      this.Text = "Bank Statement Response Demo";
      this.gbStatement.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion
    public bankstatementDemo MyForm1;
    private System.Windows.Forms.GroupBox gbStatement;
    private System.Windows.Forms.ColumnHeader chDate;
    private System.Windows.Forms.ColumnHeader chType;
    private System.Windows.Forms.ColumnHeader chCheckNum;
    private System.Windows.Forms.ColumnHeader chAmount;
    private System.Windows.Forms.ColumnHeader chPayee;
    private System.Windows.Forms.Label lblAvailableBalanceDateLabel;
    private System.Windows.Forms.Label lblPostedBalanceDateLabel;
    private System.Windows.Forms.Label lblAvailableBalanceLabel;
    private System.Windows.Forms.Label lblPostedBalanceLabel;
    public System.Windows.Forms.ListView lsvwTransactions;
    public System.Windows.Forms.Label lblAvailableBalanceDate;
    public System.Windows.Forms.Label lblPostedBalanceDate;
    public System.Windows.Forms.Label lblAvailableBalance;
    public System.Windows.Forms.Label lblPostedBalance;
    private System.Windows.Forms.Button btnOK;
  }
}
