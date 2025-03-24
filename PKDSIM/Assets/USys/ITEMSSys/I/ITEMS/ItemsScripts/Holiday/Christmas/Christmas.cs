using project_pkdsim.Assets.USys.HolidaySys.ULoader.Assets.I.AssetsSorterI;
using UnityEngine;

namespace project_pkdsim.Assets.USys.USystemsSys.ITEMS.ItemsScripts.Holiday.AssetsSorter.Christmas
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