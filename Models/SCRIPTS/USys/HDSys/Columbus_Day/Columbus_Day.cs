
using project_pkdsim.Assets.USys.HDSys.ULoader.Holidays.I.AssetsSorterI;
using project_pkdsim.Assets.USys.PriceSys.ChangePrices.I;
using UnityEditor;

namespace project_pkdsim.Assets.USys.HDSys.ULoader.Holidays.AssetsSorter.Columbus_Day
{
	public class Columbus_Day_IAssetsLoader : IAssetSorter
	{
		private ChangePricesI changePrices;
		public static void loadColumbusHAssets()
		{
			// Load Columbus Day Assets
		}

		public static void LoadColumbusSales()
		{
			// Load Columbus Day Sales
			ChangePricesI.LoadColumbus_DayPrices();
		}		
	}
}