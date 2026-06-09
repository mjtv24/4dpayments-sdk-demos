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
  public partial class accountinfoDemo : Form
  {
    [STAThread]
    static void Main()
    {
      ApplicationConfiguration.Initialize();
      Application.Run(new accountinfoDemo());
    }

    public accountinfoDemo()
    {
      InitializeComponent();
    }
    private void btnGetAccountInfo_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor = Cursors.WaitCursor;
        lvAccounts.Items.Clear();
        account1.FIUrl = txtUrl.Text;
        account1.FIOrganization = txtFIOrganization.Text;
        account1.FIId = txtFIId.Text;
        account1.OFXAppId = "QWIN";
        account1.OFXAppVersion = "1800";
        account1.OFXUser = txtUserId.Text;
        account1.OFXPassword = txtPassword.Text;

        account1.GetInfo();
        ShowDetails();
      }
      catch (Exception ex)
      { ShowError(ex); }
      finally
      { Cursor = Cursors.Default; account1.Reset(); }
    }

    private void ShowError(Exception e)
    {
      String ed = "Error";
      if (e is InEBankException)
        ed += " (" + ((InEBankException)e).Code + ")";
      ed += ": " + e.Message;
      MessageBox.Show(this, ed, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private void ShowDetails()
    {
      lvAccounts.Items.Clear();
      for (int i = 0; i < account1.Accounts.Count; i++)
      {
        String[] newRow = new String[] {
                            account1.Accounts[i].Id,
                            account1.Accounts[i].AccType,
                            account1.Accounts[i].BankId,
                            account1.Accounts[i].Description,
                            account1.Accounts[i].Status,
                            account1.Accounts[i].IsTransferSource.ToString(),
                            account1.Accounts[i].IsTransferDestination.ToString()
                          };
        lvAccounts.Items.Add(new ListViewItem(newRow));
      }
    }

    private void cmbBank_SelectedIndexChanged(object sender, EventArgs e)
    {
      txtPassword.Text = "";
      txtUserId.Text = "";
      try
      {
        switch (cmbBank.SelectedItem.ToString())
        {
          case "American Express":
            txtUrl.Text = "https://online.americanexpress.com/myca/ofxdl/desktop/desktopDownload.do?request_type=nl_ofxdownload";
            txtFIOrganization.Text = "AMEX";
            txtFIId.Text = "3101";
            break;
          case "Bank of America":
            txtUrl.Text = "https://ofx.bankofamerica.com/cgi-forte/fortecgi?servicename=ofx_2-3&pagename=ofx";
            txtFIOrganization.Text = "HAN";
            txtFIId.Text = "6812";
            break;
          case "Bank One - JPMorgan Chase":
            txtUrl.Text = "https://onlineofx.chase.com/chase.ofx";
            txtFIOrganization.Text = "B1";
            txtFIId.Text = "5811";
            break;
          case "BB&T - Branch Banking and Trust Company":
            txtUrl.Text = "https://olb.bbandt.com/ofxsecurity/ofx_security_server.dll";
            txtFIOrganization.Text = "BBT";
            txtFIId.Text = "BBT";
            break;
          case "JPMorgan Chase Bank":
            txtUrl.Text = "https://www.oasis.cfree.com/1601.ofxgp";
            txtFIOrganization.Text = "Chase Bank";
            txtFIId.Text = "1601";
            break;
          case "Mellon Bank":
            txtUrl.Text = "https://www.oasis.cfree.com/1226.ofxgp";
            txtFIOrganization.Text = "Mellon Bank";
            txtFIId.Text = "1226";
            break;
          case "SunTrust":
            txtUrl.Text = "https://www.oasis.cfree.com/2801.ofxgp";
            txtFIOrganization.Text = "SunTrust PC Banking";
            txtFIId.Text = "2801";
            break;
          case "Wachovia Bank":
            txtUrl.Text = "https://pfmpw.wachovia.com/cgi-forte/fortecgi?servicename=ofx&pagename=PFM";
            txtFIOrganization.Text = "Wachovia";
            txtFIId.Text = "4309";
            break;
          case "Wells Fargo":
            txtUrl.Text = "https://www.oasis.cfree.com/3001.ofxgp";
            txtFIOrganization.Text = "Wells Fargo";
            txtFIId.Text = "3001";
            break;
          case "Zions Bank":
            txtUrl.Text = "https://quicken.metavante.com/ofx/OFXServlet";
            txtFIOrganization.Text = "244-3";
            txtFIId.Text = "1115";
            break;
          case "(YOUR BANK NAME)":
            txtUrl.Text = "";
            txtFIOrganization.Text = "";
            txtFIId.Text = "";
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







