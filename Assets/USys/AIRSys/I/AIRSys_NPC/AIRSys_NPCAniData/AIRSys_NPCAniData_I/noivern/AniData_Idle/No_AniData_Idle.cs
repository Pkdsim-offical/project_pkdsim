
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.No_AniData.AniData_Idle.AniData_IdleSitting;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.No_AniData.AniData_Idle.AniData_IdleStanding;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.No_AniData.AniData_Idle
{
    public class No_AniData_Idle
    {
        private No_AniData_IdleSI No_AniData_IdleSitting;
        private No_AniData_IdleST No_AniData_IdleStanding;
        public void No_AniData_IdleST_I()
        {
            No_AniData_IdleStanding.No_AniData_IdleStandingI();
        }
        public void No_AniData_IdleSI_I()
        {
            No_AniData_IdleSitting.No_AniData_IdleSittingI();
        }
    }
}