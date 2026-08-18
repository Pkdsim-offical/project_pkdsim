using project_pkdsim.USys.HDSys.Modules.HOLIDAYSys.Modules.DataBase.ULoader.Assets.Modules.AssetsSorterI;
using UnityEngine;

namespace project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Holiday.AssetsSorter.NewYear
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