using project_pkdsim.Assets.USys.MoneySys.I.PRICESys.ChangePrices.I;
using UnityEngine;

namespace project_pkdsim.Assets.USys.HolidaySys.ULoader.Holidays.AssetsSorter.Columbus_Day
{
	public class Columbus_Day_IAssetsLoader : MonoBehaviour
	{
		private ChangePricesI ChangePrices;
		public void loadColumbusHAssets()
		{
			// Load Columbus Day Assets
		}

		public void LoadColumbus_DaySales()
		{
			// Load Columbus Day Sales
			ChangePrices.LoadColumbus_DayPrices();
		}		
	}
}