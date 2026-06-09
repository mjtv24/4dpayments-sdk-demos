/*
 * 4D E-Banking SDK 2024 .NET Edition - Sample Project
 *
 * This sample project demonstrates the usage of 4D E-Banking SDK in a 
 * simple, straightforward way. It is not intended to be a complete 
 * application. Error handling and other checks are simplified for clarity.
 *
 * www.4dpayments.com/inebank
 *
 * This code is subject to the terms and conditions specified in the 
 * corresponding product license agreement which outlines the authorized 
 * usage and restrictions.
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DPayments.InEBank;

namespace DPayments.Demos
{
  public partial class InvStatementDemo : Form
  {
    [STAThread]
    static void Main()
    {
      Application.Run(new InvStatementDemo());
    }

    public InvStatementDemo()
    {
      InitializeComponent();
    }

    private void ShowError(Exception e)
    {
      String ed = "Error";
      if (e is InEBankException)
        ed += " (" + ((InEBankException) e).Code + ")";
      ed += ": " + e.Message;
      MessageBox.Show(this, ed, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private void btnGetStatement_Click(object sender, EventArgs e)
    {
      try
      {
        this.Cursor = Cursors.WaitCursor;
        invstatement1.FIUrl = txtURL.Text;
        invstatement1.OFXAppId = "QWIN";
        invstatement1.OFXAppVersion = "1700";
        invstatement1.OFXUser = txtUserID.Text;
        invstatement1.OFXPassword = txtPassword.Text;
        invstatement1.FIOrganization = txtBrokerName.Text;
        invstatement1.BrokerId = txtBrokerId.Text;
        invstatement1.AccountId = txtAccountNumber.Text;
        invstatement1.StartDate = dtpStartDate.Text;
        invstatement1.EndDate = dtpEndDate.Text;
        invstatement1.IncludeTransactions = chkbInclTx.Checked;
        invstatement1.IncludePositions = chkbInclPos.Checked;
        invstatement1.IncludeOpenOrders = chkbInclOpnOrd.Checked;
        invstatement1.IncludeBalances = chkbInclBal.Checked;

        invstatement1.GetStatement();

        Populate_Lists();
      }
      catch (Exception ex)
      {
        ShowError(ex);
      }
      finally
      {
        this.Cursor = Cursors.Default;
        invstatement1.Reset();
      }
    }

    private void btnRead_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor = Cursors.WaitCursor;
        invstatement1.Reset();
        invstatement1.ReadOFXDataFile(txtFileName.Text);
        Populate_Lists();
      }
      catch (Exception ex)
      {
        ShowError(ex);
      }
      finally
      {
        Cursor = Cursors.Default;
        invstatement1.Reset();
      }
    }

    private void Populate_Lists()
    {
      int i;
      ResponseDemo frmStatement = new ResponseDemo();

      frmStatement.MyForm1 = this;
      frmStatement.lvwTransactions.Enabled = chkbInclTx.Checked;
      frmStatement.lvwPositions.Enabled = chkbInclPos.Checked;
      frmStatement.lvwOpenOrders.Enabled = chkbInclOpnOrd.Checked;
      frmStatement.lvwBalances.Enabled = chkbInclBal.Checked;

      frmStatement.lvwTransactions.Items.Clear();
      frmStatement.lvwPositions.Items.Clear();
      frmStatement.lvwOpenOrders.Items.Clear();
      frmStatement.lvwSecurities.Items.Clear();

      frmStatement.lblStatementDate.Text = invstatement1.StatementDate;
      frmStatement.lblDefaultCurrency.Text = invstatement1.CurrencyCode;

      //List of Investment Transactions
      for (i = 0; i < invstatement1.Transactions.Count; i++)
      {
        string[] newRow = {    invstatement1.Transactions[i].TypeDescription, 
										invstatement1.Transactions[i].Date,
										invstatement1.Transactions[i].SecurityId,
										invstatement1.Transactions[i].Units,
										invstatement1.Transactions[i].UnitPrice,
										invstatement1.Transactions[i].Total,
										invstatement1.Transactions[i].SubAccountSec,
										invstatement1.Transactions[i].SubAccountFund
									};
        frmStatement.lvwTransactions.Items.Add(new ListViewItem(newRow));
      }

      //List of Positions
      for (i = 0; i < invstatement1.Positions.Count; i++)
      {
        string[] newRow = {    invstatement1.Positions[i].TypeDescription,
										invstatement1.Positions[i].DatePriceAsOf,
										invstatement1.Positions[i].SecurityId,
										invstatement1.Positions[i].Units,
										invstatement1.Positions[i].UnitPrice,
										invstatement1.Positions[i].MarketValue,
										invstatement1.Positions[i].Account,
										invstatement1.Positions[i].Option,
										invstatement1.Positions[i].Memo
										};
        frmStatement.lvwPositions.Items.Add(new ListViewItem(newRow));
      }

      //List of Open Orders
      for (i = 0; i < invstatement1.OpenOrders.Count; i++)
      {
        string[] newRow = {    invstatement1.OpenOrders[i].TypeDescription,
										invstatement1.OpenOrders[i].DatePlaced,
										invstatement1.OpenOrders[i].SecurityId,
										invstatement1.OpenOrders[i].Units,
										invstatement1.OpenOrders[i].SubAccountType,
										invstatement1.OpenOrders[i].Duration,
										invstatement1.OpenOrders[i].Restriction
									};
        frmStatement.lvwOpenOrders.Items.Add(new ListViewItem(newRow));
      }

      //List of Balances
      frmStatement.lblAvailableCash.Text = invstatement1.AvailableCash;
      frmStatement.lblMarginBalance.Text = invstatement1.MarginBalance;
      frmStatement.lblShortBalance.Text = invstatement1.ShortBalance;

      for (i = 0; i < invstatement1.Balances.Count; i++)
      {
        string[] newRow = {    
                        invstatement1.Balances[i].Name,
                        invstatement1.Balances[i].Description,
                        invstatement1.Balances[i].TypeDescription,
                        invstatement1.Balances[i].Amount
                    };

        frmStatement.lvwBalances.Items.Add(new ListViewItem(newRow));
      }

      //List of Securities
      for (i = 0; i < invstatement1.Securities.Count; i++)
      {
        string[] newRow = {    invstatement1.Securities[i].TypeDescription,
										invstatement1.Securities[i].SecurityId,
										invstatement1.Securities[i].Name,
										invstatement1.Securities[i].Ticker,
										invstatement1.Securities[i].AssetClass
										};

        frmStatement.lvwSecurities.Items.Add(new ListViewItem(newRow));
      }

      frmStatement.Show();
    }

  }
}





