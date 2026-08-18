using project_pkdsim.USys.MOSys.Modules.MONEYSys.Modules.PRICESys.ChangePrices.Modules;
using UnityEngine;

namespace project_pkdsim.USys.HDSys.Modules.HOLIDAYSys.Modules.DataBase.ULoader.Holidays.AssetsSorter.Fathers_Day
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