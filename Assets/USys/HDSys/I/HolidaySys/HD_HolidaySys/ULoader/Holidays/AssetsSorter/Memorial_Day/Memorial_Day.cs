using project_pkdsim.Assets.USys.MoneySys.I.PRICESys.ChangePrices.I;
using UnityEngine;

namespace project_pkdsim.Assets.USys.HolidaySys.ULoader.Holidays.AssetsSorter.Memorial_Day
{
	public class Memorial_Day_IAssetsLoader : MonoBehaviour
	{
		private ChangePricesI ChangePrices;
		public void LoadMemorial_DayHAssetLoader()
		{
			// Load Memorial Day assets
		}

		public void LoadMemorial_DaySales()
		{
			// Load Memorial Day Sales
			ChangePrices.LoadMemorial_DayPrices();
		}
	}
}