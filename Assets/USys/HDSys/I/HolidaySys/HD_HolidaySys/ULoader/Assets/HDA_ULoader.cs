using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace project_pkdsim.Assets.USys.HolidaySys.ULoader.Assets.I.AssetsSorterI
{
	public class HDA_ULoader : MonoBehaviour
	{
		private Dictionary<string, string> holidayAssets;

		private void Start()
		{
			PopulateHolidayAssets();
		}

		public static void InitializeHolidayAsset(string addressableKey = "")
		{
			HDA_ULoader instance = new HDA_ULoader();
			if (string.IsNullOrEmpty(addressableKey))
			{
				instance.InitializeAllHolidays(); // Load all holidays if no specific key is provided
			}
			else
			{
				instance.InitializeCheckHolidayAsset(addressableKey); // Load a specific holiday asset
			}
		}

		// Loads all holiday assets based on the dictionary keys
		private void InitializeAllHolidays()
		{
			foreach (var asset in holidayAssets.Values)
			{
				InitializeCheckHolidayAsset(asset);
			}
		}

		// Loads a specific holiday asset based on the addressable key
		private void InitializeCheckHolidayAsset(string addressableKey)
		{
			Addressables.LoadAssetAsync<GameObject>(addressableKey).Completed += OnAssetLoaded;
		}

		// Callback for asset loading
		private void OnAssetLoaded(AsyncOperationHandle<GameObject> obj)
		{
			if (obj.Status == AsyncOperationStatus.Succeeded)
			{
				GameObject holidayAsset = obj.Result;
				Instantiate(holidayAsset);
				Debug.Log("Holiday asset loaded and instantiated.");
			}
			else
			{
				Debug.LogError("Failed to load holiday asset.");
			}
		}

		// Reloads all assets based on the HolidayAssets dictionary
		public void OnAssetReload()
		{
			if (holidayAssets == null || holidayAssets.Count == 0)
			{
				Debug.LogError("HolidayAssets is null or empty.");
				return;
			}

			foreach (var asset in holidayAssets)
			{
				Debug.Log($"Reloading asset: {asset.Key} with key: {asset.Value}");
				InitializeCheckHolidayAsset(asset.Value);
			}
		}

		// Populates the HolidayAssets dictionary with holiday addressable keys
		private void PopulateHolidayAssets()
		{
			holidayAssets = new Dictionary<string, string>
			{
				{ "BlackFriday", "BlackFridayAssetKey" },
				{ "Christmas", "ChristmasAssetKey" },
				{ "Easter", "EasterAssetKey" },
				{ "Halloween", "HalloweenAssetKey" },
				{ "NewYear", "NewYearAssetKey" },
				{ "ValentinesDay", "ValentinesDayAssetKey" },
				{ "IndependenceDay", "IndependenceDayAssetKey" },
				{ "Thanksgiving", "ThanksgivingAssetKey" },
				{ "CyberMonday", "CyberMondayAssetKey" },
				{ "ColumbusDay", "ColumbusDayAssetKey" },
				{ "MartinLutherKingDay", "MartinLutherKingDayAssetKey" },
				{ "MemorialDay", "MemorialDayAssetKey" },
				{ "FathersDay", "FathersDayAssetKey" },
				{ "MothersDay", "MothersDayAssetKey" },
				{ "PresidentsDay", "PresidentsDayAssetKey" },
				{ "LaborDay", "LaborDayAssetKey" },
				{ "VeteransDay", "VeteransDayAssetKey" },
			};
		}
	}
}
