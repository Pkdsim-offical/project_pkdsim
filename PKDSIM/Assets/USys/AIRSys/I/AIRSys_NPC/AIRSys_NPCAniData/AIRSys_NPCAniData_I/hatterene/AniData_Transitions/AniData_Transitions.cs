
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Ha_AniData.AniData_Transitions.AniData_SI2ST;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Ha_AniData.AniData_Transitions.AniData_ST2SI;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Ha_AniData.AniData_Transitions
{
    public class Ha_AniData_Transition
    {
        private Ha_AniData_Sitting2Standing Ha_AniData_SI2ST;
        private Ha_AniData_Standing2Sitting Ha_AniData_ST2SI;

        public void Ha_AniData_SI2ST_I()
        {
            Ha_AniData_SI2ST.Ha_AniData_Sitting2StandingI();
        }

        public void Ha_AniData_ST2SI_I()
        {
            Ha_AniData_ST2SI.Ha_AniData_Standing2SittingI();
        }
    }
}