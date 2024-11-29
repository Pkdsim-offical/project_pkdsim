
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Luna_AniData.AniData_Idle.AniData_IdleSitting;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Luna_AniData.AniData_Idle.AniData_IdleStanding;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Luna_AniData.AniData_Idle
{
    public class Luna_AniData_Idle
    {
        private Luna_AniData_IdleSI Luna_AniData_IdleSitting;
        private Luna_AniData_IdleST Luna_AniData_IdleStanding;
        public void Luna_AniData_IdleST_I()
        {
            Luna_AniData_IdleStanding.Luna_AniData_IdleStandingI();
        }
        public void Luna_AniData_IdleSI_I()
        {
            Luna_AniData_IdleSitting.Luna_AniData_IdleSittingI();
        }
    }
}