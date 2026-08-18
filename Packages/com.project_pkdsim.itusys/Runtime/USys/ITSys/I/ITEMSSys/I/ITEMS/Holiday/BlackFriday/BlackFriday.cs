using project_pkdsim.USys.HDSys.Modules.HOLIDAYSys.Modules.DataBase.ULoader.Assets.Modules.AssetsSorterI;
using UnityEngine;

namespace project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Holiday.AssetsSorter.BlackFriday
{
	public class BlackFriday_ITAssets : MonoBehaviour
	{
		private HDA_ULoader holidayLoader;
		public void LoadBlackFridayITHAssets()
		{
			//Load Black Friday Item Assets
			HDA_ULoader.InitializeHolidayAsset("BlackFridayAssetKey"); // Load the holiday asset.
		}
	}
}