using project_pkdsim.Assets.USys.HDSys.ULoader.Assets.I.AssetsSorterI;
using UnityEngine;

namespace project_pkdsim.Assets.USys.ITEMSSys.ITEMS.ItemsScripts.Holiday.AssetsSorter.Valentines_Day
{
	public class Valentines_Day_ITAssets : MonoBehaviour
	{
		private HDA_ULoader holidayLoader;
		public void LoadValentines_DayITHAssets()
		{
			//Load Valentines_Day Item Assets
			HDA_ULoader.InitializeHolidayAsset("ValentinesDayAssetKey"); // Load the holiday asset.
		}
	}
}