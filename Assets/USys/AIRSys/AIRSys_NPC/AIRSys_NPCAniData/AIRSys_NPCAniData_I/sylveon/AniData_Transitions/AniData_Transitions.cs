
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Sl_AniData.AniData_Transitions.AniData_SI2ST;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Sl_AniData.AniData_Transitions.AniData_ST2SI;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Sl_AniData.AniData_Transitions
{
    public class Sl_AniData_Transition
    {
        private Sl_AniData_Sitting2Standing Sl_AniData_SI2ST;
        private Sl_AniData_Standing2Sitting Sl_AniData_ST2SI;

        public void Sl_AniData_SI2ST_I()
        {
            Sl_AniData_SI2ST.Sl_AniData_Sitting2StandingI();
        }

        public void Sl_AniData_ST2SI_I()
        {
            Sl_AniData_ST2SI.Sl_AniData_Standing2SittingI();
        }
    }
}