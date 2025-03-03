using project_pkdsim.Assets.USys.HDSys.ULoader.Assets.I.AssetsSorterI;
using UnityEngine;

namespace project_pkdsim.Assets.USys.ITEMSSys.ITEMS.ItemsScripts.Holiday.AssetsSorter.Presidents_Day
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