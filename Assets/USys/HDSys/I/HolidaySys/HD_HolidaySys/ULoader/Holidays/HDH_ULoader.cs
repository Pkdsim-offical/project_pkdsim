using project_pkdsim.Assets.USys.HolidaySys.ULoader.Holidays.I;

namespace project_pkdsim.Assets.USys.HolidaySys.ULoader.Holidays
{
	public class HDH_ULoader : IAssetSorter
	{
		public void InitializeHolidaysDatabase()
		{
			LoadAllHolidays();
		}
	}
}