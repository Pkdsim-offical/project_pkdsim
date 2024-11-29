using project_pkdsim.Assets.USys.PriceSys.ChangePrices.I;
using UnityEngine;

namespace project_pkdsim.Assets.Models.SCRIPTS.USys.HDSys.ULoader.Holidays.AssetsSorter.Fathers_Day
{
	public class Fathers_Day_IAssetsLoader : MonoBehaviour
	{
		private ChangePricesI ChangePrices;
		public static void LoadFathers_DayHAssetsLoader()
		{
			//Load  Fathers Day Assets
		}
		public static void LoadFathers_DaySales()
		{
			//Load Fathers Day Day Sales
			ChangePricesI.LoadFathers_DayPrice();
		}
	}
}