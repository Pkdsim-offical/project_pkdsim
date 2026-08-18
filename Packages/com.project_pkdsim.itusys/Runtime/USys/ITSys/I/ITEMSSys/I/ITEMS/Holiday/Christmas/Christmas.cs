using project_pkdsim.USys.HDSys.Modules.HOLIDAYSys.Modules.DataBase.ULoader.Assets.Modules.AssetsSorterI;
using UnityEngine;

namespace project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Holiday.AssetsSorter.Christmas
{
	public class Christmas_ITAssets : MonoBehaviour
	{
		private HDA_ULoader holidayLoader;
		public void LoadChristmas_ITHAssets()
		{
			//Load Christmas Item Assets
			HDA_ULoader.InitializeHolidayAsset("ChristmasAssetKey"); // Load the holiday asset.
		}
	}
}