using project_pkdsim.Assets.USys.MoneySys.I.PRICESys.ChangePrices.I;
using UnityEngine;

namespace project_pkdsim.Assets.USys.HolidaySys.ULoader.Holidays.AssetsSorter.NewYear
{
	public class NewYears_IAssetsLoader : MonoBehaviour
	{
		private ChangePricesI ChangePrices;
		public void LoadNewYearsHAssetsLoader()
		{
			// Load New Years Assets
		}

		public void LoadNewYearsSales()
		{
			// Load New Years Sales
			ChangePrices.LoadNewYearPrices();
		}
	}
}