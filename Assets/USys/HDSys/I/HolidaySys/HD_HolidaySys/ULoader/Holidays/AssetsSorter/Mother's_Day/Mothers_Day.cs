using project_pkdsim.Assets.USys.MoneySys.I.PRICESys.ChangePrices.I;
using UnityEngine;

namespace project_pkdsim.Assets.USys.HolidaySys.ULoader.Holidays.AssetsSorter.Mothers_Day
{
	public class Mothers_Day_IAssetsLoader : MonoBehaviour 
	{
		private ChangePricesI ChangePrices;
		public void LoadMothers_DayHAssets()
		{
			//Load Mother's Day Assets
		}

		public void LoadMothers_DaySales()
		{
			// Load Mother's Day Sales
			ChangePrices.LoadMothers_DayPrices();
		}
	}
}