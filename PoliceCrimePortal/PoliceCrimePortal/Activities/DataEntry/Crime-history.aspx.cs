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
    public partial class Crime_history : System.Web.UI.Page
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
            Crime_HistoryObject cbiObject = new Crime_HistoryObject();
            CrimeInformationService cisObj = new CrimeInformationService();

            try
            {
                cbiObject.RefNo = txtRefNo.Text;
                cbiObject.CrimeType = ddlCrimeType.SelectedValue;
                cbiObject.Description = txtDescription.Text;
                cbiObject.CrimeCode = txtCrimeCode.Text;
                cbiObject.CrimeDate = Convert.ToDateTime(txtCrimeDate.Text);
                cbiObject.CreateBy = User.Identity.Name;
                cbiObject.CreateDate = DateTime.Now;
                cbiObject.LastUpdateBy = User.Identity.Name;
                cbiObject.LastUpdateDate = DateTime.Now;
                if (cisObj.InsertCrimeHistory(cbiObject))
                {
                    Response.Redirect("crime-case-details.aspx?refno=" + txtRefNo.Text);
                }
            }
            catch (Exception ex)
            {
                ErrorMessage.Text = ex.Message;
            }
        }

        protected void btnSkip_Click(object sender, EventArgs e)
        {
            Response.Redirect("crime-case-details.aspx?refno=" + txtRefNo.Text);
        }
    }
}