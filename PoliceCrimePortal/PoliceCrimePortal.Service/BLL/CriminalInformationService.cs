using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoliceCrimePortal.Data;
using PoliceCrimePortal.Data.DAO;
using PoliceCrimePortal.Data.DataGateways;
using System.Data.SqlClient;

namespace PoliceCrimePortal.Service.BLL
{

    public class CriminalInformationService
    {

        #region Basic Information
        /// <summary>
        /// Insert Criminal Basic Information using this fuction
        /// </summary>
        /// <returns></returns>
        public bool InsertBasicInformation(Criminal_Basic_InformationObject cbiObject)
        {
            clsBase baseObj = new clsBase();
            string sqlstring = "INSERT INTO [Criminal_Basic_Information] ([RefNo],[FullName],[NickName],[CriminalName],[Gender]" +
                               ",[BloodGroup],[DOB],[RegionOfBirth],[UsualDressUp],[MaritalStatus],[DialectAccent],[DrivingLicenseNo]" +
                               ",[NationalID],[PassportNo],[CreationDate],[CreateBy],[LastUpdate],[LastUpdateBy])VALUES (@RefNo," +
                               " @FullName,@NickName,@CriminalName,@Gender,@BloodGroup,@DOB,@RegionOfBirth,@UsualDressUp,@MaritalStatus," +
                               "@DialectAccent,@DrivingLicenseNo,@NationalID,@PassportNo, @CreationDate,@CreateBy,@LastUpdate,@LastUpdateBy)";


            List<SqlParameter> parametersList = new List<SqlParameter>();
            parametersList.Add(new SqlParameter("@RefNo", cbiObject.refNo));
            parametersList.Add(new SqlParameter("@FullName", cbiObject.fullName));
            parametersList.Add(new SqlParameter("@NickName", cbiObject.nickName));
            parametersList.Add(new SqlParameter("@CriminalName", cbiObject.criminalName));
            parametersList.Add(new SqlParameter("@Gender", cbiObject.gender));
            parametersList.Add(new SqlParameter("@BloodGroup", cbiObject.bloodGroup));
            parametersList.Add(new SqlParameter("@DOB", cbiObject.dob));
            parametersList.Add(new SqlParameter("@RegionOfBirth", cbiObject.regionofBirth));
            parametersList.Add(new SqlParameter("@UsualDressUp", cbiObject.usualDressUp));
            parametersList.Add(new SqlParameter("@MaritalStatus", cbiObject.maritalStatus));
            parametersList.Add(new SqlParameter("@DialectAccent", cbiObject.dialectAccent));
            parametersList.Add(new SqlParameter("@DrivingLicenseNo", cbiObject.drivingLicenseNo));
            parametersList.Add(new SqlParameter("@NationalID", cbiObject.nationalID));
            parametersList.Add(new SqlParameter("@PassportNo", cbiObject.passport));
            parametersList.Add(new SqlParameter("@CreationDate", cbiObject.createdate));
            parametersList.Add(new SqlParameter("@CreateBy", cbiObject.createby));
            parametersList.Add(new SqlParameter("@LastUpdate", cbiObject.updateDate));
            parametersList.Add(new SqlParameter("@LastUpdateBy", cbiObject.updateby));

            return baseObj.InsertData(sqlstring, parametersList);
        }

        #endregion

        #region Physical information

