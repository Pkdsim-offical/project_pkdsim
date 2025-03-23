using project_pkdsim.Assets.USys.MoneySys.I.PRICESys.ChangePrices.I;
using UnityEngine;

namespace project_pkdsim.Assets.USys.HolidaySys.ULoader.Holidays.AssetsSorter.Fathers_Day
{
	public class Fathers_Day_IAssetsLoader : MonoBehaviour
	{
		private ChangePricesI ChangePrices;
		public void LoadFathers_DayHAssetsLoader()
		{
			// Load Fathers Day Assets
		}
		public void LoadFathers_DaySales()
		{
			// Load Fathers Day Day Sales
			ChangePrices.LoadFathers_DayPrices();
		}
	}
}