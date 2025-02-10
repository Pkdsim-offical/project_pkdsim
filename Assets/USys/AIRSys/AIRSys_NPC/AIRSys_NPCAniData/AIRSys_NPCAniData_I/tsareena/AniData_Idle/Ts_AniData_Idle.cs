
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Ts_AniData.AniData_Idle.AniData_IdleSitting;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Ts_AniData.AniData_Idle.AniData_IdleStanding;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Ts_AniData.AniData_Idle
{
    public class Ts_AniData_Idle
    {
        private Ts_AniData_IdleSI Ts_AniData_IdleSitting;
        private Ts_AniData_IdleST Ts_AniData_IdleStanding;
        public void Ts_AniData_IdleST_I()
        {
            Ts_AniData_IdleStanding.Ts_AniData_IdleStandingI();
        }
        public void Ts_AniData_IdleSI_I()
        {
            Ts_AniData_IdleSitting.Ts_AniData_IdleSittingI();
        }
    }
}