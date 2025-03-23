using project_pkdsim.Assets.USys.MoneySys.I.PRICESys.ChangePrices.I;
using UnityEngine;

namespace project_pkdsim.Assets.USys.HolidaySys.ULoader.Holidays.AssetsSorter.CincoDeMayo
{
	public class CincoDeMayo_IAssetsLoader : MonoBehaviour
	{
		private ChangePricesI ChangePrices;
		public static void LoadCincoDeMayoHAssets()
		{
			// Load Cinco De Mayo Assets
		}
		public void LoadCincoDeMayo_Prices()
		{
			// Load Cinco De Mayo Prices
			ChangePrices.LoadCincoDeMayoPrices();
		}
	}
}