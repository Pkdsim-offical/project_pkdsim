
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Gard_AniData.AniData_Idle.AniData_IdleSitting;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Gard_AniData.AniData_Idle.AniData_IdleStanding;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Gard_AniData.AniData_Idle
{
    public class Gard_AniData_Idle
    {
        private Gard_AniData_IdleSI Gard_AniData_IdleSitting;
        private Gard_AniData_IdleST Gard_AniData_IdleStanding;
        public void Gard_AniData_IdleST_I()
        {
            Gard_AniData_IdleStanding.Gard_AniData_IdleStandingI();
        }
        public void Gard_AniData_IdleSI_I()
        {
            Gard_AniData_IdleSitting.Gard_AniData_IdleSittingI();
        }
    }
}