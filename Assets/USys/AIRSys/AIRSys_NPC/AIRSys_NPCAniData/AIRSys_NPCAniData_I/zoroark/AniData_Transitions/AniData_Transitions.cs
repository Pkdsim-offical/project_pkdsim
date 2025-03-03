
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Zo_AniData.AniData_Transitions.AniData_SI2ST;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Zo_AniData.AniData_Transitions.AniData_ST2SI;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Zo_AniData.AniData_Transitions
{
    public class Zo_AniData_Transition
    {
        private Zo_AniData_Sitting2Standing Zo_AniData_SI2ST;
        private Zo_AniData_Standing2Sitting Zo_AniData_ST2SI;

        public void Zo_AniData_SI2ST_I()
        {
            Zo_AniData_SI2ST.Zo_AniData_Sitting2StandingI();
        }

        public void Zo_AniData_ST2SI_I()
        {
            Zo_AniData_ST2SI.Zo_AniData_Standing2SittingI();
        }
    }
}