        /// <summary>
        /// Insert Criminal Physical Information using this fuction
        /// </summary>
        /// <returns></returns>
        public bool InsertPhysicalInformation(Criminal_Physical_InformationObject cpiObject)
        {
            clsBase baseObj = new clsBase();
            string sqlstring = "INSERT INTO [Criminal_Physical_Information] ([RefNo],[HeightInch],[WeightKg]" +
                               ",[EyeColor],[EyeImage],[lips],[IrregularitiesOnEye],[SkinColor],[Nose],[ShapeOfBody]" +
                               ",[ShapeOfHead],[Teeth],[HairColor],[TypeOfHair],[Tattoo],[Ear],[TypeOfFace],[ScarsAndHandicap]" +
                               ",[Forehead],[IdentificationMark],[CreateBy],[CreateDate],[LastUpdateBy],[LastUpdateDate],[Picture])" +
                               "VALUES (@RefNo,@HeightInch,@WeightKg,@EyeColor,@EyeImage,@lips,@IrregularitiesOnEye,@SkinColor,@Nose," +
                               "@ShapeOfBody,@ShapeOfHead,@Teeth,@HairColor,@TypeOfHair,@Tattoo,@Ear,@TypeOfFace,@ScarsAndHandicap," +
                               "@Forehead,@IdentificationMark,@CreateBy,@CreateDate,@LastUpdateBy,@LastUpdateDate,@Picture)";

            List<SqlParameter> parametersList = new List<SqlParameter>();
            parametersList.Add(new SqlParameter("@RefNo", cpiObject.RefNo));
            parametersList.Add(new SqlParameter("@HeightInch", cpiObject.HeightInch));
            parametersList.Add(new SqlParameter("@WeightKg", cpiObject.WeightKg));
            parametersList.Add(new SqlParameter("@EyeColor", cpiObject.EyeColor));
            parametersList.Add(new SqlParameter("@EyeImage", cpiObject.EyeImage));
            parametersList.Add(new SqlParameter("@Picture", cpiObject.Picture));
            parametersList.Add(new SqlParameter("@lips", cpiObject.lips));
            parametersList.Add(new SqlParameter("@IrregularitiesOnEye", cpiObject.IrregularitiesOnEye));
            parametersList.Add(new SqlParameter("@SkinColor", cpiObject.SkinColor));
            parametersList.Add(new SqlParameter("@Nose", cpiObject.Nose));
            parametersList.Add(new SqlParameter("@ShapeOfBody", cpiObject.ShapeOfBody));
            parametersList.Add(new SqlParameter("@ShapeOfHead", cpiObject.ShapeOfHead));
            parametersList.Add(new SqlParameter("@Teeth", cpiObject.Teeth));
            parametersList.Add(new SqlParameter("@HairColor", cpiObject.HairColor));
            parametersList.Add(new SqlParameter("@TypeOfHair", cpiObject.TypeOfHair));
            parametersList.Add(new SqlParameter("@Tattoo", cpiObject.Tattoo));
            parametersList.Add(new SqlParameter("@Ear", cpiObject.Ear));
            parametersList.Add(new SqlParameter("@TypeOfFace", cpiObject.TypeOfFace));
            parametersList.Add(new SqlParameter("@ScarsAndHandicap", cpiObject.ScarsAndHandicap));
            parametersList.Add(new SqlParameter("@Forehead", cpiObject.Forehead));
            parametersList.Add(new SqlParameter("@IdentificationMark", cpiObject.IdentificationMark));
            parametersList.Add(new SqlParameter("@CreateDate", cpiObject.CreateDate));
            parametersList.Add(new SqlParameter("@CreateBy", cpiObject.CreateBy));
            parametersList.Add(new SqlParameter("@LastUpdateDate", cpiObject.LastUpdateDate));
            parametersList.Add(new SqlParameter("@LastUpdateBy", cpiObject.LastUpdateBy));


            return baseObj.InsertData(sqlstring, parametersList);
        }

        #endregion

        #region Address information

