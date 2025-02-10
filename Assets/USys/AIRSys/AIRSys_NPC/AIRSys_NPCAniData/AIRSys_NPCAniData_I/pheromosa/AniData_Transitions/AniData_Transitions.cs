
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Ph_AniData.AniData_Transitions.AniData_SI2ST;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Ph_AniData.AniData_Transitions.AniData_ST2SI;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Ph_AniData.AniData_Transitions
{
    public class Ph_AniData_Transition
    {
        private Ph_AniData_Sitting2Standing Ph_AniData_SI2ST;
        private Ph_AniData_Standing2Sitting Ph_AniData_ST2SI;

        public void Ph_AniData_SI2ST_I()
        {
            Ph_AniData_SI2ST.Ph_AniData_Sitting2StandingI();
        }

        public void Ph_AniData_ST2SI_I()
        {
            Ph_AniData_ST2SI.Ph_AniData_Standing2SittingI();
        }
    }
}