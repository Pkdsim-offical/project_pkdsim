
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Be_AniData.AniData_Transitions.AniData_SI2ST;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Be_AniData.AniData_Transitions.AniData_ST2SI;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Be_AniData.AniData_Transitions
{
    public class Be_AniData_Transition
    {
        private Be_AniData_Sitting2Standing Be_AniData_SI2ST;
        private Be_AniData_Standing2Sitting Be_AniData_ST2SI;

        public void Be_AniData_SI2ST_I()
        {
            Be_AniData_SI2ST.Be_AniData_Sitting2StandingI();
        }

        public void Be_AniData_ST2SI_I()
        {
            Be_AniData_ST2SI.Be_AniData_Standing2SittingI();
        }
    }
}