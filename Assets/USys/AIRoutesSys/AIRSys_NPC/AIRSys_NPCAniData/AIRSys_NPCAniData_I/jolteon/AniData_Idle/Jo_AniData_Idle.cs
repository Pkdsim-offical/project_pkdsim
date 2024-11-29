
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Jo_AniData.AniData_Idle.AniData_IdleSitting;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Jo_AniData.AniData_Idle.AniData_IdleStanding;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Jo_AniData.AniData_Idle
{
    public class Jo_AniData_Idle
    {
        private Jo_AniData_IdleSI Jo_AniData_IdleSitting;
        private Jo_AniData_IdleST Jo_AniData_IdleStanding;
        public void Jo_AniData_IdleST_I()
        {
            Jo_AniData_IdleStanding.Jo_AniData_IdleStandingI();
        }
        public void Jo_AniData_IdleSI_I()
        {
            Jo_AniData_IdleSitting.Jo_AniData_IdleSittingI();
        }
    }
}