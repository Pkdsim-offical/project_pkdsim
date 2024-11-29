
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Dl_AniData.AniData_Idle.AniData_IdleSitting;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Dl_AniData.AniData_Idle.AniData_IdleStanding;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Dl_AniData.AniData_Idle
{
    public class Dl_AniData_Idle
    {
        private Dl_AniData_IdleSI Dl_AniData_IdleSitting;
        private Dl_AniData_IdleST Dl_AniData_IdleStanding;
        public void Dl_AniData_IdleST_I()
        {
            Dl_AniData_IdleStanding.Dl_AniData_IdleStanding();
        }
        public void Dl_AniData_IdleSI_I()
        {
            Dl_AniData_IdleSitting.Dl_AniData_IdleSitting();
        }
    }
}