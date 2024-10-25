
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Vp_AniData.AniData_Idle.AniData_IdleSitting;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Vp_AniData.AniData_Idle.AniData_IdleStanding;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Vp_AniData.AniData_Idle
{
    public class Vp_AniData_Idle
    {
        private Vp_AniData_IdleSI Vp_AniData_IdleSitting;
        private Vp_AniData_IdleST Vp_AniData_IdleStanding;
        public void Vp_AniData_IdleST_I()
        {
            Vp_AniData_IdleStanding.Vp_AniData_IdleStanding();
        }
        public void Vp_AniData_IdleSI_I()
        {
            Vp_AniData_IdleSitting.Vp_AniData_IdleSitting();
        }
    }
}