
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Ve_AniData.AniData_Idle.AniData_IdleSitting;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Ve_AniData.AniData_Idle.AniData_IdleStanding;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Ve_AniData.AniData_Idle
{
    public class Ve_AniData_Idle
    {
        private Ve_AniData_IdleSI Ve_AniData_IdleSitting;
        private Ve_AniData_IdleST Ve_AniData_IdleStanding;
        public void Ve_AniData_IdleST()
        {
            Ve_AniData_IdleStanding.Ve_AniData_IdleStanding();
        }
        public void Ve_AniData_IdleSI()
        {
            Ve_AniData_IdleSitting.Ve_AniData_IdleSitting();
        }
    }
}