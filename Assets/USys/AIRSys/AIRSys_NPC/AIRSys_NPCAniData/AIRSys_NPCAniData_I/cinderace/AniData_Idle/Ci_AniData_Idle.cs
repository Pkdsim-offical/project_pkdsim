
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Cl_AniData.AniData_Idle.AniData_IdleSitting;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Cl_AniData.AniData_Idle.AniData_IdleStanding;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Cl_AniData.AniData_Idle
{
    public class Cl_AniData_Idle
    {
        private Cl_AniData_IdleSI Cl_AniData_IdleSitting;
        private Cl_AniData_IdleST Cl_AniData_IdleStanding;
        public void Cl_AniData_IdleST_I()
        {
            Cl_AniData_IdleStanding.Cl_AniData_IdleStanding();
        }
        public void Cl_AniData_IdleSI_I()
        {
            Cl_AniData_IdleSitting.Cl_AniData_IdleSitting();
        }
    }
}