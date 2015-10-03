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
    public partial class crime_zone_information : System.Web.UI.Page
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
            Crime_ZoneObject cbiObject = new Crime_ZoneObject();
            CrimeInformationService cisObj = new CrimeInformationService();

            try
            {
                cbiObject.RefNo = txtRefNo.Text;
                cbiObject.Battalion = txtBattalion.Text;
                cbiObject.District = txtDistrict.Text;
                cbiObject.PoliceStation = txtPoliceStation.Text;
                cbiObject.Village = txtVillage.Text;
                cbiObject.Latitude = txtlatitude.Text;
                cbiObject.Longitude = txtlongitude.Text;
                cbiObject.Remarks = txtRemarks.Text;
                cbiObject.CreateBy = User.Identity.Name;
                cbiObject.CreateDate = DateTime.Now;
                cbiObject.LastUpdateBy = User.Identity.Name;
                cbiObject.LastUpdateDate = DateTime.Now;
                if (cisObj.InsertCrimeZone(cbiObject))
                {
                    Response.Redirect("crime-remand-information.aspx?refno=" + txtRefNo.Text);
                }
            }
            catch (Exception ex)
            {
                ErrorMessage.Text = ex.Message;
            }
        }

        protected void btnSkip_Click(object sender, EventArgs e)
        {
            Response.Redirect("crime-remand-information.aspx?refno=" + txtRefNo.Text);
        }
    }
}