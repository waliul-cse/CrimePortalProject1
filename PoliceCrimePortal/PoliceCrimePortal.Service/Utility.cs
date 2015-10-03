using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceCrimePortal.Service
{
   public class Utility
    {
        #region Methods to Generate IDs
        /// <summary>
        /// generate a new uniqueid
        /// </summary>
        /// <returns></returns>
        static public String GetNewID(string type)
        {
            String newID = type;
            DateTime now = System.DateTime.Now;
            newID += now.Year;
            newID += now.Month.ToString().PadLeft(2, '0');
            newID += now.Day.ToString().PadLeft(2, '0');
            newID += now.Hour.ToString().PadLeft(2, '0');
            newID += now.Minute.ToString().PadLeft(2, '0');
            newID += now.Second.ToString().PadLeft(2, '0');
            newID += now.Millisecond.ToString().PadLeft(3, '0');
            System.Threading.Thread.Sleep(3);
            return newID;
        }

        #endregion
    }
}
