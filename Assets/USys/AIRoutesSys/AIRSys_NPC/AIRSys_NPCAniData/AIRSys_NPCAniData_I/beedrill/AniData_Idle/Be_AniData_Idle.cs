
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Be_AniData.AniData_Idle.AniData_IdleSitting;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Be_AniData.AniData_Idle.AniData_IdleStanding;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Be_AniData.AniData_Idle
{
    public class Be_AniData_Idle
    {
        private Be_AniData_IdleSI Be_AniData_IdleSitting;
        private Be_AniData_IdleST Be_AniData_IdleStanding;
        public void Be_AniData_IdleST()
        {
            Be_AniData_IdleStanding.Be_AniData_IdleStanding();
        }
        public void Be_AniData_IdleSI()
        {
            Be_AniData_IdleSitting.Be_AniData_IdleSitting();
        }
    }
}