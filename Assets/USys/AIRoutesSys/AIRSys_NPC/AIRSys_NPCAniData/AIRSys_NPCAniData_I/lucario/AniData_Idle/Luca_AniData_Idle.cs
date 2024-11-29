
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Luca_AniData.AniData_Idle.AniData_IdleSitting;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Luca_AniData.AniData_Idle.AniData_IdleStanding;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Luca_AniData.AniData_Idle
{
    public class Luca_AniData_Idle
    {
        private Luca_AniData_IdleSI Luca_AniData_IdleSitting;
        private Luca_AniData_IdleST Luca_AniData_IdleStanding;
        public void Luca_AniData_IdleST_I()
        {
            Luca_AniData_IdleStanding.Luca_AniData_IdleStandingI();
        }
        public void Luca_AniData_IdleSI_I()
        {
            Luca_AniData_IdleSitting.Luca_AniData_IdleSittingI();
        }
    }
}