        /// <summary>
        /// Insert Criminal Address Information using this fuction
        /// </summary>
        /// <returns></returns>
        public bool InsertAddressInformation(Criminal_Address_InformationObject caiObject)
        {
            string PreAddressID = Utility.GetNewID("Pre-");
            string PerAddressID = Utility.GetNewID("Per-");
            bool returnStatus = false;

            clsBase baseObj = new clsBase();
            string sqlPreAddresstring = "INSERT INTO [AddressTable] ([ID],[District],[Upozila],[UnionWard],[Village]" +
                                        ",[CreateBy],[CreateDate],[LastUpdateBy],[LastUpdateDate]) VALUES " +
                                        "(@ID,@District,@Upozila,@UnionWard,@Village,@CreateBy,@CreateDate,@LastUpdateBy,@LastUpdateDate)";


            List<SqlParameter> parametersPermanentAddressList = new List<SqlParameter>();
            parametersPermanentAddressList.Add(new SqlParameter("@ID", PerAddressID));
            parametersPermanentAddressList.Add(new SqlParameter("@District", caiObject.PermanentAddress.District));
            parametersPermanentAddressList.Add(new SqlParameter("@Upozila", caiObject.PermanentAddress.Upozila));
            parametersPermanentAddressList.Add(new SqlParameter("@UnionWard", caiObject.PermanentAddress.UnionWard));
            parametersPermanentAddressList.Add(new SqlParameter("@Village", caiObject.PermanentAddress.Village));
            parametersPermanentAddressList.Add(new SqlParameter("@CreateBy", caiObject.PermanentAddress.CreateBy));
            parametersPermanentAddressList.Add(new SqlParameter("@CreateDate", caiObject.PermanentAddress.CreateDate));
            parametersPermanentAddressList.Add(new SqlParameter("@LastUpdateBy", caiObject.PermanentAddress.LastUpdateBy));
            parametersPermanentAddressList.Add(new SqlParameter("@LastUpdateDate", caiObject.PermanentAddress.LastUpdateDate));

            if (baseObj.InsertData(sqlPreAddresstring, parametersPermanentAddressList))
            {

                string sqlPerAddresstring = "INSERT INTO [AddressTable] ([ID],[District],[Upozila],[UnionWard],[Village]" +
                                                        ",[CreateBy],[CreateDate],[LastUpdateBy],[LastUpdateDate]) VALUES " +
                                                        "(@ID,@District,@Upozila,@UnionWard,@Village,@CreateBy,@CreateDate,@LastUpdateBy,@LastUpdateDate)";


                List<SqlParameter> parametersPresentAddressList = new List<SqlParameter>();
                parametersPresentAddressList.Add(new SqlParameter("@ID", PreAddressID));
                parametersPresentAddressList.Add(new SqlParameter("@District", caiObject.PresentAddress.District));
                parametersPresentAddressList.Add(new SqlParameter("@Upozila", caiObject.PresentAddress.Upozila));
                parametersPresentAddressList.Add(new SqlParameter("@UnionWard", caiObject.PresentAddress.UnionWard));
                parametersPresentAddressList.Add(new SqlParameter("@Village", caiObject.PresentAddress.Village));
                parametersPresentAddressList.Add(new SqlParameter("@CreateBy", caiObject.PresentAddress.CreateBy));
                parametersPresentAddressList.Add(new SqlParameter("@CreateDate", caiObject.PresentAddress.CreateDate));
                parametersPresentAddressList.Add(new SqlParameter("@LastUpdateBy", caiObject.PresentAddress.LastUpdateBy));
                parametersPresentAddressList.Add(new SqlParameter("@LastUpdateDate", caiObject.PresentAddress.LastUpdateDate));

                if (baseObj.InsertData(sqlPreAddresstring, parametersPresentAddressList))
                {
                    string sqlstring = "INSERT INTO [Criminal_Address_Information] ([RefNo],[PermanentAddressID],[PresentAddressID]" +
                                       ",[LastAddressRegion],[DurationofStay],[Remarks],[WorkingArea],[PhoneNo],[MobileNo],[email]" +
                                       ",[CreateBy],[CreateDate],[LastUpdateBy],[LastUpdateDate]) VALUES (@RefNo,@PermanentAddressID," +
                                       "@PresentAddressID,@LastAddressRegion,@DurationofStay,@Remarks,@WorkingArea,@PhoneNo,@MobileNo," +
                                       "@email,@CreateBy,@CreateDate,@LastUpdateBy,@LastUpdateDate)";

                    List<SqlParameter> parametersList = new List<SqlParameter>();
                    parametersList.Add(new SqlParameter("@RefNo", caiObject.RefNo));
                    parametersList.Add(new SqlParameter("@PermanentAddressID", PerAddressID));
                    parametersList.Add(new SqlParameter("@PresentAddressID", PreAddressID));
                    parametersList.Add(new SqlParameter("@LastAddressRegion", caiObject.LastAddressRegion));
                    parametersList.Add(new SqlParameter("@DurationofStay", caiObject.DurationofStay));
                    parametersList.Add(new SqlParameter("@Remarks", caiObject.Remarks));
                    parametersList.Add(new SqlParameter("@WorkingArea", caiObject.WorkingArea));
                    parametersList.Add(new SqlParameter("@PhoneNo", caiObject.PhoneNo));
                    parametersList.Add(new SqlParameter("@MobileNo", caiObject.MobileNo));
                    parametersList.Add(new SqlParameter("@email", caiObject.email));
                    parametersList.Add(new SqlParameter("@CreateBy", caiObject.CreateBy));
                    parametersList.Add(new SqlParameter("@CreateDate", caiObject.CreateDate));
                    parametersList.Add(new SqlParameter("@LastUpdateBy", caiObject.LastUpdateBy));
                    parametersList.Add(new SqlParameter("@LastUpdateDate", caiObject.LastUpdateDate));

                    if (baseObj.InsertData(sqlstring, parametersList))
                    {
                        returnStatus = true;
                    }
                }
            }


            return returnStatus;
        }

