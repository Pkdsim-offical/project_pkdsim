
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.No_AniData.AniData_Transitions.AniData_SI2ST;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.No_AniData.AniData_Transitions.AniData_ST2SI;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.No_AniData.AniData_Transitions
{
    public class No_AniData_Transition
    {
        private No_AniData_Sitting2Standing No_AniData_SI2ST;
        private No_AniData_Standing2Sitting No_AniData_ST2SI;

        public void No_AniData_SI2ST_I()
        {
            No_AniData_SI2ST.No_AniData_Sitting2StandingI();
        }

        public void No_AniData_ST2SI_I()
        {
            No_AniData_ST2SI.No_AniData_Standing2SittingI();
        }
    }
}