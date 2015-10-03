using PoliceCrimePortal.Data.DAO;
using PoliceCrimePortal.Service.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PoliceCrimePortal.Activities.DataEntry
{
    public partial class creminal_bank_account_details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    txtRefNo.Text = Request.QueryString["refno"];
                }
            }
            catch (Exception ex)
            { }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Criminal_Bank_Account_DetailsObject cbadObject = new Criminal_Bank_Account_DetailsObject();
            CriminalInformationService cisObj = new CriminalInformationService();
            try
            {
                cbadObject.RefNo = txtRefNo.Text;
                cbadObject.BankName = txtBankName.Text;
                cbadObject.AccountNo = txtAccountNo.Text;
                cbadObject.AccountType = txtAccountType.Text;
                cbadObject.CreditCardNo = txtCreditCardNo.Text;
                cbadObject.DebitCardNo = txtDebitCardNo.Text;
                cbadObject.CreateBy = Membership.GetUser().UserName;
                cbadObject.CreateDate = DateTime.Now;
                cbadObject.LastUpdateBy = Membership.GetUser().UserName;
                cbadObject.LastUpdateDate = DateTime.Now;
                if (cisObj.InsertTravelInformation(cbadObject))
                {
                    Response.Redirect("crime-basic-information.aspx?refno=" + txtRefNo.Text);
                }
            }
            catch (Exception ex)
            {
                ErrorMessage.Text = ex.Message;
            }
        }

        protected void btnSkip_Click(object sender, EventArgs e)
        {
            Response.Redirect("crime-basic-information.aspx?refno=" + txtRefNo.Text);
        }

        protected void btnAddmore_Click(object sender, EventArgs e)
        {
            Criminal_Bank_Account_DetailsObject cbadObject = new Criminal_Bank_Account_DetailsObject();
            CriminalInformationService cisObj = new CriminalInformationService();
            try
            {
                cbadObject.RefNo = txtRefNo.Text;
                cbadObject.BankName = txtBankName.Text;
                cbadObject.AccountNo = txtAccountNo.Text;
                cbadObject.AccountType = txtAccountType.Text;
                cbadObject.CreditCardNo = txtCreditCardNo.Text;
                cbadObject.DebitCardNo = txtDebitCardNo.Text;
                cbadObject.CreateBy = Membership.GetUser().UserName;
                cbadObject.CreateDate = DateTime.Now;
                cbadObject.LastUpdateBy = Membership.GetUser().UserName;
                cbadObject.LastUpdateDate = DateTime.Now;
                if (cisObj.InsertTravelInformation(cbadObject))
                {
                    txtRefNo.Text = txtRefNo.Text;
                    txtBankName.Text = "";
                    txtAccountNo.Text = "";
                    txtAccountType.Text = "";
                    txtCreditCardNo.Text = "";
                    txtDebitCardNo.Text = "";
                    SuccessMessage.Text = "One record Added.";
                }
            }
            catch (Exception ex)
            {
                ErrorMessage.Text = ex.Message;
            }
        }
    }
}