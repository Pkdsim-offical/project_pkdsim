
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Ab_AniData.AniData_Idle.AniData_IdleSitting;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Ab_AniData.AniData_Idle.AniData_IdleStanding;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Ab_AniData.AniData_Idle
{
    public class Ab_AniData_Idle
    {
        private Ab_AniData_IdleSI Ab_AniData_IdleSitting;
        private Ab_AniData_IdleST Ab_AniData_IdleStanding;
        public void Ab_AniData_IdleST_I()
        {
            Ab_AniData_IdleStanding.Ab_AniData_IdleStandingI();
        }
        public void Ab_AniData_IdleSI_I()
        {
            Ab_AniData_IdleSitting.Ab_AniData_IdleSittingI();
        }
    }
}