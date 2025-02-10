
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Bl_AniData.AniData_Transitions.AniData_SI2ST;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Bl_AniData.AniData_Transitions.AniData_ST2SI;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Bl_AniData.AniData_Transitions
{
    public class Bl_AniData_Transition
    {
        private Bl_AniData_Sitting2Standing Bl_AniData_SI2ST;
        private Bl_AniData_Standing2Sitting Bl_AniData_ST2SI;

        public void Bl_AniData_SI2ST_I()
        {
            Bl_AniData_SI2ST.Bl_AniData_Sitting2StandingI();
        }

        public void Bl_AniData_ST2SI_I()
        {
            Bl_AniData_ST2SI.Bl_AniData_Standing2SittingI();
        }
    }
}