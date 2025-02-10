
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Luca_AniData.AniData_Transitions.AniData_SI2ST;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Luca_AniData.AniData_Transitions.AniData_ST2SI;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Luca_AniData.AniData_Transitions
{
    public class Luca_AniData_Transition
    {
        private Luca_AniData_Sitting2Standing Luca_AniData_SI2ST;
        private Luca_AniData_Standing2Sitting Luca_AniData_ST2SI;

        public void Luca_AniData_SI2ST_I()
        {
            Luca_AniData_SI2ST.Luca_AniData_Sitting2StandingI();
        }

        public void Luca_AniData_ST2SI_I()
        {
            Luca_AniData_ST2SI.Luca_AniData_Standing2SittingI();
        }
    }
}