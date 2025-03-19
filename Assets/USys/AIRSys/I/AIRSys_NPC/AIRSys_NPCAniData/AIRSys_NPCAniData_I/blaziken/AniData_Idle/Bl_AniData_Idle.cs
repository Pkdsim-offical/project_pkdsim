
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Bl_AniData.AniData_Idle.AniData_IdleSitting;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Bl_AniData.AniData_Idle.AniData_IdleStanding;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Bl_AniData.AniData_Idle
{
    public class Bl_AniData_Idle
    {
        private Bl_AniData_IdleSI Bl_AniData_IdleSitting;
        private Bl_AniData_IdleST Bl_AniData_IdleStanding;
        public void Bl_AniData_IdleST_I()
        {
            Bl_AniData_IdleStanding.Bl_AniData_IdleStandingI();
        }
        public void Bl_AniData_IdleSI_I()
        {
            Bl_AniData_IdleSitting.Bl_AniData_IdleSittingI();
        }
    }
}