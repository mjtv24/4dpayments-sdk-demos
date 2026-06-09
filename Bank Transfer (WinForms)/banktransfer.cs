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
  public partial class banktransferDemo : Form
  {
    [STAThread]
    static void Main()
    {
      Application.Run(new banktransferDemo());
    }

    public banktransferDemo()
    {
      InitializeComponent();
    }

    private void bTransfer_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor = Cursors.WaitCursor;
        ResetRetVal();
        banktransfer1.OFXAppId = "QWIN";
        banktransfer1.OFXAppVersion = "1700";
        banktransfer1.FIUrl = txtFIUrl.Text;
        banktransfer1.FIId = txtFIId.Text;
        banktransfer1.FIOrganization = txtFIOrganization.Text;
        banktransfer1.OFXUser = txtUserId.Text;
        banktransfer1.OFXPassword = txtPassword.Text;

        TransferDetail tr = new TransferDetail();

        tr.FromBankId = txtFromBankId.Text;
        tr.FromAccountId = txtFromAccountId.Text;
        tr.FromAccountType = (AccountTypes)cmbFromAccountType.SelectedIndex;

        tr.ToBankId = txtToBankId.Text;
        tr.ToAccountId = txtToAccountId.Text;
        tr.ToAccountType = (AccountTypes)cmbToAccountType.SelectedIndex;
        tr.Amount = txtAmount.Text;
        tr.DateDue = dtpDueDate.Text;

        banktransfer1.Transfer = tr;

        // Use this configuration setting to maintain a log of the request
        // banktransfer1.Config("OFXLog=c:\\transfer_request.txt");

        banktransfer1.TransferFunds();

        MessageBox.Show(this, "Transfer completed successfully! If transfer was a scheduled transaction (not immediate), make a note of the Transfer ID if want to modify or cancel this transfer at a later time.", "Transfer Acknowledgment", MessageBoxButtons.OK, MessageBoxIcon.Information);
        DisplayResponse();
      }
      catch (Exception ex)
      { ShowError(ex); }
      finally
      { Cursor = Cursors.Default; }
    }

    private void ShowError(Exception e)
    {
      String ed = "Error";
      if (e is InEBankException)
        ed += " (" + ((InEBankException) e).Code + ")";
      ed += ": " + e.Message;
      MessageBox.Show(this, ed, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private void DisplayResponse()
    {
      lblCurrency.Text = banktransfer1.Transfer.CurrencyCode;
      lblTransferId.Text = banktransfer1.Transfer.Id;
      lblTransferDate.Text = banktransfer1.Transfer.DateProcessed;
      lblStatus.Text = banktransfer1.Transfer.Status;
      lblDatePosted.Text = banktransfer1.Transfer.DatePosted;
    }

    private void ResetRetVal()
    {
      lblCurrency.Text = "";
      lblTransferId.Text = "";
      lblTransferDate.Text = "";
      lblStatus.Text = "";
      lblDatePosted.Text = "";
    }

    private void cmbBankName_SelectedIndexChanged(object sender, EventArgs e)
    {
      txtUserId.Text = "";
      txtPassword.Text = "";
      ResetRetVal();
      try
      {
        switch (cmbBankName.SelectedItem.ToString())
        {
          case "Bank of America":
            txtFIUrl.Text = "https://ofx.bankofamerica.com/cgi-forte/fortecgi?servicename=ofx_2-3&pagename=ofx";
            txtFIOrganization.Text = "HAN";
            txtFIId.Text = "6812";
            txtFromBankId.Text = "011000138";
            txtToBankId.Text = "011000138";
            break;
          case "Bank One - JPMorgan Chase":
            txtFIUrl.Text = "https://onlineofx.chase.com/chase.ofx";
            txtFIOrganization.Text = "B1";
            txtFIId.Text = "5811";
            txtFromBankId.Text = "";  //??
            txtToBankId.Text = "";  //??
            break;
          case "BB&T - Branch Banking and Trust Company":
            txtFIUrl.Text = "https://olb.bbandt.com/ofxsecurity/ofx_security_server.dll";
            txtFIOrganization.Text = "BBT";
            txtFIId.Text = "BBT";
            txtFromBankId.Text = "053101121";
            txtToBankId.Text = "053101121";
            break;
          case "JPMorgan Chase Bank":
            txtFIUrl.Text = "https://www.oasis.cfree.com/1601.ofxgp";
            txtFIOrganization.Text = "Chase Bank";
            txtFIId.Text = "1601";
            txtFromBankId.Text = "021000238";
            txtToBankId.Text = "021000238";
            break;
          case "Mellon Bank":
            txtFIUrl.Text = "https://www.oasis.cfree.com/1226.ofxgp";
            txtFIOrganization.Text = "Mellon Bank";
            txtFIId.Text = "1226";
            txtFromBankId.Text = "031300821";
            txtToBankId.Text = "031300821";
            break;
          case "SunTrust":
            txtFIUrl.Text = "https://www.oasis.cfree.com/2801.ofxgp";
            txtFIOrganization.Text = "SunTrust PC Banking";
            txtFIId.Text = "2801";
            txtFromBankId.Text = "061000104";
            txtToBankId.Text = "061000104";
            break;
          case "Wachovia Bank":
            txtFIUrl.Text = "https://pfmpw.wachovia.com/cgi-forte/fortecgi?servicename=ofx&pagename=PFM";
            txtFIOrganization.Text = "Wachovia";
            txtFIId.Text = "4309";
            txtFromBankId.Text = "053000219";
            txtToBankId.Text = "053000219";
            break;
          case "Wells Fargo":
            txtFIUrl.Text = "https://www.oasis.cfree.com/3001.ofxgp";
            txtFIOrganization.Text = "Wells Fargo";
            txtFIId.Text = "3001";
            txtFromBankId.Text = "041215537";
            txtToBankId.Text = "041215537";
            break;
          case "Zions Bank":
            txtFIUrl.Text = "https://quicken.metavante.com/ofx/OFXServlet";
            txtFIOrganization.Text = "244-3";
            txtFIId.Text = "1115";
            txtFromBankId.Text = "124000054";
            txtToBankId.Text = "124000054";
            break;
        }
      }
      catch (Exception ex)
      {
        ShowError(ex);
      }
    }

    private void banktransferDemo_Load(object sender, EventArgs e)
    {
      dtpDueDate.Text = DateTime.Now.ToString();
    }
  }
}









