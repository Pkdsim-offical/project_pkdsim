
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Br_AniData.AniData_Transitions.AniData_SI2ST;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Br_AniData.AniData_Transitions.AniData_ST2SI;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Br_AniData.AniData_Transitions
{
    public class Br_AniData_Transition
    {
        private Br_AniData_Sitting2Standing Br_AniData_SI2ST;
        private Br_AniData_Standing2Sitting Br_AniData_ST2SI;

        public void Br_AniData_SI2ST_I()
        {
            Br_AniData_SI2ST.Br_AniData_Sitting2StandingI();
        }

        public void Br_AniData_ST2SI_I()
        {
            Br_AniData_ST2SI.Br_AniData_Standing2SittingI();
        }
    }
}