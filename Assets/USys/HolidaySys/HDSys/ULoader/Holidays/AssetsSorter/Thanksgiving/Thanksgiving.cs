using project_pkdsim.Assets.USys.MONEYSys.PRICESys.ChangePrices.I;
using UnityEngine;

namespace project_pkdsim.Assets.USys.HDSys.ULoader.Holidays.AssetsSorter.Thanksgiving
{
	public class Thanksgiving_IAssetsLoader : MonoBehaviour
	{
		private ChangePricesI ChangePrices;
		public void loadThanksgivingHAssetsLoader()
		{
			// Load Thanksgiving Assets
		}

		public void LoadThanksgivingSales()
		{
			// Load Thanksgiving Sales
			ChangePrices.LoadThanksgivingPrices();
		}
	}
}