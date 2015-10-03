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
    public partial class criminal_education_information : System.Web.UI.Page
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

            Criminal_Education_InformationObject ceiObject = new Criminal_Education_InformationObject();
            CriminalInformationService cisObj = new CriminalInformationService();
            try
            {
                ceiObject.RefNo = txtRefNo.Text;
                ceiObject.EducationalStatus = txtEducationalStatus.Text;
                ceiObject.NameofInstitution = txtNameofInstitution.Text;
                ceiObject.PoliticalInvolvementinInstitution = txtPoliticalInvolvementinInstitution.Text;
                ceiObject.CreateBy = Membership.GetUser().UserName;
                ceiObject.CreateDate = DateTime.Now;
                ceiObject.LastUpdateBy = Membership.GetUser().UserName; ;
                ceiObject.LastUpdateDate = DateTime.Now;
                if (cisObj.InsertEducationInformation(ceiObject))
                {
                    Response.Redirect("criminal-death-information.aspx?refno=" + txtRefNo.Text);
                }
            }
            catch (Exception ex)
            {
                ErrorMessage.Text = ex.Message;
            }
        }

        protected void btnSkip_Click(object sender, EventArgs e)
        {
            Response.Redirect("criminal-death-information.aspx?refno=" + txtRefNo.Text);
        }

        protected void btnAddmore_Click(object sender, EventArgs e)
        {
            Criminal_Education_InformationObject ceiObject = new Criminal_Education_InformationObject();
            CriminalInformationService cisObj = new CriminalInformationService();
            try
            {
                ceiObject.RefNo = txtRefNo.Text;
                ceiObject.EducationalStatus = txtEducationalStatus.Text;
                ceiObject.NameofInstitution = txtNameofInstitution.Text;
                ceiObject.PoliticalInvolvementinInstitution = txtPoliticalInvolvementinInstitution.Text;
                ceiObject.CreateBy = Membership.GetUser().UserName;
                ceiObject.CreateDate = DateTime.Now;
                ceiObject.LastUpdateBy = Membership.GetUser().UserName; ;
                ceiObject.LastUpdateDate = DateTime.Now;
                if (cisObj.InsertEducationInformation(ceiObject))
                {
                    txtEducationalStatus.Text = "";
                    txtNameofInstitution.Text = "";
                    txtPoliticalInvolvementinInstitution.Text = "";
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