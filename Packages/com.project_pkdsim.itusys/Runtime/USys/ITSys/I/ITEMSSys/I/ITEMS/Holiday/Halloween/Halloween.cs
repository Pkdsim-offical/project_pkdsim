using project_pkdsim.USys.HDSys.Modules.HOLIDAYSys.Modules.DataBase.ULoader.Assets.Modules.AssetsSorterI;
using UnityEngine;

namespace project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Holiday.AssetsSorter.Halloween
{
	public class Halloween_ITAssets : MonoBehaviour
	{
		private HDA_ULoader holidayLoader;
		public void LoadHalloweenITHAssets()
		{
			//Load Halloween Item Assets
			HDA_ULoader.InitializeHolidayAsset("HalloweenAssetKey"); // Load the holiday asset.
		}
	}
}