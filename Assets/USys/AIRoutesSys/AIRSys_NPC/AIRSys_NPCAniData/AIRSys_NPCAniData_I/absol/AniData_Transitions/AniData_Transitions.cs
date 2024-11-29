
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Ab_AniData.AniData_Transitions.AniData_SI2ST;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Ab_AniData.AniData_Transitions.AniData_ST2SI;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Ab_AniData.AniData_Transitions
{
    public class Ab_AniData_Transition
    {
        private Ab_AniData_Sitting2Standing Ab_AniData_SI2ST;
        private Ab_AniData_Standing2Sitting Ab_AniData_ST2SI;

        public void Ab_AniData_SI2ST_I()
        {
            Ab_AniData_SI2ST.Ab_AniData_Sitting2StandingI();
        }

        public void Ab_AniData_ST2SI_I()
        {
            Ab_AniData_ST2SI.Ab_AniData_Standing2SittingI();
        }
    }
}