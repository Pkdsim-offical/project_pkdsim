
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Dr_AniData.AniData_Transitions.AniData_SI2ST;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Dr_AniData.AniData_Transitions.AniData_ST2SI;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Dr_AniData.AniData_Transitions
{
    public class Dr_AniData_Transition
    {
        private Dr_AniData_Sitting2Standing Dr_AniData_SI2ST;
        private Dr_AniData_Standing2Sitting Dr_AniData_ST2SI;

        public void Dr_AniData_SI2ST_I()
        {
            Dr_AniData_SI2ST.Dr_AniData_Sitting2StandingI();
        }

        public void Dr_AniData_ST2SI_I()
        {
            Dr_AniData_ST2SI.Dr_AniData_Standing2SittingI();
        }
    }
}