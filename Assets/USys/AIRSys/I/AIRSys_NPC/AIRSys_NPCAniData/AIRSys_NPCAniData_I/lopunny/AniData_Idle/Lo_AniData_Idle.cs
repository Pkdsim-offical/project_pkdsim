using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Lo_AniData.AniData_Idle.AniData_IdleSitting;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Lo_AniData.AniData_Idle.AniData_IdleStanding;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Lo_AniData.AniData_Idle
{
    public class Lo_AniData_Idle
    {
        private Lo_AniData_IdleSI Lo_AniData_IdleSitting;
        private Lo_AniData_IdleST Lo_AniData_IdleStanding;
        public void Lo_AniData_IdleST_I()
        {
            Lo_AniData_IdleStanding.Lo_AniData_IdleStandingI();
        }
        public void Lo_AniData_IdleSI_I()
        {
            Lo_AniData_IdleSitting.Lo_AniData_IdleSittingI();
        }
    }
}