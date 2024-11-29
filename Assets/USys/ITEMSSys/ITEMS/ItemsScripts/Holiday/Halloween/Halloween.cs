using project_pkdsim.Assets.USys.HDSys.ULoader.Assets.I.AssetsSorterI;
using UnityEngine;

namespace project_pkdsim.Assets.USys.ITEMSSys.ITEMS.Holiday.Assets.AssetsSorter.Halloween
{
	public class Halloween_ITAssets : MonoBehaviour
	{
		private HDA_ULoader holidayLoader;
		public static void LoadHalloweenITHAssets()
		{
			//Load Halloween Item Assets
			HDA_ULoader.InitializeHolidayAsset("HalloweenAssetKey"); // Load the holiday asset.
		}
	}
}