using PoliceCrimePortal.Data.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PoliceCrimePortal.Service;
using PoliceCrimePortal.Service.BLL;
using System.Web.Security;
namespace PoliceCrimePortal.Activities.DataEntry
{
    public partial class Criminal_Basic_Information : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (User.Identity.IsAuthenticated == true)
            {
                if (!IsPostBack)
                {
                    txtRefNo.Text = Utility.GetNewID("");
                }
            }
            else
            {
                Response.Redirect("~/Account/Login");
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Criminal_Basic_InformationObject cbiObject = new Criminal_Basic_InformationObject();
            CriminalInformationService cisObj = new CriminalInformationService();

            try
            {
                cbiObject.refNo = txtRefNo.Text;
                cbiObject.fullName = txtFullName.Text;
                cbiObject.nickName = txtNickName.Text;
                cbiObject.criminalName = txtCriminalName.Text;
                cbiObject.gender = ddlGender.SelectedValue;
                cbiObject.bloodGroup = ddlBloodGroup.SelectedValue;
                cbiObject.dob = Convert.ToDateTime(txtDOB.Text);
                cbiObject.regionofBirth = txtRegionofBirth.Text;
                cbiObject.usualDressUp = txtUsualDressUp.Text;
                cbiObject.maritalStatus = txtMaritalStatus.Text;
                cbiObject.dialectAccent = txtDialectAccent.Text;
                cbiObject.drivingLicenseNo = txtDrivingLicenseNo.Text;
                cbiObject.nationalID = txtNationalID.Text;
                cbiObject.passport = txtPassportNo.Text;
                cbiObject.createdate = DateTime.Now;
                cbiObject.createby = Membership.GetUser().UserName; ;
                cbiObject.updateDate = DateTime.Now;
                cbiObject.updateby = Membership.GetUser().UserName; ;

                if (cisObj.InsertBasicInformation(cbiObject))
                {
                    Response.Redirect("criminal-physical-information.aspx?refno=" + cbiObject.refNo);
                }
            }
            catch (Exception ex)
            {
                ErrorMessage.Text = ex.Message;
            }
        }
    }
}