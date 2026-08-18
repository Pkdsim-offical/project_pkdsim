using project_pkdsim.USys.HDSys.Modules.HOLIDAYSys.Modules.DataBase.Base;
using project_pkdsim.USys.HDSys.Modules.HOLIDAYSys.Modules.DataBase.ULoader.Assets.Modules.AssetsSorterI;
using project_pkdsim.USys.HDSys.Modules.HOLIDAYSys.ULoader.Holidays;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace project_pkdsim.USys.HDSys.Modules.HOLIDAYSys.Modules.DataBase.HolidayDatabaseSys.Modules
{
    public class HolidayDatabase : MonoBehaviour
    {
        private HDA_ULoader HDH_Loader;
        public static List<Holiday_Base> Holidays;

        void Start()
        {
            Get_Holidays();
        }

        protected void Get_Holidays()
        {
            var HDH_ULoader = new HDH_ULoader();
            HDH_ULoader.InitializeHolidaysDatabase(); // Assuming LoadHolidays returns a List<Holiday_Base>
        }

        public List<DateTime> GetHolidaysForYear(int year)
        {
            List<DateTime> holidayDates = new List<DateTime>();
            foreach (var holiday in Holidays)
            {
                DateTime holidayDate = new DateTime(year, holiday.Date.Month, holiday.Date.Day);
                holidayDates.Add(holidayDate);
            }
            return holidayDates;
        }
    }
}
