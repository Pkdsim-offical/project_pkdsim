using System.Collections;
using project_pkdsim.Assets.USys.PriceSys.ChangePrices;
using project_pkdsim.Assets.USys.PriceSys.ChangePrices.I;
using UnityEngine;

namespace project_pkdsim.Assets.Models.SCRIPTS.USys.HDSys.ULoader.Holidays.AssetsSorter.NewYear
{
	public class NewYears_IAssetsLoader : MonoBehaviour
	{
		private ChangePricesI ChangePrices;
		public static void LoadNewYearsHAssetsLoader()
		{
			// Load New Years Assets
		}

		public static void LoadNewYearsSales()
		{
			// Load New Years Sales
			ChangePricesI.LoadNewYearPrices();
		}
	}
}