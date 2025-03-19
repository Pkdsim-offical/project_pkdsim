using project_pkdsim.Assets.USys.HolidaySys.ULoader.Assets.I.AssetsSorterI;
using UnityEngine;

namespace project_pkdsim.Assets.USys.USystemsSys.ITEMS.ItemsScripts.Holiday.AssetsSorter.Veterans_Day
{
	public class Veterans_Day_ITAssets : MonoBehaviour
	{
		private HDA_ULoader holidayLoader;
		public void LoadVeterans_DayITHAssets()
		{
			//Load Veterans Day Item Assets
			HDA_ULoader.InitializeHolidayAsset("VeteransDayAssetKey"); // Load the holiday asset.
		}
	}
}