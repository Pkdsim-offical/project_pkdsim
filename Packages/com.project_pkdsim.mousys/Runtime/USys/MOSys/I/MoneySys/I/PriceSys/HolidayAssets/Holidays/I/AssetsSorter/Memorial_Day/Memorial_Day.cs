using project_pkdsim.USys.MOSys.Modules.MONEYSys.Modules.PRICESys.ChangePrices.Modules;
using UnityEngine;

namespace project_pkdsim.USys.HDSys.Modules.HOLIDAYSys.Modules.DataBase.ULoader.Holidays.AssetsSorter.Memorial_Day
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