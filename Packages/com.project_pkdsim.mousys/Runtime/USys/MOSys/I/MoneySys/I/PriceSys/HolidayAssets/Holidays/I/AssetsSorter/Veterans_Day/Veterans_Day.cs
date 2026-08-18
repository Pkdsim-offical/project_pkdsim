using project_pkdsim.USys.MOSys.Modules.MONEYSys.Modules.PRICESys.ChangePrices.Modules;
using UnityEngine;

namespace project_pkdsim.USys.HDSys.Modules.HOLIDAYSys.Modules.DataBase.ULoader.Holidays.AssetsSorter.Veterans_Day
{
	public class Veterans_Day_IAssetsLoader : MonoBehaviour
	{
		private ChangePricesI ChangePrices;
		public void loadVeterans_DayHAssets()
		{
			//Load Veterans Day Assets
		}

		public void LoadVeterans_DaySales()
		{
			//Load Veterans Day Sales
			ChangePrices.LoadVeterans_DayPrices();
		}
	}
}