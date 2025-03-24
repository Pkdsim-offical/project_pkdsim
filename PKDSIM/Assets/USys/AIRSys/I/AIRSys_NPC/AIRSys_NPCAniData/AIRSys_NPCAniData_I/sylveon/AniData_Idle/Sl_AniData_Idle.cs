
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Sl_AniData.AniData_Idle.AniData_IdleSitting;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Sl_AniData.AniData_Idle.AniData_IdleStanding;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Sl_AniData.AniData_Idle
{
    public class Sl_AniData_Idle
    {
        private Sl_AniData_IdleSI Sl_AniData_IdleSitting;
        private Sl_AniData_IdleST Sl_AniData_IdleStanding;
        public void Sl_AniData_IdleST_I()
        {
            Sl_AniData_IdleStanding.Sl_AniData_IdleStandingI();
        }
        public void Sl_AniData_IdleSI_I()
        {
            Sl_AniData_IdleSitting.Sl_AniData_IdleSittingI();
        }
    }
}