
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Es_AniData.AniData_Transitions.AniData_SI2ST;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Es_AniData.AniData_Transitions.AniData_ST2SI;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Es_AniData.AniData_Transitions
{
    public class Es_AniData_Transition
    {
        private Es_AniData_Sitting2Standing Es_AniData_SI2ST;
        private Es_AniData_Standing2Sitting Es_AniData_ST2SI;

        public void Es_AniData_SI2ST_I()
        {
            Es_AniData_SI2ST.Es_AniData_Sitting2StandingI();
        }

        public void Es_AniData_ST2SI_I()
        {
            Es_AniData_ST2SI.Es_AniData_Standing2SittingI();
        }
    }
}