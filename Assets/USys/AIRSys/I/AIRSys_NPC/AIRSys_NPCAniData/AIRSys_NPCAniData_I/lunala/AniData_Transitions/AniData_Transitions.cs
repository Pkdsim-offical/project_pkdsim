
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Luna_AniData.AniData_Transitions.AniData_SI2ST;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Luna_AniData.AniData_Transitions.AniData_ST2SI;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Luna_AniData.AniData_Transitions
{
    public class Luna_AniData_Transition
    {
        private Luna_AniData_Sitting2Standing Luna_AniData_SI2ST;
        private Luna_AniData_Standing2Sitting Luna_AniData_ST2SI;

        public void Luna_AniData_SI2ST_I()
        {
            Luna_AniData_SI2ST.Luna_AniData_Sitting2StandingI();
        }

        public void Luna_AniData_ST2SI_I()
        {
            Luna_AniData_ST2SI.Luna_AniData_Standing2SittingI();
        }
    }
}