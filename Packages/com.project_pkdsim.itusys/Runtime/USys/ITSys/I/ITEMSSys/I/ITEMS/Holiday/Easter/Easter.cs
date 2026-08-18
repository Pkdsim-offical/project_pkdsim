using project_pkdsim.USys.HDSys.Modules.HOLIDAYSys.Modules.DataBase.ULoader.Assets.Modules.AssetsSorterI;
using UnityEngine;

namespace project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Holiday.AssetsSorter.Easter
{
	public class Easter_ITAssets : MonoBehaviour
	{
		private HDA_ULoader holidayLoader;
		public void LoadEaster_ITHAssets()
		{
			//Load Easter Item Assets
			HDA_ULoader.InitializeHolidayAsset("EasterAssetKey"); // Load the holiday asset.
		}
	}
}