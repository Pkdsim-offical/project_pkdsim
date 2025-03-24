
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Jo_AniData.AniData_Transitions.AniData_SI2ST;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Jo_AniData.AniData_Transitions.AniData_ST2SI;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Jo_AniData.AniData_Transitions
{
    public class Jo_AniData_Transition
    {
        private Jo_AniData_Sitting2Standing Jo_AniData_SI2ST;
        private Jo_AniData_Standing2Sitting Jo_AniData_ST2SI;

        public void Jo_AniData_SI2ST_I()
        {
            Jo_AniData_SI2ST.Jo_AniData_Sitting2StandingI();
        }

        public void Jo_AniData_ST2SI_I()
        {
            Jo_AniData_ST2SI.Jo_AniData_Standing2SittingI();
        }
    }
}