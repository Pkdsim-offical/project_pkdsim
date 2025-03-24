using project_pkdsim.Assets.USys.HolidaySys.ULoader.Assets.I.AssetsSorterI;
using UnityEngine;

namespace project_pkdsim.Assets.USys.USystemsSys.ITEMS.ItemsScripts.Holiday.AssetsSorter.Fathers_Day
{
	public class Fathers_Day_ITAssets : MonoBehaviour
	{
		private HDA_ULoader holidayLoader;
		public void LoadFathers_DayITHAssets()
		{
			//Load Fathers Day Item Assets
			HDA_ULoader.InitializeHolidayAsset("FathersDayAssetKey"); // Load the holiday asset.
		}
	}
}