        #endregion

        #region Education Information

        /// <summary>
        /// Insert Criminal Education Information using this fuction
        /// </summary>
        /// <returns></returns>
        public bool InsertEducationInformation(Criminal_Education_InformationObject ceiObject)
        {
            clsBase baseObj = new clsBase();
            string sqlstring = "INSERT INTO [Criminal_Education_Information] ([RefNo],[EducationalStatus]" +
                               ",[NameofInstitution],[PoliticalInvolvementinInstitution],[CreateBy],[CreateDate]" +
                               ",[LastUpdateDate],[LastUpdateBy]) VALUES (@RefNo,@EducationalStatus,@NameofInstitution," +
                               "@PoliticalInvolvementinInstitution,@CreateBy,@CreateDate,@LastUpdateDate, @LastUpdateBy)";

            List<SqlParameter> parametersList = new List<SqlParameter>();
            parametersList.Add(new SqlParameter("@RefNo", ceiObject.RefNo));
            parametersList.Add(new SqlParameter("@EducationalStatus", ceiObject.EducationalStatus));
            parametersList.Add(new SqlParameter("@NameofInstitution", ceiObject.NameofInstitution));
            parametersList.Add(new SqlParameter("@PoliticalInvolvementinInstitution", ceiObject.PoliticalInvolvementinInstitution));
            parametersList.Add(new SqlParameter("@CreateBy", ceiObject.CreateBy));
            parametersList.Add(new SqlParameter("@CreateDate", ceiObject.CreateDate));
            parametersList.Add(new SqlParameter("@LastUpdateDate", ceiObject.LastUpdateDate));
            parametersList.Add(new SqlParameter("@LastUpdateBy", ceiObject.LastUpdateBy));

            return baseObj.InsertData(sqlstring, parametersList);
        }
        #endregion


        #region Death information

