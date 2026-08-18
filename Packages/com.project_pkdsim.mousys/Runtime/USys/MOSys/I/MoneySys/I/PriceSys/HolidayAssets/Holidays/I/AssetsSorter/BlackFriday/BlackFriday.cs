using project_pkdsim.USys.MOSys.Modules.MONEYSys.Modules.PRICESys.ChangePrices.Modules;
using UnityEngine;

namespace project_pkdsim.USys.HDSys.Modules.HOLIDAYSys.Modules.DataBase.ULoader.Holidays.AssetsSorter.BlackFriday
{
	public class BlackFriday_IAssetLoader : MonoBehaviour
	{
		private ChangePricesI ChangePrices;
		public void loadBlackFridayHAssetLoader()
		{
			// Load Black Friday Assets
		}
		public void LoadBlackFridaySales()
		{
			// Load Black Friday Sales
			ChangePrices.LoadBlackFridayPrices();
		}
	}
}