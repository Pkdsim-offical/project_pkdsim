using project_pkdsim.Assets.USys.HDSys.ULoader.Assets.I.AssetsSorterI;
using UnityEngine;

namespace project_pkdsim.Assets.USys.ITEMSSys.ITEMS.ItemsScripts.Holiday.AssetsSorter.Columbus_Day
{
	public class Columbus_Day_ITAssets : MonoBehaviour
	{
		private HDA_ULoader holidayLoader;
		public void LoadColumbus_DayITHAssets()
		{
			//Load Columbus Day Item Assets
			HDA_ULoader.InitializeHolidayAsset("ColumbusDayAssetKey"); // Load the holiday asset.
		}
	}
}