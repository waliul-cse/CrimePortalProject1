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
    public partial class crime_criminal_activities : System.Web.UI.Page
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
            Crime_Criminal_ActivitiesObject cbiObject = new Crime_Criminal_ActivitiesObject();
            CrimeInformationService cisObj = new CrimeInformationService();

            try
            {
                cbiObject.RefNo = txtRefNo.Text;
                cbiObject.previousAcitivity = txtpreviousAcitivity.Text;
                cbiObject.CurrentActivity = txtCurrentActivity.Text;
                cbiObject.CreateBy = User.Identity.Name;
                cbiObject.CreateDate = DateTime.Now;
                cbiObject.LastUpdateBy = User.Identity.Name;
                cbiObject.LastUpdateDate = DateTime.Now;
                if (cisObj.InsertCrimeActivitiesInformation(cbiObject))
                {
                    Response.Redirect("crime-entry-end.aspx?refno=" + txtRefNo.Text);
                }
            }
            catch (Exception ex)
            {
                ErrorMessage.Text = ex.Message;
            }
        }

        protected void btnSkip_Click(object sender, EventArgs e)
        {
            Response.Redirect("crime-entry-end.aspx?refno=" + txtRefNo.Text);
        }
    }
}