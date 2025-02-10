using project_pkdsim.Assets.USys.HDSys.ULoader.Assets.I.AssetsSorterI;
using UnityEngine;

namespace project_pkdsim.Assets.USys.ITEMSSys.ITEMS.ItemsScripts.Holiday.AssetsSorter.Independence_Day
{
	public class Independence_Day_ITAssets : MonoBehaviour
	{
		private HDA_ULoader holidayLoader;
		public void LoadIndependence_DayITHAssets()
		{
			//Load Independence Day Item Assets
			HDA_ULoader.InitializeHolidayAsset("IndependenceDayAssetKey"); // Load the holiday asset.
		}
	}
}