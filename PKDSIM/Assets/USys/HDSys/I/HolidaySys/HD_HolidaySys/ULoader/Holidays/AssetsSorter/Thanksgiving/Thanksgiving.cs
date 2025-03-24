using project_pkdsim.Assets.USys.MoneySys.I.PRICESys.ChangePrices.I;
using UnityEngine;

namespace project_pkdsim.Assets.USys.HolidaySys.ULoader.Holidays.AssetsSorter.Thanksgiving
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