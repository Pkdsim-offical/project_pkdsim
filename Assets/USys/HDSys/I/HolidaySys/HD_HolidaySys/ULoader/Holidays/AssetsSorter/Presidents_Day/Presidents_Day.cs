using project_pkdsim.Assets.USys.MoneySys.I.PRICESys.ChangePrices.I;
using UnityEngine;

namespace project_pkdsim.Assets.USys.HolidaySys.ULoader.Holidays.AssetsSorter.Presidents_Day
{
	public class Presidents_Day_IAssetsLoader : MonoBehaviour
	{
		private ChangePricesI ChangePrices;
		public void loadPresidents_DayHAssets()
		{
			//Load Presidents Day Assets
		}

		public void LoadPresidents_DaySales()
		{
			//Load Presidents Day Sales
			ChangePrices.LoadPresidents_DayPrices();
		}
	}
}