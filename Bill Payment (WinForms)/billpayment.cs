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
  public partial class billpaymentDemo : Form
  {

    System.Collections.ArrayList payees = new System.Collections.ArrayList();

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.Run(new billpaymentDemo());
    }

    public billpaymentDemo()
    {
      InitializeComponent();
    }

    private void BillPayment_Load(object sender, EventArgs e)
    {
      billpayment1.OFXAppId = "QWIN";
      billpayment1.OFXAppVersion = "1700";
      dtpDueDate.Text = DateTime.Now.AddDays(7).ToShortDateString();
    }

    private void bLogin_Click(object sender, EventArgs e)
    {
      billpayment1.FIUrl = tbFIUrl.Text;
      billpayment1.FIId = tbFIId.Text;
      billpayment1.FIOrganization = tbFIOrganization.Text;
      billpayment1.OFXUser = tbUserId.Text;
      billpayment1.OFXPassword = tbPassword.Text;

      billpayment1.Payment.FromBankId = tbFromBankId.Text;
      billpayment1.Payment.FromAccountId = tbFromAccountId.Text;
      billpayment1.Payment.FromAccountType = (AccountTypes) cbFromAccountType.SelectedIndex;

      billpayment1.SynchronizePayees("REFRESH");
    }

    private void bPayBill_Click(object sender, EventArgs e)
    {
    	if (cbName.SelectedIndex == -1) return;
      try
      {
        Cursor = Cursors.WaitCursor;
        ResetRetVal();

        billpayment1.Payment.FromBankId = tbFromBankId.Text;
        billpayment1.Payment.FromAccountId = tbFromAccountId.Text;
        billpayment1.Payment.FromAccountType = (AccountTypes) cbFromAccountType.SelectedIndex;
        billpayment1.Payment.Memo = tbMemo.Text;
        billpayment1.Payment.Amount = tbAmount.Text;
        billpayment1.Payment.DateDue = dtpDueDate.Text;
        
        billpayment1.PayBill();

        MessageBox.Show(this, "Bill payment completed successfully! If payment was a scheduled transaction (not immediate), make a note of the Payment ID if want to modify or cancel this payment at a later time.", "Bill Payment Acknowledgment", MessageBoxButtons.OK, MessageBoxIcon.Information);
        DisplayResponse();
      }
      catch (Exception ex)
      { ShowError(ex); }
      finally
      { Cursor = Cursors.Default; }
    }

    private void billpayment1_OnSyncPayees(object sender, BillpaymentSyncPayeesEventArgs e)
    {
      cbName.Items.Add(e.PayeeName);
      payees.Add(e.PayeeAggregate);
    }
    
    private void cbName_SelectedIndexChanged(object sender, EventArgs e)
    {
      int index = cbName.SelectedIndex;
      billpayment1.Payee.Aggregate = payees[index].ToString();
      tbAddr1.Text = billpayment1.Payee.Addr1;
      tbAddr2.Text = billpayment1.Payee.Addr2;
      tbCity.Text = billpayment1.Payee.City;
      tbState.Text = billpayment1.Payee.State;
      tbPostalCode.Text = billpayment1.Payee.PostalCode;
      tbPhone.Text = billpayment1.Payee.Phone;
      tbAccount.Text = billpayment1.Payee.Account;
    }

    private void ShowError(Exception e)
    {
      String ed = "Error";
      if (e is InEBankException)
        ed += " (" + ((InEBankException)e).Code + ")";
      ed += ": " + e.Message;
      MessageBox.Show(this, ed, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private void DisplayResponse()
    {
      lblCurrency.Text = billpayment1.Payment.CurrencyCode;
      lblPaymentId.Text = billpayment1.Payment.Id;
      lblPaymentDate.Text = billpayment1.Payment.DateProcessed;
      lblStatus.Text = billpayment1.Payment.Status;
      lblCheckNumber.Text = billpayment1.Payment.CheckNumber;
    }

    private void ResetRetVal()
    {
      lblCurrency.Text = "";
      lblPaymentId.Text = "";
      lblPaymentDate.Text = "";
      lblStatus.Text = "";
      lblCheckNumber.Text = "";
    }

    private void tbFIId_TextChanged(object sender, EventArgs e)
    {
      
    }

  }
}






