using project_pkdsim.USys.ADSys.Modules.AntiDateAndTimeSys.Modules;

namespace project_pkdsim.USys.ADSys.Modules
{
    public class ADSysI
    {
        private AntiDATSys AntiDateAndTimeSys;
        public void LoadADATSys()
        {
            AntiDateAndTimeSys.ADATSysI();
        }
        public void ADSys_I()
        {
            LoadADATSys();
        }
    }
}