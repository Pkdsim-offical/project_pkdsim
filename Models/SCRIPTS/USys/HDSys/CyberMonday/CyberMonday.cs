using project_pkdsim.Assets.USys.PriceSys.ChangePrices.I;
using UnityEngine;

namespace project_pkdsim.Assets.Models.SCRIPTS.USys.HDSys.ULoader.Holidays.AssetsSorter.CyberMonday
{
	public class CyberMonday_IAssetLoader : MonoBehaviour
	{
		private ChangePricesI changePrice;
		public static void LoadCyberMondayHAssetLoader()
		{
			//Load Black Friday
		}
		public static void LoadCyberMondaySales()
		{
			//Load Black Friday
			ChangePricesI.LoadCyberMondayPrices();
		}
	}
}