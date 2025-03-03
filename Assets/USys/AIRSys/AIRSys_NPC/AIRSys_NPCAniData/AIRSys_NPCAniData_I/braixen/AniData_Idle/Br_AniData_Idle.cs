
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Br_AniData.AniData_Idle.AniData_IdleSitting;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Br_AniData.AniData_Idle.AniData_IdleStanding;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Br_AniData.AniData_Idle
{
    public class Br_AniData_Idle
    {
        private Br_AniData_IdleSI Br_AniData_IdleSitting;
        private Br_AniData_IdleST Br_AniData_IdleStanding;
        public void Br_AniData_IdleST_I()
        {
            Br_AniData_IdleStanding.Br_AniData_IdleStandingI();
        }
        public void Br_AniData_IdleSI_I()
        {
            Br_AniData_IdleSitting.Br_AniData_IdleSittingI();
        }
    }
}