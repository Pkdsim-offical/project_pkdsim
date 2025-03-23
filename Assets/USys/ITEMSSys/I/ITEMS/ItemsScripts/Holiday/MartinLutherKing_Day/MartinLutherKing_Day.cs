using project_pkdsim.Assets.USys.HolidaySys.ULoader.Assets.I.AssetsSorterI;
using UnityEngine;

namespace project_pkdsim.Assets.USys.USystemsSys.ITEMS.ItemsScripts.Holiday.AssetsSorter.MartinLutherKing_Day
{
	public class MartinLutherKing_Day_ITAssets : MonoBehaviour
	{
		private HDA_ULoader holidayLoader;
		public void LoadMartinLutherKing_DayITHAssets()
		{
			//Load Martin Luther King Day Item Assets
			HDA_ULoader.InitializeHolidayAsset("MartinLutherKingDayAssetKey"); // Load the holiday asset.
		}
	}
}