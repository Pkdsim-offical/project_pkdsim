using project_pkdsim.Assets.USys.HolidaySys.ULoader.Assets.I.AssetsSorterI;
using UnityEngine;

namespace project_pkdsim.Assets.USys.USystemsSys.ITEMS.ItemsScripts.Holiday.AssetsSorter.Halloween
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