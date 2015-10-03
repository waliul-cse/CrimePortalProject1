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
    public partial class criminal_travel_information : System.Web.UI.Page
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
            Criminal_Travel_InformationObject ctiObject = new Criminal_Travel_InformationObject();
            CriminalInformationService cisObj = new CriminalInformationService();
            try
            {
                ctiObject.RefNo = txtRefNo.Text;
                ctiObject.CountryVisited = txtCountryVisited.Text;
                ctiObject.ArrivalDate = Convert.ToDateTime(txtArrivalDate.Text);
                ctiObject.DepartureDate = Convert.ToDateTime(txtDepartureDate.Text);
                ctiObject.Duration = txtDuration.Text;
                ctiObject.AddressAbroad = txtAddressAbroad.Text;
                ctiObject.CreateBy = Membership.GetUser().UserName;
                ctiObject.CreateDate = DateTime.Now;
                ctiObject.LastUpdateBy = Membership.GetUser().UserName;
                ctiObject.LastUpdateDate = DateTime.Now;
                if (cisObj.InsertTravelInformation(ctiObject))
                {
                    Response.Redirect("creminal-bank-account-details.aspx?refno=" + txtRefNo.Text);
                }
            }
            catch (Exception ex)
            {
                ErrorMessage.Text = ex.Message;
            }
        }

        protected void btnSkip_Click(object sender, EventArgs e)
        {
            Response.Redirect("creminal-bank-account-details.aspx?refno=" + txtRefNo.Text);
        }

        protected void btnAddmore_Click(object sender, EventArgs e)
        {
            Criminal_Travel_InformationObject ctiObject = new Criminal_Travel_InformationObject();
            CriminalInformationService cisObj = new CriminalInformationService();
            try
            {
                ctiObject.RefNo = txtRefNo.Text;
                ctiObject.CountryVisited = txtCountryVisited.Text;
                ctiObject.ArrivalDate = Convert.ToDateTime(txtArrivalDate.Text);
                ctiObject.DepartureDate = Convert.ToDateTime(txtDepartureDate.Text);
                ctiObject.Duration = txtDuration.Text;
                ctiObject.AddressAbroad = txtAddressAbroad.Text;
                ctiObject.CreateBy = Membership.GetUser().UserName;
                ctiObject.CreateDate = DateTime.Now;
                ctiObject.LastUpdateBy = Membership.GetUser().UserName;
                ctiObject.LastUpdateDate = DateTime.Now;
                if (cisObj.InsertTravelInformation(ctiObject))
                {
                    txtCountryVisited.Text = "";
                    txtArrivalDate.Text = "";
                    txtDepartureDate.Text = "";
                    txtDuration.Text = "";
                    txtAddressAbroad.Text = "";
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