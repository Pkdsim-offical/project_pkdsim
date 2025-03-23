using project_pkdsim.Assets.USys.HolidaySys.ULoader.Assets.I.AssetsSorterI;
using UnityEngine;

namespace project_pkdsim.Assets.USys.USystemsSys.ITEMS.ItemsScripts.Holiday.AssetsSorter.NewYear
{
	public class NewYears_ITAssets : MonoBehaviour
	{
		private HDA_ULoader holidayLoader;
		public void LoadNewYears_ITHAssets()
		{
			//Load New Years Item Assets
			HDA_ULoader.InitializeHolidayAsset("NewYearAssetKey"); // Load the holiday asset.
		}
	}
}