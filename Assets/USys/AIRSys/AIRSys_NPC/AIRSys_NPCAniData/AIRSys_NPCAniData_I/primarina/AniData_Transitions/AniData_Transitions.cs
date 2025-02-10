
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Pr_AniData.AniData_Transitions.AniData_SI2ST;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Pr_AniData.AniData_Transitions.AniData_ST2SI;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Pr_AniData.AniData_Transitions
{
    public class Pr_AniData_Transition
    {
        private Pr_AniData_Sitting2Standing Pr_AniData_SI2ST;
        private Pr_AniData_Standing2Sitting Pr_AniData_ST2SI;

        public void Pr_AniData_SI2ST_I()
        {
            Pr_AniData_SI2ST.Pr_AniData_Sitting2StandingI();
        }

        public void Pr_AniData_ST2SI_I()
        {
            Pr_AniData_ST2SI.Pr_AniData_Standing2SittingI();
        }
    }
}