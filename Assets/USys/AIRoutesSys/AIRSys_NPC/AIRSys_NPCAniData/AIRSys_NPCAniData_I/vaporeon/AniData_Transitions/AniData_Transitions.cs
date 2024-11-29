
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Vp_AniData.AniData_Transitions.AniData_SI2ST;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Vp_AniData.AniData_Transitions.AniData_ST2SI;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Vp_AniData.AniData_Transitions
{
    public class Vp_AniData_Transition
    {
        private Vp_AniData_Sitting2Standing Vp_AniData_SI2ST;
        private Vp_AniData_Standing2Sitting Vp_AniData_ST2SI;

        public void Vp_AniData_SI2ST_I()
        {
            Vp_AniData_SI2ST.Vp_AniData_Sitting2StandingI();
        }

        public void Vp_AniData_ST2SI_I()
        {
            Vp_AniData_ST2SI.Vp_AniData_Standing2SittingI();
        }
    }
}