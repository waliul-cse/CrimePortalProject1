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
    public partial class crime_basic_information : System.Web.UI.Page
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
            Crime_Basic_InformationObject cbiObject = new Crime_Basic_InformationObject();
            CrimeInformationService cisObj = new CrimeInformationService();
            try
            {
                cbiObject.CreminalRef = txtRefNo.Text;
                cbiObject.CriminalStatus = rblCriminalStatus.SelectedValue;
                cbiObject.GangName = txtGangName.Text;
                cbiObject.CrimeType = ddlCrimeType.SelectedValue;
                cbiObject.IllegalArmsPossession = rblIllegalArmsPossession.SelectedValue;
                cbiObject.Remarks = txtRemarks.Text;
                cbiObject.LegalArmsPossession = rbllegalArmsPossession.SelectedValue;
                cbiObject.PriorityListGovt = txtPriorityListGovt.Text;
                cbiObject.CaseDetails = txtCaseDetails.Text;
                cbiObject.LastState = txtLastState.Text;
                cbiObject.CreateBy = User.Identity.Name;
                cbiObject.CreateDate = DateTime.Now;
                cbiObject.LastUpdateBy = User.Identity.Name;
                cbiObject.LastUpdateDate = DateTime.Now;
                if (cisObj.InsertCrimeBasicInformation(cbiObject))
                {
                    Response.Redirect("crime-history.aspx?refno=" + txtRefNo.Text);
                }
            }
            catch (Exception ex)
            {
                ErrorMessage.Text = ex.Message;
            }
        }

        protected void btnSkip_Click(object sender, EventArgs e)
        {
            Response.Redirect("crime-history.aspx?refno=" + txtRefNo.Text);
        }
    }
}