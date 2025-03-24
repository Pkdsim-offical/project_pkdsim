using project_pkdsim.Assets.USys.HolidaySys.ULoader.Assets.I.AssetsSorterI;
using UnityEngine;

namespace project_pkdsim.Assets.USys.USystemsSys.ITEMS.ItemsScripts.Holiday.AssetsSorter.CyberMonday
{
	public class CyberMonday_ITAssets : MonoBehaviour
	{
		private HDA_ULoader holidayLoader;
		public void LoadCyberMonday_ITHAssets()
		{
			//Load Cyber Monday Item Assets
			HDA_ULoader.InitializeHolidayAsset("CyberMondayAssetKey"); // Load the holiday asset.
		}
	}
}