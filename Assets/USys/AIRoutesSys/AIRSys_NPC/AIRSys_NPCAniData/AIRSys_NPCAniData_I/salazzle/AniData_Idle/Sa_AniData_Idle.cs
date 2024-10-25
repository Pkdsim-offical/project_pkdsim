
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Sa_AniData.AniData_Idle.AniData_IdleSitting;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Sa_AniData.AniData_Idle.AniData_IdleStanding;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Sa_AniData.AniData_Idle
{
    public class Sa_AniData_Idle
    {
        private Sa_AniData_IdleSI Sa_AniData_IdleSitting;
        private Sa_AniData_IdleST Sa_AniData_IdleStanding;
        public void Sa_AniData_IdleST_I()
        {
            Sa_AniData_IdleStanding.Sa_AniData_IdleStandingI();
        }
        public void Sa_AniData_IdleSI_I()
        {
            Sa_AniData_IdleSitting.Sa_AniData_IdleSittingI();
        }
    }
}