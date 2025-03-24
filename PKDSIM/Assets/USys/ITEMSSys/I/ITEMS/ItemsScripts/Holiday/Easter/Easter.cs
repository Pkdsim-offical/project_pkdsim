using project_pkdsim.Assets.USys.HolidaySys.ULoader.Assets.I.AssetsSorterI;
using UnityEngine;

namespace project_pkdsim.Assets.USys.USystemsSys.ITEMS.ItemsScripts.Holiday.AssetsSorter.Easter
{
	public class Easter_ITAssets : MonoBehaviour
	{
		private HDA_ULoader holidayLoader;
		public void LoadEaster_ITHAssets()
		{
			//Load Easter Item Assets
			HDA_ULoader.InitializeHolidayAsset("EasterAssetKey"); // Load the holiday asset.
		}
	}
}