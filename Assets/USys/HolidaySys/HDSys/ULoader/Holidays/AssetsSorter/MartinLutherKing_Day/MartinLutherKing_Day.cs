using project_pkdsim.Assets.USys.MONEYSys.PRICESys.ChangePrices.I;
using UnityEngine;

namespace project_pkdsim.Assets.USys.HDSys.ULoader.Holidays.AssetsSorter.MartinLutherKing_Day
{
	public class MartinLutherKing_Day_IAssetsLoader : MonoBehaviour
	{
		private ChangePricesI ChangePrices;
		public void LoadMartinLutherKingDayHAssets()
		{
			// Load Martin Luther King Day
		}

		public void LoadMartinLutherKing_DaySales()
		{
			// Load Martin Luther King Day Sales
			ChangePrices.LoadMartinLutherKingDayPrices();
		}
	}
}