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
  public partial class fiprofileDemo : Form
  {

    [STAThread]
    static void Main()
    {
      Application.Run(new fiprofileDemo());
    }
    public fiprofileDemo()
    {
      InitializeComponent();
    }

    private void btnGet_Click(object sender, EventArgs e)
    {
      fiprofile1.FIUrl = txtURL.Text;
      fiprofile1.OFXUser = txtUserID.Text;
      fiprofile1.OFXPassword = txtPassword.Text;
      fiprofile1.FIOrganization = txtFIOrganization.Text;
      fiprofile1.FIId = txtFIId.Text;
      fiprofile1.OFXAppId = "QWIN";
      fiprofile1.OFXAppVersion = "1800";
      //fiprofile1.Config("OFXLog=fi.txt");
      try
      {
        Cursor = Cursors.WaitCursor;

        fiprofile1.GetProfile();

        PopulateDetails();
      }

      catch (Exception ex)
      { ShowError(ex); }
      finally
      {
        Cursor = Cursors.Default;
        fiprofile1.Reset();
      }
    }

    private void ShowError(Exception e)
    {
      String ed = "Error";
      if (e is InEBankException)
        ed += " (" + ((InEBankException) e).Code + ")";
      ed += ": " + e.Message;
      MessageBox.Show(this, ed, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private void PopulateDetails()
    {
      ResponseDemo frmResponse = new ResponseDemo();

      frmResponse.MyForm1 = this;

      frmResponse.lsvwGeneralInfo.Items.Clear();

      frmResponse.lsvwGeneralInfo.Items.Add("FI Name:                ").SubItems.Add(fiprofile1.FIName);
      frmResponse.lsvwGeneralInfo.Items.Add("Profile Date            ").SubItems.Add(fiprofile1.FIProfileDate);
      frmResponse.lsvwGeneralInfo.Items.Add("Email Address:          ").SubItems.Add(fiprofile1.FIEmailAddress);
      frmResponse.lsvwGeneralInfo.Items.Add("Customer Service Phone: ").SubItems.Add(fiprofile1.FICustomerServicePhone);
      frmResponse.lsvwGeneralInfo.Items.Add("Tech Support Phone:     ").SubItems.Add(fiprofile1.FITechSupportPhone);
      frmResponse.lsvwGeneralInfo.Items.Add("Address:                ").SubItems.Add(fiprofile1.FIAddress1 + "," + fiprofile1.FIAddress2 + "," + fiprofile1.FIAddress3);
      frmResponse.lsvwGeneralInfo.Items.Add("City:                   ").SubItems.Add(fiprofile1.FICity);
      frmResponse.lsvwGeneralInfo.Items.Add("State:                  ").SubItems.Add(fiprofile1.FIState);
      frmResponse.lsvwGeneralInfo.Items.Add("Postal Code:            ").SubItems.Add(fiprofile1.FIPostalCode);
      frmResponse.lsvwGeneralInfo.Items.Add("Country:                ").SubItems.Add(fiprofile1.FICountry);
      frmResponse.lsvwGeneralInfo.Items.Add("Home Page:              ").SubItems.Add(fiprofile1.FIHomePage);
      frmResponse.lsvwGeneralInfo.Items.Add("Last Update:            ").SubItems.Add(fiprofile1.LastUpdate);
      frmResponse.lsvwGeneralInfo.Columns[0].TextAlign = HorizontalAlignment.Right;

      // here it is assumed FI contains only one SignOnInfo
      frmResponse.lsvwSignOnInfo.Items.Add("Password Case Sensitive:      ").SubItems.Add(fiprofile1.SignOnDetails[0].CaseSensitive.ToString());
      frmResponse.lsvwSignOnInfo.Items.Add("Password Char Type:           ").SubItems.Add(fiprofile1.SignOnDetails[0].CharType.ToString());
      frmResponse.lsvwSignOnInfo.Items.Add("Password with Spaces:         ").SubItems.Add(fiprofile1.SignOnDetails[0].Spaces.ToString());
      frmResponse.lsvwSignOnInfo.Items.Add("Password with Special Chars:  ").SubItems.Add(fiprofile1.SignOnDetails[0].Special.ToString());
      frmResponse.lsvwSignOnInfo.Items.Add("Password Minimum Length:      ").SubItems.Add(fiprofile1.SignOnDetails[0].MinPwdLength.ToString());
      frmResponse.lsvwSignOnInfo.Items.Add("Password Maximum Length:      ").SubItems.Add(fiprofile1.SignOnDetails[0].MaxPwdLength.ToString());
      frmResponse.lsvwSignOnInfo.Items.Add("PIN change:                   ").SubItems.Add(fiprofile1.SignOnDetails[0].PINChange.ToString());
      frmResponse.lsvwSignOnInfo.Items.Add("PIN Change First:             ").SubItems.Add(fiprofile1.SignOnDetails[0].PINChangeFirst.ToString());
      frmResponse.lsvwSignOnInfo.Items.Add("Authorization Token:          ").SubItems.Add(fiprofile1.SignOnDetails[0].AuthToken);
      frmResponse.lsvwSignOnInfo.Items.Add("Authorization Token First:    ").SubItems.Add(fiprofile1.SignOnDetails[0].AuthTokenFirst.ToString());
      frmResponse.lsvwSignOnInfo.Items.Add("Authorization Token Url:      ").SubItems.Add(fiprofile1.SignOnDetails[0].AuthTokenUrl);
      frmResponse.lsvwSignOnInfo.Items.Add("MFA Challenge Required:       ").SubItems.Add(fiprofile1.SignOnDetails[0].MFAChallengeReq.ToString());
      frmResponse.lsvwSignOnInfo.Items.Add("MFA Challenge First:          ").SubItems.Add(fiprofile1.SignOnDetails[0].MFAChallengeFirst.ToString());
      frmResponse.lsvwSignOnInfo.Items.Add("Client Unique ID Required:    ").SubItems.Add(fiprofile1.SignOnDetails[0].ClientUIdReq.ToString());
      frmResponse.lsvwSignOnInfo.Items.Add("User Credential Question #1:  ").SubItems.Add(fiprofile1.SignOnDetails[0].UserCred1Q);
      frmResponse.lsvwSignOnInfo.Items.Add("User Credential Question #2:  ").SubItems.Add(fiprofile1.SignOnDetails[0].UserCred2Q);
      frmResponse.lsvwSignOnInfo.Columns[0].TextAlign = HorizontalAlignment.Right;

      frmResponse.lvMessageSets.Items.Clear();

      for (int i = 0; i < fiprofile1.MessageSets.Count; i++)
      {
        String[] newRow = new String[] {
									   fiprofile1.MessageSets[i].Name,
                                       fiprofile1.MessageSets[i].SecurityLevel,
                                       fiprofile1.MessageSets[i].TransportSecurity.ToString(),
                                       fiprofile1.MessageSets[i].Recovery.ToString(),
                                       fiprofile1.MessageSets[i].Refresh.ToString(),
                                       fiprofile1.MessageSets[i].SyncMode,
                                       fiprofile1.MessageSets[i].TxImage.ToString(),
                                       fiprofile1.MessageSets[i].ClosingInfoAvailability.ToString(),
                                       fiprofile1.MessageSets[i].ClosingInfoImage.ToString(),
                                       fiprofile1.MessageSets[i].URL
								   };
        frmResponse.lvMessageSets.Items.Add(new ListViewItem(newRow));
      }

      frmResponse.Show();
    }

    private void fiprofile1_OnSSLServerAuthentication(object sender, DPayments.InEBank.FiprofileSSLServerAuthenticationEventArgs e)
    {
      e.Accept = true;
    }

    private void cmbBank_SelectedIndexChanged(object sender, EventArgs e)
    {
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
          case "E*TRADE":
            txtURL.Text = "https://ofx.etrade.com/cgi-ofx/etradeofx";
            txtFIOrganization.Text = "fldProv_mId";
            txtFIId.Text = "fldProv_mProvBankId";
            break;
          case "Edward Jones":
            txtURL.Text = "https://ofx.edwardjones.com";
            txtFIOrganization.Text = "Edward Jones";
            txtFIId.Text = "823";
            break;
          case "Fidelity Investments":
            txtURL.Text = "https://ofx.fidelity.com/ftgw/OFX/clients/download";
            txtFIOrganization.Text = "fidelity.com";
            txtFIId.Text = "7776";
            break;
          case "Merrill Lynch & Co.":
            txtURL.Text = "https://taxcert.mlol.ml.com/eftxweb/access.ofx";
            txtFIOrganization.Text = "Merrill Lynch&Co., Inc.";
            txtFIId.Text = "5550";
            break;
          case "Regions Bank":
            txtURL.Text = "https://ofx.morgankeegan.com/begasp/directtocore.asp";
            txtFIOrganization.Text = "regions.com";
            txtFIId.Text = "243";
            break;
          case "TD Ameritrade":
            txtURL.Text = "https://ofxs.ameritrade.com/cgi-bin/apps/OFX";
            txtFIOrganization.Text = "Ameritrade";
            break;
          case "Wachovia Bank":
            txtURL.Text = "https://pfmpw.wachovia.com/cgi-forte/fortecgi?servicename=ofx&pagename=PFM";
            txtFIOrganization.Text = "Wachovia";
            txtFIId.Text = "4309";
            break;
          case "Wells Fargo Investments":
            txtURL.Text = "https://invmnt.wellsfargo.com/inv/directConnect";
            txtFIOrganization.Text = "wellsfargo.com";
            txtFIId.Text = "10762";
            break;
          case "(YOUR BANK NAME)":
            txtURL.Text = "";
            txtFIOrganization.Text = "";
            txtFIId.Text = "";
            break;
        }
      }
      catch (Exception ex)
      { ShowError(ex); }
    }
  }
}







