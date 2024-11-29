using project_pkdsim.Assets.USys.PriceSys.ChangePrices.I;
using UnityEngine;

namespace project_pkdsim.Assets.Models.SCRIPTS.USys.HDSys.ULoader.Holidays.AssetsSorter.Thanksgiving
{
	public class Thanksgiving_IAssetsLoader : MonoBehaviour
	{
		private ChangePricesI ChangePrices;

		public static void loadThanksgivingHAssetsLoader()
		{
			// Load Thanksgiving Assets
		}

		public static void LoadThanksgivingSales()
		{
			// Load Thanksgiving Sales
			ChangePricesI.LoadThanksgivingPrices();
		}
	}
}