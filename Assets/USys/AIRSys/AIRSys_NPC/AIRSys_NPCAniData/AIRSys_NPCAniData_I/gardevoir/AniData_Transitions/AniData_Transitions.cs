
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Gard_AniData.AniData_Transitions.AniData_SI2ST;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Gard_AniData.AniData_Transitions.AniData_ST2SI;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Gard_AniData.AniData_Transitions
{
    public class Gard_AniData_Transition
    {
        private Gard_AniData_Sitting2Standing Gard_AniData_SI2ST;
        private Gard_AniData_Standing2Sitting Gard_AniData_ST2SI;

        public void Gard_AniData_SI2ST_I()
        {
            Gard_AniData_SI2ST.Gard_AniData_Sitting2StandingI();
        }

        public void Gard_AniData_ST2SI_I()
        {
            Gard_AniData_ST2SI.Gard_AniData_Standing2SittingI();
        }
    }
}