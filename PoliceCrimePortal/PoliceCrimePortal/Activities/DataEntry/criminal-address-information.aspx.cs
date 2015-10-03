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
    public partial class criminal_Address_information : System.Web.UI.Page
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
            Criminal_Address_InformationObject caiObject = new Criminal_Address_InformationObject();
            CriminalInformationService cisObj = new CriminalInformationService();

            try
            {
                caiObject.PermanentAddress.District = txtperDistrict.Text;
                caiObject.PermanentAddress.Upozila = txtPerUplozila.Text;
                caiObject.PermanentAddress.UnionWard = txtPerUnion.Text;
                caiObject.PermanentAddress.Village = txtPerVillage.Text;
                caiObject.PermanentAddress.CreateBy = Membership.GetUser().UserName; ;
                caiObject.PermanentAddress.CreateDate = DateTime.Now;
                caiObject.PermanentAddress.LastUpdateBy = Membership.GetUser().UserName; ;
                caiObject.PermanentAddress.LastUpdateDate = DateTime.Now;

                caiObject.PresentAddress.District = txtPreDistrict.Text;
                caiObject.PresentAddress.Upozila = txtPreUpozila.Text;
                caiObject.PresentAddress.UnionWard = txtPreUnion.Text;
                caiObject.PresentAddress.Village = txtPreVillage.Text;
                caiObject.PresentAddress.CreateBy = Membership.GetUser().UserName; ;
                caiObject.PresentAddress.CreateDate = DateTime.Now;
                caiObject.PresentAddress.LastUpdateBy = Membership.GetUser().UserName; ;
                caiObject.PresentAddress.LastUpdateDate = DateTime.Now;


                caiObject.RefNo = txtRefNo.Text;
                caiObject.LastAddressRegion = txtLastAddressRegion.Text;
                caiObject.DurationofStay = txtDurationofStay.Text;
                caiObject.Remarks = txtRemarks.Text;
                caiObject.WorkingArea = txtWorkingArea.Text;
                caiObject.PhoneNo = txtPhoneNo.Text;
                caiObject.MobileNo = txtMobileNo.Text;
                caiObject.email = txtEmail.Text;
                caiObject.CreateBy = Membership.GetUser().UserName; ;
                caiObject.CreateDate = DateTime.Now;
                caiObject.LastUpdateBy = Membership.GetUser().UserName; ;
                caiObject.LastUpdateDate = DateTime.Now;

                if (cisObj.InsertAddressInformation(caiObject))
                {
                    Response.Redirect("criminal-education-information.aspx?refno=" + txtRefNo.Text);
                }
            }
            catch (Exception ex)
            {
                ErrorMessage.Text = ex.Message;
            }
        }

        protected void btnSkip_Click(object sender, EventArgs e)
        {
            Response.Redirect("criminal-education-information.aspx?refno=" + txtRefNo.Text);
        }
    }
}