        /// <summary>
        /// Insert Criminal Death Information using this fuction
        /// </summary>
        /// <returns></returns>
        public bool InsertDeathInformation(Criminal_Death_InformationObject cdiObject)
        {
            string AddressID = Utility.GetNewID("dat-");
            bool returnStatus = false;

            clsBase baseObj = new clsBase();
            string sqlPreAddresstring = "INSERT INTO [AddressTable] ([ID],[District],[Upozila],[UnionWard],[Village]" +
                                        ",[CreateBy],[CreateDate],[LastUpdateBy],[LastUpdateDate]) VALUES " +
                                        "(@ID,@District,@Upozila,@UnionWard,@Village,@CreateBy,@CreateDate,@LastUpdateBy,@LastUpdateDate)";


            List<SqlParameter> parametersPermanentAddressList = new List<SqlParameter>();
            parametersPermanentAddressList.Add(new SqlParameter("@ID", AddressID));
            parametersPermanentAddressList.Add(new SqlParameter("@District", cdiObject.Address.District));
            parametersPermanentAddressList.Add(new SqlParameter("@Upozila", cdiObject.Address.Upozila));
            parametersPermanentAddressList.Add(new SqlParameter("@UnionWard", cdiObject.Address.UnionWard));
            parametersPermanentAddressList.Add(new SqlParameter("@Village", cdiObject.Address.Village));
            parametersPermanentAddressList.Add(new SqlParameter("@CreateBy", cdiObject.Address.CreateBy));
            parametersPermanentAddressList.Add(new SqlParameter("@CreateDate", cdiObject.Address.CreateDate));
            parametersPermanentAddressList.Add(new SqlParameter("@LastUpdateBy", cdiObject.Address.LastUpdateBy));
            parametersPermanentAddressList.Add(new SqlParameter("@LastUpdateDate", cdiObject.Address.LastUpdateDate));


            if (baseObj.InsertData(sqlPreAddresstring, parametersPermanentAddressList))
            {
                string sqlstring = "INSERT INTO [Criminal_Death_Information] ([RefNo],[DeathTime]" +
                                   ",[DeathDate],[Reason],[CreateBy],[CreateDate],[LastUpdateDate],[LastUpdateBy]" +
                                   ",[AddressID]) VALUES (@RefNo,@DeathTime,@DeathDate,@Reason,@CreateBy,@CreateDate," +
                                   "@LastUpdateDate,@LastUpdateBy, @AddressID)";

                List<SqlParameter> parametersList = new List<SqlParameter>();
                parametersList.Add(new SqlParameter("@RefNo", cdiObject.RefNo));
                parametersList.Add(new SqlParameter("@DeathTime", cdiObject.DeathTime));
                parametersList.Add(new SqlParameter("@DeathDate", cdiObject.DeathDate));
                parametersList.Add(new SqlParameter("@Reason", cdiObject.Reason));
                parametersList.Add(new SqlParameter("@CreateBy", cdiObject.CreateBy));
                parametersList.Add(new SqlParameter("@CreateDate", cdiObject.CreateDate));
                parametersList.Add(new SqlParameter("@LastUpdateBy", cdiObject.LastUpdateBy));
                parametersList.Add(new SqlParameter("@LastUpdateDate", cdiObject.LastUpdateDate));
                parametersList.Add(new SqlParameter("@AddressID", AddressID));

                if (baseObj.InsertData(sqlstring, parametersList))
                {
                    returnStatus = true;
                }
            }


            return returnStatus;
        }

        #endregion

        #region Travel information

        /// <summary>
        /// Insert Criminal Travel Information using this fuction
        /// </summary>
        /// <returns></returns>
        public bool InsertTravelInformation(Criminal_Travel_InformationObject ctiObject)
        {
            clsBase baseObj = new clsBase();

            string sqlstring = "INSERT INTO [Criminal_Travel_Information] ([RefNo],[CountryVisited],[ArrivalDate]" +
                               ",[DepartureDate],[Duration],[AddressAbroad],[CreateBy],[CreateDate],[LastUpdateDate],[LastUpdateBy])" +
                               "VALUES (@RefNo,@CountryVisited,@ArrivalDate,@DepartureDate,@Duration,@AddressAbroad,@CreateBy," +
                               "@CreateDate,@LastUpdateDate,@LastUpdateBy)";

            List<SqlParameter> parametersList = new List<SqlParameter>();
            parametersList.Add(new SqlParameter("@RefNo", ctiObject.RefNo));
            parametersList.Add(new SqlParameter("@CountryVisited", ctiObject.CountryVisited));
            parametersList.Add(new SqlParameter("@ArrivalDate", ctiObject.ArrivalDate));
            parametersList.Add(new SqlParameter("@DepartureDate", ctiObject.DepartureDate));
            parametersList.Add(new SqlParameter("@Duration", ctiObject.Duration));
            parametersList.Add(new SqlParameter("@AddressAbroad", ctiObject.AddressAbroad));
            parametersList.Add(new SqlParameter("@CreateBy", ctiObject.CreateBy));
            parametersList.Add(new SqlParameter("@CreateDate", ctiObject.CreateDate));
            parametersList.Add(new SqlParameter("@LastUpdateBy", ctiObject.LastUpdateBy));
            parametersList.Add(new SqlParameter("@LastUpdateDate", ctiObject.LastUpdateDate));


            return baseObj.InsertData(sqlstring, parametersList);
        }

