using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceCrimePortal.Data.DAO
{
    public class Criminal_Physical_InformationObject
    {
        public string RefNo { get; set; }
        public string HeightInch { get; set; }
        public string WeightKg { get; set; }
        public string EyeColor { get; set; }
        public byte[] EyeImage { get; set; }
        public byte[] Picture { get; set; }
        public string lips { get; set; }
        public string IrregularitiesOnEye { get; set; }
        public string SkinColor { get; set; }
        public string Nose { get; set; }
        public string ShapeOfBody { get; set; }
        public string ShapeOfHead { get; set; }
        public string Teeth { get; set; }
        public string HairColor { get; set; }
        public string TypeOfHair { get; set; }
        public string Tattoo { get; set; }
        public string Ear { get; set; }
        public string TypeOfFace { get; set; }
        public string ScarsAndHandicap { get; set; }
        public string Forehead { get; set; }
        public string IdentificationMark { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string LastUpdateBy { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public bool DeleteRecord { get; set; }

    }
}
