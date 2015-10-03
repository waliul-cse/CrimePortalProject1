using PoliceCrimePortal.Service.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PoliceCrimePortal.Activities.Reports
{
    public partial class crime_hot_zone : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static string GetData(string crimeType, string fromDate, string todate)
        {
            CrimeInformationService cisObj = new CrimeInformationService();

            try
            {
                DataTable dt = cisObj.SelectCrimeZoneInformation(crimeType, Convert.ToDateTime(fromDate), Convert.ToDateTime(todate));
                return ConvertDataTabletoString(dt);
            }
            catch (Exception ex)
            {

            }
            return crimeType;
        }

        public static string ConvertDataTabletoString(DataTable dt)
        {
            try
            {
                if (dt != null)
                {
                    System.Web.Script.Serialization.JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                    List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
                    Dictionary<string, object> row;
                    foreach (DataRow dr in dt.Rows)
                    {
                        row = new Dictionary<string, object>();
                        foreach (DataColumn col in dt.Columns)
                        {
                            row.Add(col.ColumnName, dr[col]);
                        }
                        rows.Add(row);
                    }
                    return serializer.Serialize(rows);
                }
                else
                {
                    return "Null";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}