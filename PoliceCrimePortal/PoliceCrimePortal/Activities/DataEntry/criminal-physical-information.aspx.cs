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
    public partial class criminal_physical_information : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string referenceno = Request.QueryString["refno"].ToString();
                if (!String.IsNullOrEmpty(referenceno))
                {
                    txtRefNo.Text = referenceno;
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Criminal_Physical_InformationObject cpiObject = new Criminal_Physical_InformationObject();
            CriminalInformationService cisObj = new CriminalInformationService();

            try
            {

                cpiObject.RefNo = txtRefNo.Text;
                cpiObject.HeightInch = txtheight.Text;
                cpiObject.WeightKg = txtWeight.Text;
                cpiObject.EyeColor = txtEyeColor.Text;
                cpiObject.EyeImage = fuEyeIamge.FileBytes;
                cpiObject.lips = txtLips.Text;
                cpiObject.IrregularitiesOnEye = txtIrregularitiesOnEye.Text;
                cpiObject.SkinColor = txtSkinColor.Text;
                cpiObject.Nose = txtNose.Text;
                cpiObject.ShapeOfBody = txtShapeOfBody.Text;
                cpiObject.ShapeOfHead = txtShapeOfHead.Text;
                cpiObject.Teeth = txtTeeth.Text;
                cpiObject.HairColor = txtHairColor.Text;
                cpiObject.TypeOfHair = txtTypeOfHair.Text;
                cpiObject.Tattoo = txtTattoo.Text;
                cpiObject.Ear = txtEar.Text;
                cpiObject.TypeOfFace = txtTypeOfFace.Text;
                cpiObject.ScarsAndHandicap = txtScarsAndHandicap.Text;
                cpiObject.Forehead = txtForehead.Text;
                cpiObject.IdentificationMark = txtIdentificationMark.Text;
                cpiObject.Picture = fuPicture.FileBytes;
                cpiObject.CreateDate = DateTime.Now;
                cpiObject.CreateBy = Membership.GetUser().UserName; ;
                cpiObject.LastUpdateDate = DateTime.Now;
                cpiObject.LastUpdateBy = Membership.GetUser().UserName; ;


                if (cisObj.InsertPhysicalInformation(cpiObject))
                {
                    Response.Redirect("criminal-address-information.aspx?refno=" + cpiObject.RefNo);
                }
            }
            catch (Exception ex)
            {
                ErrorMessage.Text = ex.Message;
            }
        }
    }
}