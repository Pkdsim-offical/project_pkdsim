
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Me_AniData.AniData_Transitions.AniData_SI2ST;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Me_AniData.AniData_Transitions.AniData_ST2SI;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Me_AniData.AniData_Transitions
{
    public class Me_AniData_Transition
    {
        private Me_AniData_Sitting2Standing Me_AniData_SI2ST;
        private Me_AniData_Standing2Sitting Me_AniData_ST2SI;

        public void Me_AniData_SI2ST_I()
        {
            Me_AniData_SI2ST.Me_AniData_Sitting2StandingI();
        }

        public void Me_AniData_ST2SI_I()
        {
            Me_AniData_ST2SI.Me_AniData_Standing2SittingI();
        }
    }
}