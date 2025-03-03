using project_pkdsim.Assets.USys.HDSys.ULoader.Holidays.I.AssetsSorterI;

namespace project_pkdsim.Assets.USys.HDSys.ULoader.Holidays
{
	public class HDH_ULoader : IAssetSorter
	{
		public void InitializeHolidaysDatabase()
		{
			LoadAllHolidays();
		}
	}
}