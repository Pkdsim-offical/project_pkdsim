using project_pkdsim.Assets.USys.PriceSys.ChangePrices.I;
using UnityEngine;

namespace project_pkdsim.Assets.Models.SCRIPTS.USys.HDSys.ULoader.Holidays.AssetsSorter.Valentines_Day
{
	public class Valentines_Day_IAssetsLoader : MonoBehaviour
	{
		ChangePricesI ChangePrices;
		public static void loadValentines_DayHAssets()
		{

		}

		public static void LoadValentines_DaySales()
		{

			ChangePricesI.LoadValentines_DayPrices();
		}
	}
}