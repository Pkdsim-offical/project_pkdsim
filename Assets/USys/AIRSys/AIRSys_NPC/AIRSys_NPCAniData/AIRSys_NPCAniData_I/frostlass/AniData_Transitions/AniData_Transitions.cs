
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Fr_AniData.AniData_Transitions.AniData_SI2ST;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Fr_AniData.AniData_Transitions.AniData_ST2SI;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Fr_AniData.AniData_Transitions
{
    public class Fr_AniData_Transition
    {
        private Fr_AniData_Sitting2Standing Fr_AniData_SI2ST;
        private Fr_AniData_Standing2Sitting Fr_AniData_ST2SI;

        public void Fr_AniData_SI2ST_I()
        {
            Fr_AniData_SI2ST.Fr_AniData_Sitting2StandingI();
        }

        public void Fr_AniData_ST2SI_I()
        {
            Fr_AniData_ST2SI.Fr_AniData_Standing2SittingI();
        }
    }
}