
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Fr_AniData.AniData_Idle.AniData_IdleSitting;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Fr_AniData.AniData_Idle.AniData_IdleStanding;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Fr_AniData.AniData_Idle
{
    public class Fr_AniData_Idle
    {
        private Fr_AniData_IdleSI Fr_AniData_IdleSitting;
        private Fr_AniData_IdleST Fr_AniData_IdleStanding;
        public void Fr_AniData_IdleST_I()
        {
            Fr_AniData_IdleStanding.Fr_AniData_IdleStandingI();
        }
        public void Fr_AniData_IdleSI_I()
        {
            Fr_AniData_IdleSitting.Fr_AniData_IdleSittingI();
        }
    }
}