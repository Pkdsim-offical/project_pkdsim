using project_pkdsim.Assets.USys.PriceSys.ChangePrices.I;
using UnityEngine;

namespace project_pkdsim.Assets.Models.SCRIPTS.USys.HDSys.ULoader.Holidays.AssetsSorter.Labor_Day
{
	public class Labor_Day_IAssetsLoader : MonoBehaviour
	{
		private ChangePricesI ChangePrices;
		public static void loadLabor_DayHAssetsLoader()
		{
			//Load Labor Day Assets
		}
		public static void LoadLabor_DaySales()
		{
			//Load Labor Day Sales
			ChangePricesI.LoadLabor_DayPrices();
		}
	}
}