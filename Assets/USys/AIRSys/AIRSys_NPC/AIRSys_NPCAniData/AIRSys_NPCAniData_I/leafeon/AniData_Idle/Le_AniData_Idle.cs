
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Le_AniData.AniData_Idle.AniData_IdleSitting;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Le_AniData.AniData_Idle.AniData_IdleStanding;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Le_AniData.AniData_Idle
{
    public class Le_AniData_Idle
    {
        private Le_AniData_IdleSI Le_AniData_IdleSitting;
        private Le_AniData_IdleST Le_AniData_IdleStanding;
        public void Le_AniData_IdleST_I()
        {
            Le_AniData_IdleStanding.Le_AniData_IdleStandingI();
        }
        public void Le_AniData_IdleSI_I()
        {
            Le_AniData_IdleSitting.Le_AniData_IdleSittingI();
        }
    }
}