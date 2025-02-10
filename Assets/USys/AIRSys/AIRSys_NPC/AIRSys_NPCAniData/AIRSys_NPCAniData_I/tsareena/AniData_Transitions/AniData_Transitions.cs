
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Ts_AniData.AniData_Transitions.AniData_SI2ST;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Ts_AniData.AniData_Transitions.AniData_ST2SI;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Ts_AniData.AniData_Transitions
{
    public class Ts_AniData_Transition
    {
        private Ts_AniData_Sitting2Standing Ts_AniData_SI2ST;
        private Ts_AniData_Standing2Sitting Ts_AniData_ST2SI;

        public void Ts_AniData_SI2ST_I()
        {
            Ts_AniData_SI2ST.Ts_AniData_Sitting2StandingI();
        }

        public void Ts_AniData_ST2SI_I()
        {
            Ts_AniData_ST2SI.Ts_AniData_Standing2SittingI();
        }
    }
}