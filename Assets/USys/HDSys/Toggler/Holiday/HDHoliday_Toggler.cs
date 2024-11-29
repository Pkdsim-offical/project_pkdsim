using System;
using project_pkdsim.Assets.USys.HDSys.HDataSys.HolidayDatabase;
using project_pkdsim.Assets.USys.HDSys.Toggler.Asset;
using project_pkdsim.Assets.USys.HDSys.ULoader.Assets.I.AssetsSorterI;
using project_pkdsim.Assets.USys.HSys.Base;
using UnityEngine;

public class HDHoliday_Toggler : MonoBehaviour
{
    private bool NotAHoliday_Toggle = true;
    private Holiday_Base HSys_Base;
    HDAsset_Toggler HDA_Toggler;

    private HDA_ULoader AssetLoader;

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
        NotAHoliday_Toggle = false;
        if (HSys_Base.IsHoliday(DateTime.Today, DateTime.Today))
        {
            ReToggle_EHAssets();
        }
        else
        {
            DeToggle_EHAssets();
        }
    }

    protected void Toggle_NotAHoliday()
    {
        if (HSys_Base.IsHoliday(DateTime.Today, DateTime.Today))
        {
            DeToggle_EHAssets();
        }
        else
        {
            NotAHoliday_Toggle = true;
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
