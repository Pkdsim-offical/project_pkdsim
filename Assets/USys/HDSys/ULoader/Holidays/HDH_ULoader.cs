using project_pkdsim.Assets.USys.HDSys.ULoader.Holidays.I.AssetsSorterI;
using UnityEngine;

namespace project_pkdsim.Assets.USys.HDSys.ULoader.Holidays
{
	public class HDH_ULoader : IAssetSorter
	{
		public static void InitializeHolidaysDatabase()
		{
			LoadAllHolidays();
		}
	}
}