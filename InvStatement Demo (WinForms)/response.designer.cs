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
      this.GroupBox6 = new System.Windows.Forms.GroupBox();
      this.GroupBox4 = new System.Windows.Forms.GroupBox();
      this.lblMarginBalance = new System.Windows.Forms.Label();
      this.Label5 = new System.Windows.Forms.Label();
      this.lblShortBalance = new System.Windows.Forms.Label();
      this.Label7 = new System.Windows.Forms.Label();
      this.lblAvailableCash = new System.Windows.Forms.Label();
      this.Label6 = new System.Windows.Forms.Label();
      this.lvwBalances = new System.Windows.Forms.ListView();
      this.BalName = new System.Windows.Forms.ColumnHeader();
      this.BalDesc = new System.Windows.Forms.ColumnHeader();
      this.BalType = new System.Windows.Forms.ColumnHeader();
      this.BalValue = new System.Windows.Forms.ColumnHeader();
      this.Label1 = new System.Windows.Forms.Label();
      this.Label2 = new System.Windows.Forms.Label();
      this.lblDefaultCurrency = new System.Windows.Forms.Label();
      this.lblStatementDate = new System.Windows.Forms.Label();
      this.GroupBox1 = new System.Windows.Forms.GroupBox();
      this.lvwTransactions = new System.Windows.Forms.ListView();
      this.Type = new System.Windows.Forms.ColumnHeader();
      this.Date = new System.Windows.Forms.ColumnHeader();
      this.Id = new System.Windows.Forms.ColumnHeader();
      this.Units = new System.Windows.Forms.ColumnHeader();
      this.UnitPrice = new System.Windows.Forms.ColumnHeader();
      this.Total = new System.Windows.Forms.ColumnHeader();
      this.SubAccountSec = new System.Windows.Forms.ColumnHeader();
      this.SubAccountFund = new System.Windows.Forms.ColumnHeader();
      this.GroupBox2 = new System.Windows.Forms.GroupBox();
      this.lvwPositions = new System.Windows.Forms.ListView();
      this.PosType = new System.Windows.Forms.ColumnHeader();
      this.PosPriceAsOf = new System.Windows.Forms.ColumnHeader();
      this.PosSecId = new System.Windows.Forms.ColumnHeader();
      this.PosUnits = new System.Windows.Forms.ColumnHeader();
      this.PosUnitPrice = new System.Windows.Forms.ColumnHeader();
      this.PosMarketValue = new System.Windows.Forms.ColumnHeader();
      this.PosHeldInAcc = new System.Windows.Forms.ColumnHeader();
      this.PosOption = new System.Windows.Forms.ColumnHeader();
      this.PosMemo = new System.Windows.Forms.ColumnHeader();
      this.GroupBox3 = new System.Windows.Forms.GroupBox();
      this.lvwOpenOrders = new System.Windows.Forms.ListView();
      this.OOType = new System.Windows.Forms.ColumnHeader();
      this.OODate = new System.Windows.Forms.ColumnHeader();
      this.OOSecId = new System.Windows.Forms.ColumnHeader();
      this.OOUnits = new System.Windows.Forms.ColumnHeader();
      this.OOSubAccount = new System.Windows.Forms.ColumnHeader();
      this.OODuration = new System.Windows.Forms.ColumnHeader();
      this.OORestriction = new System.Windows.Forms.ColumnHeader();
      this.GroupBox5 = new System.Windows.Forms.GroupBox();
      this.lvwSecurities = new System.Windows.Forms.ListView();
      this.SecType = new System.Windows.Forms.ColumnHeader();
      this.SecId = new System.Windows.Forms.ColumnHeader();
      this.SecName = new System.Windows.Forms.ColumnHeader();
      this.SecTicker = new System.Windows.Forms.ColumnHeader();
      this.SecAssetClass = new System.Windows.Forms.ColumnHeader();
      this.ListView1 = new System.Windows.Forms.ListView();
      this.GroupBox6.SuspendLayout();
      this.GroupBox4.SuspendLayout();
      this.GroupBox1.SuspendLayout();
      this.GroupBox2.SuspendLayout();
      this.GroupBox3.SuspendLayout();
      this.GroupBox5.SuspendLayout();
      this.SuspendLayout();
      // 
      // GroupBox6
      // 
      this.GroupBox6.Controls.Add(this.GroupBox4);
      this.GroupBox6.Controls.Add(this.Label1);
      this.GroupBox6.Controls.Add(this.Label2);
      this.GroupBox6.Controls.Add(this.lblDefaultCurrency);
      this.GroupBox6.Controls.Add(this.lblStatementDate);
      this.GroupBox6.Controls.Add(this.GroupBox1);
      this.GroupBox6.Controls.Add(this.GroupBox2);
      this.GroupBox6.Controls.Add(this.GroupBox3);
      this.GroupBox6.Controls.Add(this.GroupBox5);
      this.GroupBox6.ForeColor = System.Drawing.SystemColors.Desktop;
      this.GroupBox6.Location = new System.Drawing.Point(8, 11);
      this.GroupBox6.Name = "GroupBox6";
      this.GroupBox6.Size = new System.Drawing.Size(792, 789);
      this.GroupBox6.TabIndex = 0;
      this.GroupBox6.TabStop = false;
      this.GroupBox6.Text = "Investment Statement";
      // 
      // GroupBox4
      // 
      this.GroupBox4.Controls.Add(this.lblMarginBalance);
      this.GroupBox4.Controls.Add(this.Label5);
      this.GroupBox4.Controls.Add(this.lblShortBalance);
      this.GroupBox4.Controls.Add(this.Label7);
      this.GroupBox4.Controls.Add(this.lblAvailableCash);
      this.GroupBox4.Controls.Add(this.Label6);
      this.GroupBox4.Controls.Add(this.lvwBalances);
      this.GroupBox4.ForeColor = System.Drawing.Color.Firebrick;
      this.GroupBox4.Location = new System.Drawing.Point(8, 475);
      this.GroupBox4.Name = "GroupBox4";
      this.GroupBox4.Size = new System.Drawing.Size(776, 167);
      this.GroupBox4.TabIndex = 7;
      this.GroupBox4.TabStop = false;
      this.GroupBox4.Text = "Balances";
      // 
      // lblMarginBalance
      // 
      this.lblMarginBalance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
      this.lblMarginBalance.Location = new System.Drawing.Point(410, 19);
      this.lblMarginBalance.Name = "lblMarginBalance";
      this.lblMarginBalance.Size = new System.Drawing.Size(104, 23);
      this.lblMarginBalance.TabIndex = 39;
      this.lblMarginBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // Label5
      // 
      this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label5.Location = new System.Drawing.Point(301, 19);
      this.Label5.Name = "Label5";
      this.Label5.Size = new System.Drawing.Size(105, 23);
      this.Label5.TabIndex = 38;
      this.Label5.Text = "Margin Balance:";
      this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lblShortBalance
      // 
      this.lblShortBalance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
      this.lblShortBalance.Location = new System.Drawing.Point(627, 19);
      this.lblShortBalance.Name = "lblShortBalance";
      this.lblShortBalance.Size = new System.Drawing.Size(104, 23);
      this.lblShortBalance.TabIndex = 37;
      this.lblShortBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // Label7
      // 
      this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label7.Location = new System.Drawing.Point(525, 19);
      this.Label7.Name = "Label7";
      this.Label7.Size = new System.Drawing.Size(96, 23);
      this.Label7.TabIndex = 36;
      this.Label7.Text = "Short Balance:";
      this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lblAvailableCash
      // 
      this.lblAvailableCash.ForeColor = System.Drawing.SystemColors.ActiveCaption;
      this.lblAvailableCash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.lblAvailableCash.Location = new System.Drawing.Point(191, 19);
      this.lblAvailableCash.Name = "lblAvailableCash";
      this.lblAvailableCash.Size = new System.Drawing.Size(104, 23);
      this.lblAvailableCash.TabIndex = 35;
      this.lblAvailableCash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // Label6
      // 
      this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label6.Location = new System.Drawing.Point(76, 19);
      this.Label6.Name = "Label6";
      this.Label6.Size = new System.Drawing.Size(107, 23);
      this.Label6.TabIndex = 34;
      this.Label6.Text = "Available Cash:";
      this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lvwBalances
      // 
      this.lvwBalances.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BalName,
            this.BalDesc,
            this.BalType,
            this.BalValue});
      this.lvwBalances.GridLines = true;
      this.lvwBalances.Location = new System.Drawing.Point(8, 57);
      this.lvwBalances.Name = "lvwBalances";
      this.lvwBalances.Size = new System.Drawing.Size(760, 100);
      this.lvwBalances.TabIndex = 19;
      this.lvwBalances.UseCompatibleStateImageBehavior = false;
      this.lvwBalances.View = System.Windows.Forms.View.Details;
      // 
      // BalName
      // 
      this.BalName.Text = "Balance Name";
      this.BalName.Width = 184;
      // 
      // BalDesc
      // 
      this.BalDesc.Text = "Balance Description";
      this.BalDesc.Width = 275;
      // 
      // BalType
      // 
      this.BalType.Text = "Balance Type";
      this.BalType.Width = 194;
      // 
      // BalValue
      // 
      this.BalValue.Text = "Balance Value";
      this.BalValue.Width = 99;
      // 
      // Label1
      // 
      this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Label1.ForeColor = System.Drawing.Color.DarkRed;
      this.Label1.Location = new System.Drawing.Point(443, 33);
      this.Label1.Name = "Label1";
      this.Label1.Size = new System.Drawing.Size(110, 23);
      this.Label1.TabIndex = 3;
      this.Label1.Text = "Default Currency:";
      this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // Label2
      // 
      this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Label2.ForeColor = System.Drawing.Color.DarkRed;
      this.Label2.Location = new System.Drawing.Point(140, 33);
      this.Label2.Name = "Label2";
      this.Label2.Size = new System.Drawing.Size(136, 23);
      this.Label2.TabIndex = 2;
      this.Label2.Text = "Statement As Of Date: ";
      this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lblDefaultCurrency
      // 
      this.lblDefaultCurrency.ForeColor = System.Drawing.SystemColors.ActiveCaption;
      this.lblDefaultCurrency.Location = new System.Drawing.Point(559, 33);
      this.lblDefaultCurrency.Name = "lblDefaultCurrency";
      this.lblDefaultCurrency.Size = new System.Drawing.Size(32, 23);
      this.lblDefaultCurrency.TabIndex = 1;
      this.lblDefaultCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblStatementDate
      // 
      this.lblStatementDate.ForeColor = System.Drawing.SystemColors.ActiveCaption;
      this.lblStatementDate.Location = new System.Drawing.Point(284, 33);
      this.lblStatementDate.Name = "lblStatementDate";
      this.lblStatementDate.Size = new System.Drawing.Size(142, 23);
      this.lblStatementDate.TabIndex = 0;
      this.lblStatementDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // GroupBox1
      // 
      this.GroupBox1.Controls.Add(this.lvwTransactions);
      this.GroupBox1.ForeColor = System.Drawing.Color.Firebrick;
      this.GroupBox1.Location = new System.Drawing.Point(10, 69);
      this.GroupBox1.Name = "GroupBox1";
      this.GroupBox1.Size = new System.Drawing.Size(776, 128);
      this.GroupBox1.TabIndex = 4;
      this.GroupBox1.TabStop = false;
      this.GroupBox1.Text = "Investment Transactions";
      // 
      // lvwTransactions
      // 
      this.lvwTransactions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Type,
            this.Date,
            this.Id,
            this.Units,
            this.UnitPrice,
            this.Total,
            this.SubAccountSec,
            this.SubAccountFund});
      this.lvwTransactions.Enabled = false;
      this.lvwTransactions.GridLines = true;
      this.lvwTransactions.Location = new System.Drawing.Point(8, 16);
      this.lvwTransactions.Name = "lvwTransactions";
      this.lvwTransactions.Size = new System.Drawing.Size(760, 100);
      this.lvwTransactions.TabIndex = 0;
      this.lvwTransactions.UseCompatibleStateImageBehavior = false;
      this.lvwTransactions.View = System.Windows.Forms.View.Details;
      // 
      // Type
      // 
      this.Type.Text = "Type";
      this.Type.Width = 129;
      // 
      // Date
      // 
      this.Date.Text = "Date";
      this.Date.Width = 80;
      // 
      // Id
      // 
      this.Id.Text = "Security ID";
      this.Id.Width = 118;
      // 
      // Units
      // 
      this.Units.Text = "Units";
      // 
      // UnitPrice
      // 
      this.UnitPrice.Text = "Unit Price";
      this.UnitPrice.Width = 63;
      // 
      // Total
      // 
      this.Total.Text = "Total";
      this.Total.Width = 80;
      // 
      // SubAccountSec
      // 
      this.SubAccountSec.Text = "Sub Account Sec.";
      this.SubAccountSec.Width = 118;
      // 
      // SubAccountFund
      // 
      this.SubAccountFund.Text = "Sub Account Fund";
      this.SubAccountFund.Width = 103;
      // 
      // GroupBox2
      // 
      this.GroupBox2.Controls.Add(this.lvwPositions);
      this.GroupBox2.ForeColor = System.Drawing.Color.Firebrick;
      this.GroupBox2.Location = new System.Drawing.Point(10, 203);
      this.GroupBox2.Name = "GroupBox2";
      this.GroupBox2.Size = new System.Drawing.Size(776, 131);
      this.GroupBox2.TabIndex = 5;
      this.GroupBox2.TabStop = false;
      this.GroupBox2.Text = "Positions";
      // 
      // lvwPositions
      // 
      this.lvwPositions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PosType,
            this.PosPriceAsOf,
            this.PosSecId,
            this.PosUnits,
            this.PosUnitPrice,
            this.PosMarketValue,
            this.PosHeldInAcc,
            this.PosOption,
            this.PosMemo});
      this.lvwPositions.Enabled = false;
      this.lvwPositions.GridLines = true;
      this.lvwPositions.Location = new System.Drawing.Point(8, 16);
      this.lvwPositions.Name = "lvwPositions";
      this.lvwPositions.Size = new System.Drawing.Size(760, 100);
      this.lvwPositions.TabIndex = 1;
      this.lvwPositions.UseCompatibleStateImageBehavior = false;
      this.lvwPositions.View = System.Windows.Forms.View.Details;
      // 
      // PosType
      // 
      this.PosType.Text = "Type";
      this.PosType.Width = 131;
      // 
      // PosPriceAsOf
      // 
      this.PosPriceAsOf.Text = "Price As Of ";
      this.PosPriceAsOf.Width = 79;
      // 
      // PosSecId
      // 
      this.PosSecId.Text = "Security ID";
      this.PosSecId.Width = 116;
      // 
      // PosUnits
      // 
      this.PosUnits.Text = "Units";
      // 
      // PosUnitPrice
      // 
      this.PosUnitPrice.Text = "Unit Price";
      this.PosUnitPrice.Width = 62;
      // 
      // PosMarketValue
      // 
      this.PosMarketValue.Text = "Market Value";
      this.PosMarketValue.Width = 83;
      // 
      // PosHeldInAcc
      // 
      this.PosHeldInAcc.Text = "Held in Account";
      this.PosHeldInAcc.Width = 88;
      // 
      // PosOption
      // 
      this.PosOption.Text = "Option";
      this.PosOption.Width = 49;
      // 
      // PosMemo
      // 
      this.PosMemo.Text = "Memo";
      this.PosMemo.Width = 84;
      // 
      // GroupBox3
      // 
      this.GroupBox3.Controls.Add(this.lvwOpenOrders);
      this.GroupBox3.ForeColor = System.Drawing.Color.Firebrick;
      this.GroupBox3.Location = new System.Drawing.Point(8, 340);
      this.GroupBox3.Name = "GroupBox3";
      this.GroupBox3.Size = new System.Drawing.Size(776, 129);
      this.GroupBox3.TabIndex = 6;
      this.GroupBox3.TabStop = false;
      this.GroupBox3.Text = "Open Orders";
      // 
      // lvwOpenOrders
      // 
      this.lvwOpenOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OOType,
            this.OODate,
            this.OOSecId,
            this.OOUnits,
            this.OOSubAccount,
            this.OODuration,
            this.OORestriction});
      this.lvwOpenOrders.Enabled = false;
      this.lvwOpenOrders.GridLines = true;
      this.lvwOpenOrders.Location = new System.Drawing.Point(8, 16);
      this.lvwOpenOrders.Name = "lvwOpenOrders";
      this.lvwOpenOrders.Size = new System.Drawing.Size(760, 100);
      this.lvwOpenOrders.TabIndex = 2;
      this.lvwOpenOrders.UseCompatibleStateImageBehavior = false;
      this.lvwOpenOrders.View = System.Windows.Forms.View.Details;
      // 
      // OOType
      // 
      this.OOType.Text = "Type";
      this.OOType.Width = 132;
      // 
      // OODate
      // 
      this.OODate.Text = "Order Placed On";
      this.OODate.Width = 81;
      // 
      // OOSecId
      // 
      this.OOSecId.Text = "Security ID";
      this.OOSecId.Width = 114;
      // 
      // OOUnits
      // 
      this.OOUnits.Text = "Units";
      // 
      // OOSubAccount
      // 
      this.OOSubAccount.Text = "Sub Account";
      this.OOSubAccount.Width = 101;
      // 
      // OODuration
      // 
      this.OODuration.Text = "Duration";
      this.OODuration.Width = 136;
      // 
      // OORestriction
      // 
      this.OORestriction.Text = "Restriction";
      this.OORestriction.Width = 128;
      // 
      // GroupBox5
      // 
      this.GroupBox5.Controls.Add(this.lvwSecurities);
      this.GroupBox5.Controls.Add(this.ListView1);
      this.GroupBox5.ForeColor = System.Drawing.Color.Firebrick;
      this.GroupBox5.Location = new System.Drawing.Point(6, 648);
      this.GroupBox5.Name = "GroupBox5";
      this.GroupBox5.Size = new System.Drawing.Size(776, 128);
      this.GroupBox5.TabIndex = 8;
      this.GroupBox5.TabStop = false;
      this.GroupBox5.Text = "Securities";
      // 
      // lvwSecurities
      // 
      this.lvwSecurities.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SecType,
            this.SecId,
            this.SecName,
            this.SecTicker,
            this.SecAssetClass});
      this.lvwSecurities.GridLines = true;
      this.lvwSecurities.Location = new System.Drawing.Point(8, 16);
      this.lvwSecurities.Name = "lvwSecurities";
      this.lvwSecurities.Size = new System.Drawing.Size(760, 100);
      this.lvwSecurities.TabIndex = 19;
      this.lvwSecurities.UseCompatibleStateImageBehavior = false;
      this.lvwSecurities.View = System.Windows.Forms.View.Details;
      // 
      // SecType
      // 
      this.SecType.Text = "Type";
      this.SecType.Width = 140;
      // 
      // SecId
      // 
      this.SecId.Text = "Security ID";
      this.SecId.Width = 157;
      // 
      // SecName
      // 
      this.SecName.Text = "Security Name";
      this.SecName.Width = 194;
      // 
      // SecTicker
      // 
      this.SecTicker.Text = "Ticker Symbol";
      this.SecTicker.Width = 104;
      // 
      // SecAssetClass
      // 
      this.SecAssetClass.Text = "Asset Class";
      this.SecAssetClass.Width = 158;
      // 
      // ListView1
      // 
      this.ListView1.Enabled = false;
      this.ListView1.Location = new System.Drawing.Point(8, 16);
      this.ListView1.Name = "ListView1";
      this.ListView1.Size = new System.Drawing.Size(632, 96);
      this.ListView1.TabIndex = 19;
      this.ListView1.UseCompatibleStateImageBehavior = false;
      // 
      // ResponseDemo
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(808, 783);
      this.Controls.Add(this.GroupBox6);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.Name = "ResponseDemo";
      this.Text = "Response";
      this.GroupBox6.ResumeLayout(false);
      this.GroupBox4.ResumeLayout(false);
      this.GroupBox1.ResumeLayout(false);
      this.GroupBox2.ResumeLayout(false);
      this.GroupBox3.ResumeLayout(false);
      this.GroupBox5.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion
    public InvStatementDemo MyForm1;
    internal System.Windows.Forms.GroupBox GroupBox6;
    internal System.Windows.Forms.GroupBox GroupBox4;
    internal System.Windows.Forms.Label lblMarginBalance;
    internal System.Windows.Forms.Label Label5;
    internal System.Windows.Forms.Label lblShortBalance;
    internal System.Windows.Forms.Label Label7;
    internal System.Windows.Forms.Label lblAvailableCash;
    internal System.Windows.Forms.Label Label6;
    internal System.Windows.Forms.ListView lvwBalances;
    internal System.Windows.Forms.ColumnHeader BalName;
    internal System.Windows.Forms.ColumnHeader BalDesc;
    internal System.Windows.Forms.ColumnHeader BalType;
    internal System.Windows.Forms.ColumnHeader BalValue;
    internal System.Windows.Forms.Label Label1;
    internal System.Windows.Forms.Label Label2;
    internal System.Windows.Forms.Label lblDefaultCurrency;
    internal System.Windows.Forms.Label lblStatementDate;
    internal System.Windows.Forms.GroupBox GroupBox1;
    internal System.Windows.Forms.ListView lvwTransactions;
    internal System.Windows.Forms.ColumnHeader Type;
    internal System.Windows.Forms.ColumnHeader Date;
    internal System.Windows.Forms.ColumnHeader Id;
    internal System.Windows.Forms.ColumnHeader Units;
    internal System.Windows.Forms.ColumnHeader UnitPrice;
    internal System.Windows.Forms.ColumnHeader Total;
    internal System.Windows.Forms.ColumnHeader SubAccountSec;
    internal System.Windows.Forms.ColumnHeader SubAccountFund;
    internal System.Windows.Forms.GroupBox GroupBox2;
    internal System.Windows.Forms.ListView lvwPositions;
    internal System.Windows.Forms.ColumnHeader PosType;
    internal System.Windows.Forms.ColumnHeader PosPriceAsOf;
    internal System.Windows.Forms.ColumnHeader PosSecId;
    internal System.Windows.Forms.ColumnHeader PosUnits;
    internal System.Windows.Forms.ColumnHeader PosUnitPrice;
    internal System.Windows.Forms.ColumnHeader PosMarketValue;
    internal System.Windows.Forms.ColumnHeader PosHeldInAcc;
    internal System.Windows.Forms.ColumnHeader PosOption;
    internal System.Windows.Forms.ColumnHeader PosMemo;
    internal System.Windows.Forms.GroupBox GroupBox3;
    internal System.Windows.Forms.ListView lvwOpenOrders;
    internal System.Windows.Forms.ColumnHeader OOType;
    internal System.Windows.Forms.ColumnHeader OODate;
    internal System.Windows.Forms.ColumnHeader OOSecId;
    internal System.Windows.Forms.ColumnHeader OOUnits;
    internal System.Windows.Forms.ColumnHeader OOSubAccount;
    internal System.Windows.Forms.ColumnHeader OODuration;
    internal System.Windows.Forms.ColumnHeader OORestriction;
    internal System.Windows.Forms.GroupBox GroupBox5;
    internal System.Windows.Forms.ListView lvwSecurities;
    internal System.Windows.Forms.ColumnHeader SecType;
    internal System.Windows.Forms.ColumnHeader SecId;
    internal System.Windows.Forms.ColumnHeader SecName;
    internal System.Windows.Forms.ColumnHeader SecTicker;
    internal System.Windows.Forms.ColumnHeader SecAssetClass;
    internal System.Windows.Forms.ListView ListView1;
  }
}
