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
  public partial class bankstatementDemo : Form
  {
    [STAThread]
    static void Main()
    {
      Application.Run(new bankstatementDemo());
    }

    public bankstatementDemo()
    {
      InitializeComponent();
    }
    private void bankstatementDemo_Load(object sender, EventArgs e)
    {
      cmbAccountType.SelectedIndex = 0;
    }

    private void bGetStatement_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor = Cursors.WaitCursor;

        bankstatement1.OFXAppId = "QWIN";
        bankstatement1.OFXAppVersion = "1700";
        bankstatement1.FIUrl = txtURL.Text;
        bankstatement1.FIId = txtFIId.Text;
        bankstatement1.FIOrganization = txtFIOrganization.Text;
        bankstatement1.BankId = txtBankId.Text;
        bankstatement1.AccountId = txtAccountNumber.Text;
        bankstatement1.AccountType = (BankstatementAccountTypes) cmbAccountType.SelectedIndex;
        bankstatement1.OFXUser = txtUserId.Text;
        bankstatement1.OFXPassword = txtPassword.Text;
        bankstatement1.StartDate = dtpStartDate.Text;
        bankstatement1.EndDate = dtpEndDate.Text;

        bankstatement1.GetStatement();

        ShowDetails();
      }
      catch (Exception ex)
      {
        ShowError(ex);
      }
      finally
      {
        Cursor = Cursors.Default;
        bankstatement1.Reset();
      }
    }

    private void ShowDetails()
    {
      ResponseDemo frmResponse = new ResponseDemo();

      frmResponse.MyForm1 = this;

      frmResponse.lsvwTransactions.Items.Clear();
      frmResponse.lblPostedBalance.Text = bankstatement1.LedgerBalance + " " + bankstatement1.CurrencyCode;
      frmResponse.lblPostedBalanceDate.Text = bankstatement1.LedgerBalanceDate;
      frmResponse.lblAvailableBalance.Text = bankstatement1.AvailableBalance;
      frmResponse.lblAvailableBalanceDate.Text = bankstatement1.AvailableBalanceDate;

      for (int i = 0; i < bankstatement1.Transactions.Count; i++)
      {
        String[] newRow = new String[] {
											   bankstatement1.Transactions[i].DatePosted,
											   bankstatement1.Transactions[i].TypeDescription,
											   bankstatement1.Transactions[i].CheckNumber,
											   bankstatement1.Transactions[i].Amount,
											   bankstatement1.Transactions[i].PayeeName
										   };
        frmResponse.lsvwTransactions.Items.Add(new ListViewItem(newRow));
      }
      frmResponse.Show();
    }

    private void ShowError(Exception e)
    {
      String ed = "Error";
      if (e is InEBankException)
        ed += " (" + ((InEBankException) e).Code + ")";
      ed += ": " + e.Message;
      MessageBox.Show(this, ed, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private void btnRead_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor = Cursors.WaitCursor;
        bankstatement1.Reset();
        bankstatement1.ReadOFXDataFile(txtFileName.Text);
        ShowDetails();
      }
      catch (Exception ex)
      {
        ShowError(ex);
      }
      finally
      {
        Cursor = Cursors.Default;
        bankstatement1.Reset();
      }
    }

    private void cmbBank_SelectedIndexChanged(object sender, EventArgs e)
    {
      try
      {
        switch (cmbBank.SelectedItem.ToString())
        {
          case "Bank of America":
            txtURL.Text = "https://ofx.bankofamerica.com/cgi-forte/fortecgi?servicename=ofx_2-3&pagename=ofx";
            txtFIOrganization.Text = "HAN";
            txtFIId.Text = "6812";
            txtBankId.Text = "011000138";
            break;
          case "Bank One - JPMorgan Chase":
            txtURL.Text = "https://onlineofx.chase.com/chase.ofx";
            txtFIOrganization.Text = "B1";
            txtFIId.Text = "5811";
            txtBankId.Text = "";  //??
            break;
          case "BB&T - Branch Banking and Trust Company":
            txtURL.Text = "https://olb.bbandt.com/ofxsecurity/ofx_security_server.dll";
            txtFIOrganization.Text = "BBT";
            txtFIId.Text = "BBT";
            txtBankId.Text = "053101121";
            break;
          case "JPMorgan Chase Bank":
            txtURL.Text = "https://www.oasis.cfree.com/1601.ofxgp";
            txtFIOrganization.Text = "Chase Bank";
            txtFIId.Text = "1601";
            txtBankId.Text = "021000238";
            break;
          case "Mellon Bank":
            txtURL.Text = "https://www.oasis.cfree.com/1226.ofxgp";
            txtFIOrganization.Text = "Mellon Bank";
            txtFIId.Text = "1226";
            txtBankId.Text = "031300821";
            break;
          case "SunTrust":
            txtURL.Text = "https://www.oasis.cfree.com/2801.ofxgp";
            txtFIOrganization.Text = "SunTrust PC Banking";
            txtFIId.Text = "2801";
            txtBankId.Text = "061000104";
            break;
          case "Wachovia Bank":
            txtURL.Text = "https://pfmpw.wachovia.com/cgi-forte/fortecgi?servicename=ofx&pagename=PFM";
            txtFIOrganization.Text = "Wachovia";
            txtFIId.Text = "4309";
            txtBankId.Text = "053000219";
            break;
          case "Wells Fargo":
            txtURL.Text = "https://www.oasis.cfree.com/3001.ofxgp";
            txtFIOrganization.Text = "Wells Fargo";
            txtFIId.Text = "3001";
            txtBankId.Text = "041215537";
            break;
          case "Zions Bank":
            txtURL.Text = "https://quicken.metavante.com/ofx/OFXServlet";
            txtFIOrganization.Text = "244-3";
            txtFIId.Text = "1115";
            txtBankId.Text = "124000054";
            break;
          case "(YOUR BANK NAME)":
            txtURL.Text = "";
            txtFIOrganization.Text = "";
            txtFIId.Text = "";
            txtBankId.Text = "";
            break;
        }
      }
      catch (Exception ex)
      {
        ShowError(ex);
      }
    }
  }
}







