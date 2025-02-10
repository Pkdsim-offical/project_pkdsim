
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Le_AniData.AniData_Transitions.AniData_SI2ST;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Le_AniData.AniData_Transitions.AniData_ST2SI;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Le_AniData.AniData_Transitions
{
    public class Le_AniData_Transition
    {
        private Le_AniData_Sitting2Standing Le_AniData_SI2ST;
        private Le_AniData_Standing2Sitting Le_AniData_ST2SI;

        public void Le_AniData_SI2ST_I()
        {
            Le_AniData_SI2ST.Le_AniData_Sitting2StandingI();
        }

        public void Le_AniData_ST2SI_I()
        {
            Le_AniData_ST2SI.Le_AniData_Standing2SittingI();
        }
    }
}