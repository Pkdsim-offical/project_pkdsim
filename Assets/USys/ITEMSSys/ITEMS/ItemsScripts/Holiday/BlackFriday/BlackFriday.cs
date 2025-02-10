using project_pkdsim.Assets.USys.HDSys.ULoader.Assets.I.AssetsSorterI;
using UnityEngine;

namespace project_pkdsim.Assets.USys.ITEMSSys.ITEMS.ItemsScripts.Holiday.AssetsSorter.BlackFriday
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