using System;
using project_pkdsim.Assets.USys.HolidaySys.Base;
using project_pkdsim.Assets.USys.HolidaySys.HolidayDatabaseSys.I;
using project_pkdsim.Assets.USys.HolidaySys.Toggler.Asset;
using project_pkdsim.Assets.USys.HolidaySys.ULoader.Assets.I.AssetsSorterI;
using UnityEngine;
namespace project_pkdsim.Assets.USys.HolidaySys.Toggler.Holiday
{
    public class HDHoliday_Toggler : MonoBehaviour
    {
        private bool NotAHoliday_Toggle = true;
        private Holiday_Base HSys_Base;
        private HDAsset_Toggler HDA_Toggler;

        void Start()
        {
            HSys_Base = new Holiday_Base("Example Holiday", DateTime.Today, "ExampleKey"); // Example initialization
        }

        public void Toggler_Holiday()
        {
            if (HSys_Base.IsHoliday(DateTime.Today, DateTime.Today) == NotAHoliday_Toggle)
            {
                Toggle_NotAHoliday();
            }
            else
            {
                Toggle_Holiday();
            }
        }

        protected void Toggle_Holiday()
        {
            NotAHoliday_Toggle = true;
            if (HSys_Base.IsHoliday(DateTime.Today, DateTime.Today))
            {
                NotAHoliday_Toggle = false;
                ReToggle_EHAssets();
            }
            else
            {
                NotAHoliday_Toggle = true;
                DeToggle_EHAssets();
            }
        }

        protected void Toggle_NotAHoliday()
        {
            if (HSys_Base.IsNotHoliday(DateTime.Today, DateTime.Today))
            {
                NotAHoliday_Toggle = true;
                DeToggle_EHAssets();
            }
            else
            {
                NotAHoliday_Toggle = false;
                ReToggle_EHAssets();
            }
        }

        public void DeToggle_EHAssets()
        {
            DateTime today = DateTime.Today;

            // Check each holiday in the database
            foreach (Holiday_Base holiday in HolidayDatabase.Holidays)
            {
                if (!HDA_Toggler.IsTodayHoliday(holiday, today))
                {
                    continue;
                }
                else
                {
                    Debug.Log($"Today is not {holiday.Name}!");
                }
            }
        }
        public void ReToggle_EHAssets()
        {
            // Logic for re-enabling holiday assets
            DateTime today = DateTime.Today;

            // Check each holiday in the database
            foreach (Holiday_Base holiday in HolidayDatabase.Holidays)
            {
                if (HDA_Toggler.IsTodayHoliday(holiday, today))
                {
                    Debug.Log($"Today is {holiday.Name}!");
                    HDA_ULoader.InitializeHolidayAsset(holiday.AddressableKey); // Updated to use InitializeHolidayAsset
                }
            }
        }
    }
}