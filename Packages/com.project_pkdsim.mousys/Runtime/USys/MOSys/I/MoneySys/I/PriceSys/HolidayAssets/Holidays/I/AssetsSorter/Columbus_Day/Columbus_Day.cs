using project_pkdsim.USys.MOSys.Modules.MONEYSys.Modules.PRICESys.ChangePrices.Modules;
using UnityEngine;

namespace project_pkdsim.USys.HDSys.Modules.HOLIDAYSys.Modules.DataBase.ULoader.Holidays.AssetsSorter.Columbus_Day
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