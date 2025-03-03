using project_pkdsim.Assets.USys.HDSys.ULoader.Assets.I.AssetsSorterI;
using UnityEngine;

namespace project_pkdsim.Assets.USys.ITEMSSys.ITEMS.ItemsScripts.Holiday.AssetsSorter.Memorial_Day
{
	public class Memorial_Day_ITAssets : MonoBehaviour
	{
		private HDA_ULoader holidayLoader;
		public void LoadMemorial_DayITHAssets()
		{
			//Load Memorial Day Item Assets
			HDA_ULoader.InitializeHolidayAsset("MemorialDayAssetKey"); // Load the holiday asset.
		}
	}
}