using project_pkdsim.USys.HDSys.Modules.HOLIDAYSys.Modules.DataBase.HolidayDatabaseSys.Modules;

namespace project_pkdsim.USys.HDSys.Modules.HOLIDAYSys.Modules.DataBase
{
    public class HDatabaseSys : HolidayDatabase
    {
        public void HDatabaseSys_Init()
        {
            Get_Holidays();
        }
    }
}

