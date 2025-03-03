using project_pkdsim.Assets.USys.HDSys.ULoader.Holidays;
using project_pkdsim.Assets.USys.HSys.Base;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace project_pkdsim.Assets.USys.HDSys.HDataSys.HolidayDatabase
{
    public class HolidayDatabase : MonoBehaviour
    {
        private HDH_ULoader HDH_Loader;
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
