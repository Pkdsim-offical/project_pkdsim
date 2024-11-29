using project_pkdsim.Assets.USys.HDSys.ULoader.Assets.I.AssetsSorterI;
using UnityEngine;

namespace project_pkdsim.Assets.USys.ITEMSSys.ITEMS.ItemsScripts.Holiday.AssetsSorter.Fathers_Day
{
	public class Fathers_Day_ITAssets : MonoBehaviour
	{
		private HDA_ULoader holidayLoader;
		public static void LoadFathers_DayITHAssets()
		{
			HDA_ULoader.InitializeHolidayAsset("FathersDayAssetKey"); // Load the holiday asset.
		}
	}
}