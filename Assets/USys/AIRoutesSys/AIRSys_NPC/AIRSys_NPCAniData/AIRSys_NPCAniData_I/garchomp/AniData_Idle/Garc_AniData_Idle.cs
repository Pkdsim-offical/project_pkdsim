
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Garc_AniData.AniData_Idle.AniData_IdleSitting;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Garc_AniData.AniData_Idle.AniData_IdleStanding;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Garc_AniData.AniData_Idle
{
    public class Garc_AniData_Idle
    {
        private Garc_AniData_IdleSI Garc_AniData_IdleSitting;
        private Garc_AniData_IdleST Garc_AniData_IdleStanding;
        public void Garc_AniData_IdleST_I()
        {
            Garc_AniData_IdleStanding.Garc_AniData_IdleStandingI();
        }
        public void Garc_AniData_IdleSI_I()
        {
            Garc_AniData_IdleSitting.Garc_AniData_IdleSittingI();
        }
    }
}