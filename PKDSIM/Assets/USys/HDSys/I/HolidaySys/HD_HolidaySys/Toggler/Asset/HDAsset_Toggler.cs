
using project_pkdsim.Assets.USys.HolidaySys.HolidayDatabaseSys.I;
using project_pkdsim.Assets.USys.HolidaySys.Toggler.Holiday;
using project_pkdsim.Assets.USys.HolidaySys.ULoader.Assets.I.AssetsSorterI;
using project_pkdsim.Assets.USys.HolidaySys.Base;
using System;
using UnityEngine;


namespace project_pkdsim.Assets.USys.HolidaySys.Toggler.Asset
{
	public class HDAsset_Toggler : MonoBehaviour
	{
		private HolidayDatabase holidayDatabase; // Reference to the holiday database
		
		private HDA_ULoader assetLoader; // Reference to the asset loader
		
		private HDHoliday_Toggler holidayToggler; // Reference to holiday toggler
		
		private Holiday_Base holidayBase; // Reference to holiday base

		#pragma warning disable IDE0052 // Remove unread private members
        private bool hasError = false; // Flag to indicate if any component is missing
		#pragma warning restore IDE0052 // Remove unread private members

        private void Start()
		{
			// Initialize references to holiday database and loader
			holidayDatabase = GetComponent<HolidayDatabase>();
			assetLoader = GetComponent<HDA_ULoader>();
			holidayToggler = GetComponent<HDHoliday_Toggler>();
			holidayBase = GetComponent<Holiday_Base>();

			// Check if required components are initialized
			if (holidayDatabase == null)
			{
				Debug.LogError("HolidayDatabase component not found.");
				hasError = true;
			}
			if (assetLoader == null)
			{
				Debug.LogError("Asset loader (HDA_ULoader) component not found.");
				hasError = true;
			}
			if (holidayToggler == null)
			{
				Debug.LogError("Holiday toggler (HDHoliday_Toggler) component not found.");
				hasError = true;
			}
			if (holidayBase == null)
			{
				Debug.LogError("Holiday base (Holiday_Base) component not found.");
				hasError = true;
			}
		}

		private bool CheckRequiredComponents()
		{
			// Returns true if any component is missing, otherwise false
			if (holidayDatabase == null || assetLoader == null || holidayToggler == null || holidayBase == null)
			{
				Debug.LogError("One or more required components are not initialized.");
				return true;
			}
			return false;
		}

		public bool IsTodayHoliday(Holiday_Base holiday, DateTime today)
		{
			// Compares holiday date to today's date
			return holiday.Date.Month == today.Month && holiday.Date.Day == today.Day;
		}

		private void ToggleHolidayAssets()
		{
			// Check if today is a holiday
			if (IsTodayHoliday(holidayBase, DateTime.Today))
			{
				Debug.Log("Today is a holiday!");
				holidayToggler.ReToggle_EHAssets();
			}
			else
			{
				Debug.Log("Today is not a holiday.");
				holidayToggler.DeToggle_EHAssets();
			}
		}

		public void Asset_Toggler()
		{
			// Check for errors in required components and toggle assets accordingly
			if (CheckRequiredComponents())
			{
				Debug.LogError("Cannot toggle assets due to missing components.");
				hasError = true;
			}
			else
			{
				Debug.Log("Toggling assets...");
				ToggleHolidayAssets();
			}
		}
	}
}
