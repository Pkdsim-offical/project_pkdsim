using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Dl_AniData.AniData_Transitions.AniData_SI2ST;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Dl_AniData.AniData_Transitions.AniData_ST2SI;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Dl_AniData.AniData_Transitions
{
    public class Dl_AniData_Transition
    {
        private Dl_AniData_Sitting2Standing Dl_AniData_SI2ST;
        private Dl_AniData_Standing2Sitting Dl_AniData_ST2SI;

        public void Dl_AniData_SI2ST_I()
        {
            Dl_AniData_SI2ST.Dl_AniData_Sitting2StandingI();
        }

        public void Dl_AniData_ST2SI_I()
        {
            Dl_AniData_ST2SI.Dl_AniData_Standing2SittingI();
        }
    }
}