using project_pkdsim.USys.HDSys.Modules.HOLIDAYSys.Modules.DataBase.ULoader.Holiday.Modules.Type;
using project_pkdsim.USys.HDSys.Modules.HOLIDAYSys.ULoader.Holidays;

namespace project_pkdsim.USys.HDSys.Modules.HOLIDAYSys.Modules.DataBase.ULoader.Holiday.Modules.Sorter
{
    public class HolidaySorter
    {
        private GameHolidayAssetSorter GameHolidayAssetSorter;
        private HDH_ULoader HDH_ULoader;

        public void HolidaySorterI()
        {
            InitializeUnityHolidaysDatabase();
        }

        private void InitializeUnityHolidaysDatabase()
        {
            HDH_ULoader.InitializeHolidaysDatabase();        
        }
    }
}