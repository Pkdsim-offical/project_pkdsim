
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Sa_AniData.AniData_Transitions.AniData_SI2ST;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Sa_AniData.AniData_Transitions.AniData_ST2SI;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Sa_AniData.AniData_Transitions
{
    public class Sa_AniData_Transition
    {
        private Sa_AniData_Sitting2Standing Sa_AniData_SI2ST;
        private Sa_AniData_Standing2Sitting Sa_AniData_ST2SI;

        public void Sa_AniData_SI2ST_I()
        {
            Sa_AniData_SI2ST.Sa_AniData_Sitting2StandingI();
        }

        public void Sa_AniData_ST2SI_I()
        {
            Sa_AniData_ST2SI.Sa_AniData_Standing2SittingI();
        }
    }
}