
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Um_AniData.AniData_Transitions.AniData_SI2ST;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Um_AniData.AniData_Transitions.AniData_ST2SI;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Um_AniData.AniData_Transitions
{
    public class Um_AniData_Transition
    {
        private Um_AniData_Sitting2Standing Um_AniData_SI2ST;
        private Um_AniData_Standing2Sitting Um_AniData_ST2SI;

        public void Um_AniData_SI2ST_I()
        {
            Um_AniData_SI2ST.Um_AniData_Sitting2StandingI();
        }

        public void Um_AniData_ST2SI_I()
        {
            Um_AniData_ST2SI.Um_AniData_Standing2SittingI();
        }
    }
}