        #endregion

        #region Travel information

        /// <summary>
        /// Insert Criminal Travel Information using this fuction
        /// </summary>
        /// <returns></returns>
        public bool InsertTravelInformation(Criminal_Bank_Account_DetailsObject cbadObject)
        {
            clsBase baseObj = new clsBase();

            string sqlstring = "INSERT INTO [Criminal_Bank_Account_Information] ([RefNo],[BankName]" +
                               ",[AccountNo],[AccountType],[CreditCardNo],[DebitCardNo],[CreateBy],[CreateDate]" +
                               ",[LastUpdateBy],[LastUpdateDate]) VALUES (@RefNo,@BankName,@AccountNo,@AccountType," +
                               "@CreditCardNo,@DebitCardNo,@CreateBy,@CreateDate,@LastUpdateBy,@LastUpdateDate)";

            List<SqlParameter> parametersList = new List<SqlParameter>();
            parametersList.Add(new SqlParameter("@RefNo", cbadObject.RefNo));
            parametersList.Add(new SqlParameter("@BankName", cbadObject.BankName));
            parametersList.Add(new SqlParameter("@AccountNo", cbadObject.AccountNo));
            parametersList.Add(new SqlParameter("@AccountType", cbadObject.AccountType));
            parametersList.Add(new SqlParameter("@CreditCardNo", cbadObject.CreditCardNo));
            parametersList.Add(new SqlParameter("@DebitCardNo", cbadObject.DebitCardNo));
            parametersList.Add(new SqlParameter("@CreateBy", cbadObject.CreateBy));
            parametersList.Add(new SqlParameter("@CreateDate", cbadObject.CreateDate));
            parametersList.Add(new SqlParameter("@LastUpdateBy", cbadObject.LastUpdateBy));
            parametersList.Add(new SqlParameter("@LastUpdateDate", cbadObject.LastUpdateDate));


            return baseObj.InsertData(sqlstring, parametersList);
        }

        #endregion

        #region Mobile Tracking information

        /// <summary>
        /// Insert Criminal Mobile Tracking Information using this fuction
        /// </summary>
        /// <returns></returns>
        public bool InsertMobileTrackingInformation(Criminal_Mobile_Track_InformationObject cbadObject)
        {
            clsBase baseObj = new clsBase();

            string sqlstring = "INSERT INTO [Criminal_Mobile_Track_Information] ([phoneNo] ,[IMENo],[Latitude]" +
                               ",[Longitude]) VALUES (@phoneNo,@IMENo,@Latitude, @Longitude)";

            List<SqlParameter> parametersList = new List<SqlParameter>();
            parametersList.Add(new SqlParameter("@phoneNo", cbadObject.phoneNo));
            parametersList.Add(new SqlParameter("@IMENo", cbadObject.IMENo));
            parametersList.Add(new SqlParameter("@Latitude", cbadObject.Latitude));
            parametersList.Add(new SqlParameter("@Longitude", cbadObject.Longitude));

            return baseObj.InsertData(sqlstring, parametersList);
        }

        #endregion
    }

}


