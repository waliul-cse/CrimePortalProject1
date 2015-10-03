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
    public partial class criminal_dead_information : System.Web.UI.Page
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
            Criminal_Death_InformationObject caiObject = new Criminal_Death_InformationObject();
            CriminalInformationService cisObj = new CriminalInformationService();

            try
            {
                caiObject.Address.District = txtDistrict.Text;
                caiObject.Address.Upozila = txtUplozila.Text;
                caiObject.Address.UnionWard = txtUnion.Text;
                caiObject.Address.Village = txtVillage.Text;
                caiObject.Address.CreateBy = Membership.GetUser().UserName; ;
                caiObject.Address.CreateDate = DateTime.Now;
                caiObject.Address.LastUpdateBy = Membership.GetUser().UserName; ;
                caiObject.Address.LastUpdateDate = DateTime.Now;

                caiObject.RefNo = txtRefNo.Text;
                caiObject.Reason = txtReason.Text;
                caiObject.DeathDate = txtDate.Text;
                caiObject.DeathTime = txtDeathTime.Text;
                caiObject.CreateBy = Membership.GetUser().UserName;
                caiObject.CreateDate = DateTime.Now;
                caiObject.LastUpdateBy = Membership.GetUser().UserName;
                caiObject.LastUpdateDate = DateTime.Now;
                if (cisObj.InsertDeathInformation(caiObject))
                {
                    Response.Redirect("criminal-travel-information.aspx?refno=" + txtRefNo.Text);
                }
            }
            catch (Exception ex)
            {
                ErrorMessage.Text = ex.Message;
            }
        }

        protected void btnSkip_Click(object sender, EventArgs e)
        {
            Response.Redirect("criminal-travel-information.aspx?refno=" + txtRefNo.Text);
        }
    }
}