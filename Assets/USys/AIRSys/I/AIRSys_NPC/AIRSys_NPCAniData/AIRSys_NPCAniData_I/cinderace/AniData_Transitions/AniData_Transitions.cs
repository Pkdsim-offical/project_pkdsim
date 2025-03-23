
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Cl_AniData.AniData_Transitions.AniData_SI2ST;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Cl_AniData.AniData_Transitions.AniData_ST2SI;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Cl_AniData.AniData_Transitions
{
    public class Cl_AniData_Transition
    {
        private Cl_AniData_Sitting2Standing Cl_AniData_SI2ST;
        private Cl_AniData_Standing2Sitting Cl_AniData_ST2SI;

        public void Cl_AniData_SI2ST_I()
        {
            Cl_AniData_SI2ST.Cl_AniData_Sitting2StandingI();
        }

        public void Cl_AniData_ST2SI_I()
        {
            Cl_AniData_ST2SI.Cl_AniData_Standing2SittingI();
        }
    }
}