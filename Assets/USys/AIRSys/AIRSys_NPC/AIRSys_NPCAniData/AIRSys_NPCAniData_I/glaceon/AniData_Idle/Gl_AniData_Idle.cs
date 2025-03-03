
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Gl_AniData.AniData_Idle.AniData_IdleSitting;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Gl_AniData.AniData_Idle.AniData_IdleStanding;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Gl_AniData.AniData_Idle
{
    public class Gl_AniData_Idle
    {
        private Gl_AniData_IdleSI Gl_AniData_IdleSitting;
        private Gl_AniData_IdleST Gl_AniData_IdleStanding;
        public void Gl_AniData_IdleST_I()
        {
            Gl_AniData_IdleStanding.Gl_AniData_IdleStanding();
        }
        public void Gl_AniData_IdleSI_I()
        {
            Gl_AniData_IdleSitting.Gl_AniData_IdleSitting();
        }
    }
}