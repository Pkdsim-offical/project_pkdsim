using project_pkdsim.Assets.USys.MoneySys.I.PRICESys.ChangePrices.I;
using UnityEngine;

namespace project_pkdsim.Assets.USys.HolidaySys.ULoader.Holidays.AssetsSorter.Valentines_Day
{
	public class Valentines_Day_IAssetsLoader : MonoBehaviour
	{
		private ChangePricesI ChangePrices;
		public void loadValentines_DayHAssets()
		{
			// Load Valentines Day Assets
		}

		public void LoadValentines_DaySales()
		{
			// Load Valentines Day Sales
			ChangePrices.LoadValentines_DayPrices();
		}
	}
}