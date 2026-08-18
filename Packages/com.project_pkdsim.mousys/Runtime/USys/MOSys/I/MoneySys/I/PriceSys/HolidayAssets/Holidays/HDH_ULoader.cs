using project_pkdsim.USys.HDSys.Modules.HOLIDAYSys.ULoader.Holidays.Modules;

namespace project_pkdsim.USys.HDSys.Modules.HOLIDAYSys.Modules.DataBase.ULoader.Holidays
{
	public class HDH_ULoader : IAssetSorter
	{
		public void InitializeHolidaysDatabase()
		{
			LoadAllHolidays();
		}
	}
}