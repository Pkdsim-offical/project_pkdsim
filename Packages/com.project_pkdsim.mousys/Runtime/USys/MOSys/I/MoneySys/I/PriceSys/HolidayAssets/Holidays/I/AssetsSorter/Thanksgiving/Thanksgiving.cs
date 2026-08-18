using project_pkdsim.USys.MOSys.Modules.MONEYSys.Modules.PRICESys.ChangePrices.Modules;
using UnityEngine;

namespace project_pkdsim.USys.HDSys.Modules.HOLIDAYSys.Modules.DataBase.ULoader.Holidays.AssetsSorter.Thanksgiving
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