
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Ph_AniData.AniData_Idle.AniData_IdleSitting;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Ph_AniData.AniData_Idle.AniData_IdleStanding;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Ph_AniData.AniData_Idle
{
    public class Ph_AniData_Idle
    {
        private Ph_AniData_IdleSI Ph_AniData_IdleSitting;
        private Ph_AniData_IdleST Ph_AniData_IdleStanding;
        public void Ph_AniData_IdleST_I()
        {
            Ph_AniData_IdleStanding.Ph_AniData_IdleStandingI();
        }
        public void Ph_AniData_IdleSI_I()
        {
            Ph_AniData_IdleSitting.Ph_AniData_IdleSittingI();
        }
    }
}