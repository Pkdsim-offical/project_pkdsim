using project_pkdsim.Assets.USys.HolidaySys.ULoader.Assets.I.AssetsSorterI;
using UnityEngine;

namespace project_pkdsim.Assets.USys.USystemsSys.ITEMS.ItemsScripts.Holiday.AssetsSorter.Thanksgiving
{
	public class Thanksgiving_ITAssets : MonoBehaviour
	{
		private HDA_ULoader holidayLoader;
		public void loadThanksgivingITHAssets()
		{
			//Load Thanksgiving Item Assets
			HDA_ULoader.InitializeHolidayAsset("ThanksgivingAssetKey"); // Load the holiday asset.
		}
	}
}