using project_pkdsim.Assets.USys.MoneySys.I.PRICESys.ChangePrices.I;
using UnityEngine;

namespace project_pkdsim.Assets.USys.HolidaySys.ULoader.Holidays.AssetsSorter.Labor_Day
{
	public class Labor_Day_IAssetsLoader : MonoBehaviour
	{
		private ChangePricesI ChangePrices;
		public void loadLabor_DayHAssetsLoader()
		{
			// Load Labor Day Assets
		}
		public void LoadLabor_DaySales()
		{
			// Load Labor Day Sales
			ChangePrices.LoadLabor_DayPrices();
		}
	}
}