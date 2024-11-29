
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Dr_AniData.AniData_Idle.AniData_IdleSitting;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Dr_AniData.AniData_Idle.AniData_IdleStanding;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Dr_AniData.AniData_Idle
{
    public class Dr_AniData_Idle
    {
        private Dr_AniData_IdleSI Dr_AniData_IdleSitting;
        private Dr_AniData_IdleST Dr_AniData_IdleStanding;
        public void Dr_AniData_IdleST_I()
        {
            Dr_AniData_IdleStanding.Dr_AniData_IdleStandingI();
        }
        public void Dr_AniData_IdleSI_I()
        {
            Dr_AniData_IdleSitting.Dr_AniData_IdleSittingI();
        }
    }
}