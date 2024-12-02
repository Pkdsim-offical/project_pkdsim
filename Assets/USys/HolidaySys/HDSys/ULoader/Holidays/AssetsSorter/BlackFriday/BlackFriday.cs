using project_pkdsim.Assets.USys.MONEYSys.PRICESys.ChangePrices.I;
using UnityEngine;

namespace project_pkdsim.Assets.USys.HDSys.ULoader.Holidays.AssetsSorter.BlackFriday
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