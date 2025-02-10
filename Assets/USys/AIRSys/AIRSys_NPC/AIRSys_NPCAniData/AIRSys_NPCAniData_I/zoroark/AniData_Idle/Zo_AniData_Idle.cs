

using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Zo_AniData.AniData_Idle.AniData_IdleSitting;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Zo_AniData.AniData_Idle.AniData_IdleStanding;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Zo_AniData.AniData_Idle
{
    public class Zo_AniData_Idle
    {
        private Zo_AniData_IdleSI Zo_AniData_IdleSitting;
        private Zo_AniData_IdleST Zo_AniData_IdleStanding;
        public void Zo_AniData_IdleST_I()
        {
            Zo_AniData_IdleStanding.Zo_AniData_IdleStandingI();
        }
        public void Zo_AniData_IdleSI_I()
        {
            Zo_AniData_IdleSitting.Zo_AniData_IdleSittingI();
        }
    }
}