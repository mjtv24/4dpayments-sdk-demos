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
  public partial class ccstatementDemo : Form
  {

    [STAThread]
    static void Main()
    {
      Application.Run(new ccstatementDemo());
    }

    public ccstatementDemo()
    {
      InitializeComponent();
    }

    private void bGetStatement_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor = Cursors.WaitCursor;

        ccstatement1.OFXAppId = "QWIN";
        ccstatement1.OFXAppVersion = "1800";
        ccstatement1.FIUrl = txtURL.Text;
        ccstatement1.FIId = txtFIId.Text;
        ccstatement1.FIOrganization = txtFIOrganization.Text;
        ccstatement1.CardNumber = txtCardNumber.Text;
        ccstatement1.OFXUser = txtUserId.Text;
        ccstatement1.OFXPassword = txtPassword.Text;
        ccstatement1.StartDate = dtpStartDate.Text;
        ccstatement1.EndDate = dtpEndDate.Text;

        ccstatement1.GetStatement();

        ShowDetails();
      }
      catch (Exception ex)
      {
        ShowError(ex);
      }
      finally
      {
        Cursor = Cursors.Default;
        ccstatement1.Reset();
      }
    }

    private void ShowDetails()
    {
      ResponseDemo frmResponse = new ResponseDemo();

      frmResponse.MyForm1 = this;

      frmResponse.lsvwTransactions.Items.Clear();
      frmResponse.lblPostedBalance.Text = ccstatement1.LedgerBalance + " " + ccstatement1.CurrencyCode;
      frmResponse.lblPostedBalanceDate.Text = ccstatement1.LedgerBalanceDate;
      frmResponse.lblAvailableBalance.Text = ccstatement1.AvailableBalance;
      frmResponse.lblAvailableBalanceDate.Text = ccstatement1.AvailableBalanceDate;

      for (int i = 0; i < ccstatement1.Transactions.Count; i++)
      {
        String[] newRow = new String[] {
											   ccstatement1.Transactions[i].DatePosted,
											   ccstatement1.Transactions[i].TypeDescription,
											   ccstatement1.Transactions[i].Amount,
											   ccstatement1.Transactions[i].PayeeName
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
        ccstatement1.Reset();
        ccstatement1.ReadOFXDataFile(txtFileName.Text);
        ShowDetails();
      }
      catch (Exception ex)
      {
        ShowError(ex);
      }
      finally
      {
        Cursor = Cursors.Default;
        ccstatement1.Reset();
      }
    }

    private void cmbBank_SelectedIndexChanged(object sender, EventArgs e)
    {
      txtUserId.Text = "";
      txtPassword.Text = "";
      try
      {
        switch (cmbBank.SelectedItem.ToString())
        {
          case "American Express":
            txtURL.Text = "https://online.americanexpress.com/myca/ofxdl/desktop/desktopDownload.do?request_type=nl_ofxdownload";
            txtFIOrganization.Text = "AMEX";
            txtFIId.Text = "3101";
            break;
          case "Bank of America":
            txtURL.Text = "https://ofx.bankofamerica.com/cgi-forte/fortecgi?servicename=ofx_2-3&pagename=ofx";
            txtFIOrganization.Text = "HAN";
            txtFIId.Text = "6812";
            break;
          case "Bank One - JPMorgan Chase":
            txtURL.Text = "https://onlineofx.chase.com/chase.ofx";
            txtFIOrganization.Text = "B1";
            txtFIId.Text = "5811";
            break;
          case "BB&T - Branch Banking and Trust Company":
            txtURL.Text = "https://olb.bbandt.com/ofxsecurity/ofx_security_server.dll";
            txtFIOrganization.Text = "BBT";
            txtFIId.Text = "BBT";
            break;
          case "Chase (credit card)":
            txtURL.Text = "https://onlineofx.chase.com/chase.ofx";
            txtFIOrganization.Text = "B1";
            txtFIId.Text = "10898";
            break;
          case "JPMorgan Chase Bank":
            txtURL.Text = "https://www.oasis.cfree.com/1601.ofxgp";
            txtFIOrganization.Text = "Chase Bank";
            txtFIId.Text = "1601";
            break;
          case "Mellon Bank":
            txtURL.Text = "https://www.oasis.cfree.com/1226.ofxgp";
            txtFIOrganization.Text = "Mellon Bank";
            txtFIId.Text = "1226";
            break;
          case "SunTrust":
            txtURL.Text = "https://www.oasis.cfree.com/2801.ofxgp";
            txtFIOrganization.Text = "SunTrust PC Banking";
            txtFIId.Text = "2801";
            break;
          case "Wachovia Bank":
            txtURL.Text = "https://pfmpw.wachovia.com/cgi-forte/fortecgi?servicename=ofx&pagename=PFM";
            txtFIOrganization.Text = "Wachovia";
            txtFIId.Text = "4309";
            break;
          case "Wells Fargo":
            txtURL.Text = "https://www.oasis.cfree.com/3001.ofxgp";
            txtFIOrganization.Text = "Wells Fargo";
            txtFIId.Text = "3001";
            break;
          case "Zions Bank":
            txtURL.Text = "https://quicken.metavante.com/ofx/OFXServlet";
            txtFIOrganization.Text = "244-3";
            txtFIId.Text = "1115";
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







