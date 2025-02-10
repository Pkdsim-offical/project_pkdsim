
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Ab_AniData.AniData_Idle.AniData_IdleStanding;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Pr_AniData.AniData_Idle.AniData_IdleSitting;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Pr_AniData.AniData_Idle.AniData_IdleStanding;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Pr_AniData.AniData_Idle
{
    public class Pr_AniData_Idle
    {
        private Pr_AniData_IdleSI Pr_AniData_IdleSitting;
        private Pr_AniData_IdleST Pr_AniData_IdleStanding;
        public void Pr_AniData_IdleST_I()
        {
            Pr_AniData_IdleStanding.Pr_AniData_IdleStandingI();
        }
        public void Pr_AniData_IdleSI_I()
        {
            Pr_AniData_IdleSitting.Pr_AniData_IdleSittingI();
        }
    }
}