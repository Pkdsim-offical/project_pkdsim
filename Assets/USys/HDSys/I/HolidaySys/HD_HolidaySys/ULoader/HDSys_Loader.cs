using project_pkdsim.Assets.USys.HolidaySys.ULoader.Assets.I.AssetsSorterI;
using project_pkdsim.Assets.USys.HolidaySys.ULoader.Holidays;
using UnityEngine;

namespace project_pkdsim.Assets.USys.HolidaySys.ULoader
{
	public class HDSys_Loader : MonoBehaviour
	{
		private HDA_ULoader HDAssetsSys_loader;
		private HDH_ULoader HDHolidaysSys_loader;
		public void HDSys_LoaderI()
		{
			HDA_Loader();
			HDH_Loader();
		}

		private void HDA_Loader()
		{
			var HDA_ULoader = new HDA_ULoader();
			HDA_ULoader.InitializeHolidayAsset();
		}
		private void HDH_Loader()
		{
			var HDH_ULoader = new HDH_ULoader();
			HDH_ULoader.InitializeHolidaysDatabase();
		}
	}
}