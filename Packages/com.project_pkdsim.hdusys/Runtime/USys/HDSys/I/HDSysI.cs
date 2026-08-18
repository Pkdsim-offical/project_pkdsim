using project_pkdsim.USys.HDSys.Modules.HOLIDAYSys.Modules.DataBase;

namespace project_pkdsim.USys.HDSys.Modules
{
    public class HDSysI 
    {
        private HolidaySys HolidaySys;
        public void HDSys_I()
        {
            Load_HolidaySys();
        }
        private void Load_HolidaySys()
        {
            HolidaySys.HolidaySysI();
        }
    }
}