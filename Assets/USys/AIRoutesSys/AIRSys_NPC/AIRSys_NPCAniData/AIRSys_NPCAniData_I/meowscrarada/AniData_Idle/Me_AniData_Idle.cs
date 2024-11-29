
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Me_AniData.AniData_Idle.AniData_IdleSitting;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Me_AniData.AniData_Idle.AniData_IdleStanding;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Me_AniData.AniData_Idle
{
    public class Me_AniData_Idle
    {
        private Me_AniData_IdleSI Me_AniData_IdleSitting;
        private Me_AniData_IdleST Me_AniData_IdleStanding;
        public void Me_AniData_IdleST_I()
        {
            Me_AniData_IdleStanding.Me_AniData_IdleStanding();
        }
        public void Me_AniData_IdleSI_I()
        {
            Me_AniData_IdleSitting.Me_AniData_IdleSitting();
        }
    }
}