using project_pkdsim.Assets.USys.PriceSys.ChangePrices.I;
using UnityEngine;

namespace project_pkdsim.Assets.Models.SCRIPTS.USys.HDSys.ULoader.Holidays.AssetsSorter.CincoDeMayo
{
	public class CincoDeMayo_IAssetsLoader : MonoBehaviour
	{
		private ChangePricesI ChangePrices;
		public static void LoadCincoDeMayoHAssets()
		{
			//Load Cinco De Mayo Assets
		}
		public static void LoadCincoDeMayoPrices()
		{
			ChangePricesI.LoadCincoDeMayoPrices();
		}
	}
}