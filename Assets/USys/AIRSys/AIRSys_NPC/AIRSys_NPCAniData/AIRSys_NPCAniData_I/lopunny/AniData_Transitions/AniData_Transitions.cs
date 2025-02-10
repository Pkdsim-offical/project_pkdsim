
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Lo_AniData.AniData_Transitions.AniData_SI2ST;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Lo_AniData.AniData_Transitions.AniData_ST2SI;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Lo_AniData.AniData_Transitions
{
    public class Lo_AniData_Transition
    {
        private Lo_AniData_Sitting2Standing Lo_AniData_SI2ST;
        private Lo_AniData_Standing2Sitting Lo_AniData_ST2SI;

        public void Lo_AniData_SI2ST_I()
        {
            Lo_AniData_SI2ST.Lo_AniData_Sitting2StandingI();
        }

        public void Lo_AniData_ST2SI_I()
        {
            Lo_AniData_ST2SI.Lo_AniData_Standing2SittingI();
        }
    }
}