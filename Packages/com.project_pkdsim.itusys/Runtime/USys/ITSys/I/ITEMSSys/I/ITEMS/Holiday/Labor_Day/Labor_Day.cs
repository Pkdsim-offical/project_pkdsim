using project_pkdsim.USys.HDSys.Modules.HOLIDAYSys.Modules.DataBase.ULoader.Assets.Modules.AssetsSorterI;
using UnityEngine;

namespace project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Holiday.AssetsSorter.Labor_Day
{
	public class Labor_Day_ITAssets : MonoBehaviour
	{
		private HDA_ULoader holidayLoader;
		public void LoadLabor_DayITHAssets()
		{
			//Load Labor Day Item Assets
			HDA_ULoader.InitializeHolidayAsset("LaborDayAssetKey"); // Load the holiday asset.
		}
	}
}