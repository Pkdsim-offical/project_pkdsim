using project_pkdsim.Assets.USys.HDSys.ULoader.Assets.I.AssetsSorterI;
using project_pkdsim.Assets.USys.HDSys.ULoader.Holidays;
using UnityEngine;

namespace project_pkdsim.Assets.USys.HDSys.ULoader
{
	public class HDSys_Loader : MonoBehaviour
	{
		private HDA_ULoader HDAssetsSys_loader;
		private HDH_ULoader HDHolidaysSys_loader;

		protected void HDA_Loader()
		{
			HDA_ULoader.InitializeHolidayAsset();
		}
		protected void HDH_Loader()
		{
			HDH_ULoader.InitializeHolidaysDatabase();
		}
	}
}