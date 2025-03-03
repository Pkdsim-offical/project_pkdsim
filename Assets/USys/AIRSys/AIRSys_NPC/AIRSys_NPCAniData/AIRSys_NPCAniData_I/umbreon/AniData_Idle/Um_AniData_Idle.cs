
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Um_AniData.AniData_Idle.AniData_IdleSitting;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Um_AniData.AniData_Idle.AniData_IdleStanding;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Um_AniData.AniData_Idle
{
    public class Um_AniData_Idle
    {
        private Um_AniData_IdleSI Um_AniData_IdleSitting;
        private Um_AniData_IdleST Um_AniData_IdleStanding;
        public void Um_AniData_IdleST_I()
        {
            Um_AniData_IdleStanding.Um_AniData_IdleStanding();
        }
        public void Um_AniData_IdleSI_I()
        {
            Um_AniData_IdleSitting.Um_AniData_IdleSitting();
        }
    }
}