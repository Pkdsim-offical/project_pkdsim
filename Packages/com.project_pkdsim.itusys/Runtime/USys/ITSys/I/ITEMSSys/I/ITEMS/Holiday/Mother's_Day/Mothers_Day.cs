using project_pkdsim.USys.HDSys.Modules.HOLIDAYSys.Modules.DataBase.ULoader.Assets.Modules.AssetsSorterI;
using UnityEngine;

namespace project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Holiday.AssetsSorter.Mothers_Day
{
	public class Mothers_Day_ITAssets : MonoBehaviour 
	{
		private HDA_ULoader holidayLoader;
		public void LoadMothers_DayITHAssets()
		{
			//Load Mothers Day Item Assets
			HDA_ULoader.InitializeHolidayAsset("MothersDayAssetKey"); // Load the holiday asset.
		}
	}
}