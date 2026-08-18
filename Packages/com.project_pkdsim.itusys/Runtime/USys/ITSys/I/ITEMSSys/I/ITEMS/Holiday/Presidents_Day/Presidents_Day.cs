using project_pkdsim.USys.HDSys.Modules.HOLIDAYSys.Modules.DataBase.ULoader.Assets.Modules.AssetsSorterI;
using UnityEngine;

namespace project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Holiday.AssetsSorter.Presidents_Day
{
	public class Presidents_Day_ITAssets : MonoBehaviour
	{
		private HDA_ULoader holidayLoader;
		public void LoadPresidents_DayITHAssets()
		{
			//Load Presidents Day Item Assets
			HDA_ULoader.InitializeHolidayAsset("Presidents_Day_AssetKey");
		}
	}
}