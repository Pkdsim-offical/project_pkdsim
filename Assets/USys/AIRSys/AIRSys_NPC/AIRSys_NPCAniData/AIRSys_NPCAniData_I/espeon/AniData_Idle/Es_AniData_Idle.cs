
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Es_AniData.AniData_Idle.AniData_IdleSitting;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Es_AniData.AniData_Idle.AniData_IdleStanding;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Es_AniData.AniData_Idle
{
    public class Es_AniData_Idle
    {
        private Es_AniData_IdleSI Es_AniData_IdleSitting;
        private Es_AniData_IdleST Es_AniData_IdleStanding;
        public void Es_AniData_IdleST_I()
        {
            Es_AniData_IdleStanding.Es_AniData_IdleStandingI();
        }
        public void Es_AniData_IdleSI_I()
        {
            Es_AniData_IdleSitting.Es_AniData_IdleSittingI();
        }
    }
}