
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Ha_AniData.AniData_Idle.AniData_IdleSitting;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Ha_AniData.AniData_Idle.AniData_IdleStanding;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Ha_AniData.AniData_Idle
{
    public class Ha_AniData_Idle
    {
        private Ha_AniData_IdleSI Ha_AniData_IdleSitting;
        private Ha_AniData_IdleST Ha_AniData_IdleStanding;
        public void Ha_AniData_IdleST_I()
        {
            Ha_AniData_IdleStanding.Ha_AniData_IdleStandingI();
        }
        public void Ha_AniData_IdleSI_I()
        {
            Ha_AniData_IdleSitting.Ha_AniData_IdleSittingI();
        }
    }
}