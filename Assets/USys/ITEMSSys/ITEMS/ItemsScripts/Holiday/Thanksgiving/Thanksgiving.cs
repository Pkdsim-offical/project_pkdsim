using project_pkdsim.Assets.USys.HDSys.ULoader.Assets.I.AssetsSorterI;
using UnityEngine;

namespace project_pkdsim.Assets.USys.ITEMSSys.ITEMS.ItemsScripts.Holiday.AssetsSorter.Thanksgiving
{
	public class Thanksgiving_ITAssets : MonoBehaviour
	{
		private HDA_ULoader holidayLoader;
		public static void loadThanksgivingITHAssets()
		{
			//Load Thanksgiving Item Assets
			HDA_ULoader.InitializeHolidayAsset("ThanksgivingAssetKey"); // Load the holiday asset.
		}
	}
}