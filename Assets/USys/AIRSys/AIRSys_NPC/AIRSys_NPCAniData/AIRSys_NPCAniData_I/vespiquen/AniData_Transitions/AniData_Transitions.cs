
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Ve_AniData.AniData_Transitions.AniData_SI2ST;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Ve_AniData.AniData_Transitions.AniData_ST2SI;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Ve_AniData.AniData_Transitions
{
    public class Ve_AniData_Transition
    {
        private Ve_AniData_Sitting2Standing Ve_AniData_SI2ST;
        private Ve_AniData_Standing2Sitting Ve_AniData_ST2SI;

        public void Ve_AniData_SI2ST_I()
        {
            Ve_AniData_SI2ST.Ve_AniData_Sitting2StandingI();
        }

        public void Ve_AniData_ST2SI_I()
        {
            Ve_AniData_ST2SI.Ve_AniData_Standing2SittingI();
        }
    }
}