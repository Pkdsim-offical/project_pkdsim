using project_pkdsim.USys.UTPSys.Modules.UHousesTeleporterSys;
using project_pkdsim.USys.UTPSys.Modules.Teleporter;

namespace project_pkdsim.USys.UTPSys.Modules
{
    public class UTPSysI
    {
        private UHTeleporterSys UHTeleporterSys;
        private TeleportSystem TeleportSystem;
        public void UTPSys_I()
        {
            UHTeleporterSys.UHTPSysI();
            TeleportSystem.TeleportSystemI();
        }
    }
}