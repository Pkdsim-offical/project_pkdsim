using project_pkdsim.USys.MOSys.Modules.MONEYSys.Modules.PRICESys.ChangePrices.Modules;
using UnityEngine;

namespace project_pkdsim.USys.HDSys.Modules.HOLIDAYSys.Modules.DataBase.ULoader.Holidays.AssetsSorter.Mothers_Day
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