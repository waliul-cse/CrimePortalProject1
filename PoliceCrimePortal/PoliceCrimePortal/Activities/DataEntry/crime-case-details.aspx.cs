using PoliceCrimePortal.Data.DAO;
using PoliceCrimePortal.Service.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PoliceCrimePortal.Activities.DataEntry
{
    public partial class crime_case_details : System.Web.UI.Page
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
            Crime_Case_DetailsObject cbiObject = new Crime_Case_DetailsObject();
            CrimeInformationService cisObj = new CrimeInformationService();

            try
            {
                cbiObject.RefNo = txtRefNo.Text;
                cbiObject.CaseNo = txtCaseNo.Text;
                cbiObject.District = txtDistrict.Text;
                cbiObject.Thana = txtThana.Text;
                cbiObject.Date = Convert.ToDateTime(txtDate.Text);
                cbiObject.CreateBy = User.Identity.Name;
                cbiObject.CreateDate = DateTime.Now;
                cbiObject.LastUpdateBy = User.Identity.Name;
                cbiObject.LastUpdateDate = DateTime.Now;
                if (cisObj.InsertCrimeCaseDetails(cbiObject))
                {
                    Response.Redirect("crime-zone-information.aspx?refno=" + txtRefNo.Text);
                }
            }
            catch (Exception ex)
            {
                ErrorMessage.Text = ex.Message;
            }
        }

        protected void btnSkip_Click(object sender, EventArgs e)
        {
            Response.Redirect("crime-zone-information.aspx?refno=" + txtRefNo.Text);
        }
    }
}