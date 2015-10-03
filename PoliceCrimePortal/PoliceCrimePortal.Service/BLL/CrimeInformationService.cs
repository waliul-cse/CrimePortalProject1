using PoliceCrimePortal.Data.DAO;
using PoliceCrimePortal.Data.DataGateways;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceCrimePortal.Service.BLL
{

    public class CrimeInformationService
    {
        #region Crime Basic information

        /// <summary>
        /// Insert Crime Basic Information using this fuction
        /// </summary>
        /// <returns></returns>
        public bool InsertCrimeBasicInformation(Crime_Basic_InformationObject cbiObject)
        {
            clsBase baseObj = new clsBase();

            string sqlstring = "INSERT INTO [Crime_Basic_Information] ([CreminalRef],[CriminalStatus],[GangName]" +
                               ",[CrimeType],[IllegalArmsPossession],[Remarks],[LegalArmsPossession],[PriorityListGovt]" +
                               ",[CaseDetails],[LastState],[CreateBy],[CreateDate],[LastUpdateBy],[LastUpdateDate]) VALUES" +
                               "(@CreminalRef,@CriminalStatus,@GangName,@CrimeType,@IllegalArmsPossession,@Remarks," +
                               "@LegalArmsPossession,@PriorityListGovt,@CaseDetails,@LastState,@CreateBy,@CreateDate,@LastUpdateBy,@LastUpdateDate)";

            List<SqlParameter> parametersList = new List<SqlParameter>();
            parametersList.Add(new SqlParameter("@CreminalRef", cbiObject.CreminalRef));
            parametersList.Add(new SqlParameter("@CriminalStatus", cbiObject.CriminalStatus));
            parametersList.Add(new SqlParameter("@GangName", cbiObject.GangName));
            parametersList.Add(new SqlParameter("@CrimeType", cbiObject.CrimeType));
            parametersList.Add(new SqlParameter("@IllegalArmsPossession", cbiObject.IllegalArmsPossession));
            parametersList.Add(new SqlParameter("@Remarks", cbiObject.Remarks));
            parametersList.Add(new SqlParameter("@LegalArmsPossession", cbiObject.LegalArmsPossession));
            parametersList.Add(new SqlParameter("@PriorityListGovt", cbiObject.PriorityListGovt));
            parametersList.Add(new SqlParameter("@CaseDetails", cbiObject.CaseDetails));
            parametersList.Add(new SqlParameter("@LastState", cbiObject.LastState));
            parametersList.Add(new SqlParameter("@CreateBy", cbiObject.CreateBy));
            parametersList.Add(new SqlParameter("@CreateDate", cbiObject.CreateDate));
            parametersList.Add(new SqlParameter("@LastUpdateBy", cbiObject.LastUpdateBy));
            parametersList.Add(new SqlParameter("@LastUpdateDate", cbiObject.LastUpdateDate));


            return baseObj.InsertData(sqlstring, parametersList);
        }

        #endregion


        #region Crime Hstory information

        /// <summary>
        /// Insert Crime History Information using this fuction
        /// </summary>
        /// <returns></returns>
        public bool InsertCrimeHistory(Crime_HistoryObject chObject)
        {
            clsBase baseObj = new clsBase();

            string sqlstring = "INSERT INTO [Crime_History] ([RefNo],[CrimeType],[Description],[CrimeCode],[CrimeDate]" +
                               ",[CreateBy],[CreateDate],[LastUpdateBy],[LastUpdateDate]) VALUES (@RefNo," +
                               "@CrimeType,@Description,@CrimeCode,@CrimeDate,@CreateBy,@CreateDate," +
                               "@LastUpdateBy,@LastUpdateDate)";

            List<SqlParameter> parametersList = new List<SqlParameter>();
            parametersList.Add(new SqlParameter("@RefNo", chObject.RefNo));
            parametersList.Add(new SqlParameter("@CrimeType", chObject.CrimeType));
            parametersList.Add(new SqlParameter("@Description", chObject.Description));
            parametersList.Add(new SqlParameter("@CrimeCode", chObject.CrimeCode));
            parametersList.Add(new SqlParameter("@CrimeDate", chObject.CrimeDate));
            parametersList.Add(new SqlParameter("@CreateBy", chObject.CreateBy));
            parametersList.Add(new SqlParameter("@CreateDate", chObject.CreateDate));
            parametersList.Add(new SqlParameter("@LastUpdateBy", chObject.LastUpdateBy));
            parametersList.Add(new SqlParameter("@LastUpdateDate", chObject.LastUpdateDate));


            return baseObj.InsertData(sqlstring, parametersList);
        }

        #endregion

        #region Crime case details information

        /// <summary>
        /// Insert Crime Case Details using this fuction
        /// </summary>
        /// <returns></returns>
        public bool InsertCrimeCaseDetails(Crime_Case_DetailsObject ccdObject)
        {
            clsBase baseObj = new clsBase();

            string sqlstring = "INSERT INTO [Crime_Case_Details] ([RefNo],[CaseNo],[District],[Thana]" +
                               ",[Date],[CreateBy],[CreateDate],[LastUpdateBy],[LastUpdateDate]) VALUES" +
                               " (@RefNo,@CaseNo,@District,@Thana,@Date,@CreateBy,@CreateDate,@LastUpdateBy,@LastUpdateDate)";

            List<SqlParameter> parametersList = new List<SqlParameter>();
            parametersList.Add(new SqlParameter("@RefNo", ccdObject.RefNo));
            parametersList.Add(new SqlParameter("@CaseNo", ccdObject.CaseNo));
            parametersList.Add(new SqlParameter("@District", ccdObject.District));
            parametersList.Add(new SqlParameter("@Thana", ccdObject.Thana));
            parametersList.Add(new SqlParameter("@Date", ccdObject.Date));
            parametersList.Add(new SqlParameter("@CreateBy", ccdObject.CreateBy));
            parametersList.Add(new SqlParameter("@CreateDate", ccdObject.CreateDate));
            parametersList.Add(new SqlParameter("@LastUpdateBy", ccdObject.LastUpdateBy));
            parametersList.Add(new SqlParameter("@LastUpdateDate", ccdObject.LastUpdateDate));


            return baseObj.InsertData(sqlstring, parametersList);
        }

        #endregion

        #region Crime zone information

        /// <summary>
        /// Insert Crime zone using this fuction
        /// </summary>
        /// <returns></returns>
        public bool InsertCrimeZone(Crime_ZoneObject czObject)
        {
            clsBase baseObj = new clsBase();

            string sqlstring = "INSERT INTO [Crime_Zone] ([RefNo],[Battalion],[District],[PoliceStation]" +
                               ",[Village],[Latitude],[Longitude],[Remarks],[CreateBy],[CreateDate],[LastUpdateBy],[LastUpdateDate])" +
                               " VALUES (@RefNo,@Battalion,@District,@PoliceStation,@Village,@Latitude,@Longitude,@Remarks,@CreateBy,@CreateDate,@LastUpdateBy,@LastUpdateDate)";

            List<SqlParameter> parametersList = new List<SqlParameter>();
            parametersList.Add(new SqlParameter("@RefNo", czObject.RefNo));
            parametersList.Add(new SqlParameter("@Battalion", czObject.Battalion));
            parametersList.Add(new SqlParameter("@District", czObject.District));
            parametersList.Add(new SqlParameter("@PoliceStation", czObject.PoliceStation));
            parametersList.Add(new SqlParameter("@Village", czObject.Village));
            parametersList.Add(new SqlParameter("@Latitude", czObject.Latitude));
            parametersList.Add(new SqlParameter("@Longitude", czObject.Longitude));
            parametersList.Add(new SqlParameter("@Remarks", czObject.Remarks));
            parametersList.Add(new SqlParameter("@CreateBy", czObject.CreateBy));
            parametersList.Add(new SqlParameter("@CreateDate", czObject.CreateDate));
            parametersList.Add(new SqlParameter("@LastUpdateBy", czObject.LastUpdateBy));
            parametersList.Add(new SqlParameter("@LastUpdateDate", czObject.LastUpdateDate));


            return baseObj.InsertData(sqlstring, parametersList);
        }

        /// <summary>
        /// Select Crime zone using this fuction
        /// </summary>
        /// <returns></returns>
        public DataTable SelectCrimeZoneInformation(string crimetype, DateTime fromDate, DateTime todate)
        {
            clsBase baseObj = new clsBase();
            string sqlWhere = "";
            string sqlstring = "SELECT Crime_Zone.Latitude lat, Crime_Zone.Longitude long, Crime_History.CrimeType crimetype, Crime_History.CrimeDate cdate, " +
                               " Crime_History.Crimetime ctime, Crime_History.Description description FROM Crime_History INNER JOIN Crime_Zone on Crime_History.RefNo = Crime_Zone.RefNo";

            if (crimetype != "All")
            {
                sqlWhere = " where CrimeType= '" + crimetype +"'";
            }

            if (sqlWhere != "")
            {
                sqlWhere += " and Crime_History.CrimeDate between '" + fromDate + "' and '" + todate + "'";
            }
            else if (fromDate != null)
            {
                sqlWhere += " where Crime_History.CrimeDate between '" + fromDate + "' and '" + todate + "'";
            }

            sqlstring += sqlWhere;

            return baseObj.SelectData(sqlstring);
        }

        #endregion

        #region Crime remand information

        /// <summary>
        /// Insert Crime remand information using this fuction
        /// </summary>
        /// <returns></returns>
        public bool InsertCrimeRemandInformation(Crime_Remand_InformationObject criObject)
        {
            clsBase baseObj = new clsBase();

            string sqlstring = "INSERT INTO [Crime_Remand_Information] ([RefNo],[RemandNo],[DateofRemand]" +
                               ",[Duration],[ReasonofRemand],[CreateBy],[CreateDate],[LastUpdateBy],[LastUpdateDate])" +
                               " VALUES (@RefNo,@RemandNo,@DateofRemand,@Duration,@ReasonofRemand,@CreateBy,@CreateDate,@LastUpdateBy,@LastUpdateDate)";

            List<SqlParameter> parametersList = new List<SqlParameter>();
            parametersList.Add(new SqlParameter("@RefNo", criObject.RefNo));
            parametersList.Add(new SqlParameter("@RemandNo", criObject.RemandNo));
            parametersList.Add(new SqlParameter("@DateofRemand", criObject.DateofRemand));
            parametersList.Add(new SqlParameter("@Duration", criObject.Duration));
            parametersList.Add(new SqlParameter("@ReasonofRemand", criObject.ReasonofRemand));
            parametersList.Add(new SqlParameter("@CreateBy", criObject.CreateBy));
            parametersList.Add(new SqlParameter("@CreateDate", criObject.CreateDate));
            parametersList.Add(new SqlParameter("@LastUpdateBy", criObject.LastUpdateBy));
            parametersList.Add(new SqlParameter("@LastUpdateDate", criObject.LastUpdateDate));


            return baseObj.InsertData(sqlstring, parametersList);
        }

        #endregion

        #region Crime arrest information

        /// <summary>
        /// Insert Crime arrest information using this fuction
        /// </summary>
        /// <returns></returns>
        public bool InsertCrimeArrestInformation(Crime_Arrest_InformationObject caiObject)
        {
            clsBase baseObj = new clsBase();

            string sqlstring = "INSERT INTO [Crime_Arrest_Information] ([RefNo],[District],[Upozila],[DateofArrest],[ArrestBy]" +
                               ",[Disposal],[CreateBy],[CreateDate],[LastUpdateBy],[LastUpdateDate]) VALUES (@RefNo,@District," +
                               "@Upozila,@DateofArrest,@ArrestBy,@Disposal,@CreateBy,@CreateDate,@LastUpdateBy,@LastUpdateDate)";

            List<SqlParameter> parametersList = new List<SqlParameter>();
            parametersList.Add(new SqlParameter("@RefNo", caiObject.RefNo));
            parametersList.Add(new SqlParameter("@District", caiObject.District));
            parametersList.Add(new SqlParameter("@Upozila", caiObject.Upozila));
            parametersList.Add(new SqlParameter("@DateofArrest", caiObject.DateofArrest));
            parametersList.Add(new SqlParameter("@ArrestBy", caiObject.ArrestBy));
            parametersList.Add(new SqlParameter("@Disposal", caiObject.Disposal));
            parametersList.Add(new SqlParameter("@CreateBy", caiObject.CreateBy));
            parametersList.Add(new SqlParameter("@CreateDate", caiObject.CreateDate));
            parametersList.Add(new SqlParameter("@LastUpdateBy", caiObject.LastUpdateBy));
            parametersList.Add(new SqlParameter("@LastUpdateDate", caiObject.LastUpdateDate));


            return baseObj.InsertData(sqlstring, parametersList);
        }

        #endregion

        #region Crime activities information

        /// <summary>
        /// Insert Crime activities information using this fuction
        /// </summary>
        /// <returns></returns>
        public bool InsertCrimeActivitiesInformation(Crime_Criminal_ActivitiesObject ccaiObject)
        {
            clsBase baseObj = new clsBase();

            string sqlstring = "INSERT INTO [Crime_Creminal_Activities] ([RefNo] ,[previousAcitivity],[CurrentActivity]" +
                               ",[CreateBy],[CreateDate],[LastUpdateBy],[LastUpdateDate]) VALUES (@RefNo,@previousAcitivity," +
                               "@CurrentActivity,@CreateBy,@CreateDate,@LastUpdateBy,@LastUpdateDate)";

            List<SqlParameter> parametersList = new List<SqlParameter>();
            parametersList.Add(new SqlParameter("@RefNo", ccaiObject.RefNo));
            parametersList.Add(new SqlParameter("@previousAcitivity", ccaiObject.previousAcitivity));
            parametersList.Add(new SqlParameter("@CurrentActivity", ccaiObject.CurrentActivity));
            parametersList.Add(new SqlParameter("@CreateBy", ccaiObject.CreateBy));
            parametersList.Add(new SqlParameter("@CreateDate", ccaiObject.CreateDate));
            parametersList.Add(new SqlParameter("@LastUpdateBy", ccaiObject.LastUpdateBy));
            parametersList.Add(new SqlParameter("@LastUpdateDate", ccaiObject.LastUpdateDate));


            return baseObj.InsertData(sqlstring, parametersList);
        }

        #endregion
    }
}
