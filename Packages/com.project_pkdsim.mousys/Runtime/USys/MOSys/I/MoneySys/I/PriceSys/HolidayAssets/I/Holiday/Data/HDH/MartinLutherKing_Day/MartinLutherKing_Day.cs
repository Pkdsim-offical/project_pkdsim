using project_pkdsim.USys.MOSys.Modules.MONEYSys.Modules.PRICESys.ChangePrices.Modules;
using UnityEngine;

namespace project_pkdsim.USys.HDSys.Modules.HOLIDAYSys.ULoader.Holidays.AssetsSorter.MartinLutherKing_Day
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