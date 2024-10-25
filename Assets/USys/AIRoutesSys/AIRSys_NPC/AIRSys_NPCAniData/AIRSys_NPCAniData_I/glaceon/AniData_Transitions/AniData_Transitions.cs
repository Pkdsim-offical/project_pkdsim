

using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Gl_AniData.AniData_Transitions.AniData_SI2ST;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Gl_AniData.AniData_Transitions.AniData_ST2SI;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Gl_AniData.AniData_Transitions
{
    public class Gl_AniData_Transition
    {
        private Gl_AniData_Sitting2Standing Gl_AniData_SI2ST;
        private Gl_AniData_Standing2Sitting Gl_AniData_ST2SI;

        public void Gl_AniData_SI2ST_I()
        {
            Gl_AniData_SI2ST.Gl_AniData_Sitting2StandingI();
        }

        public void Gl_AniData_ST2SI_I()
        {
            Gl_AniData_ST2SI.Gl_AniData_Standing2SittingI();
        }
    }
}