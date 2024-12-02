
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Be_AniData.AniData_Idle;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Be_AniData.AniData_Transitions;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.Be_AniData
{
    public class Be_AniData
    {
        private Be_AniData_Transition Be_AniData_Transitions;
        private Be_AniData_Idle Be_AniData_Idle;
                public void Load_Be_AnimationData()
            {
                    Load_BeAniData_Idle();
                    Load_BeAniData_Transition();
            }
        public void Load_BeAniData_Idle() {
            Be_AniData_Idle.Be_AniData_IdleST();
            Be_AniData_Idle.Be_AniData_IdleSI();
        }
        public void Load_BeAniData_Transition() {
            Be_AniData_Transitions.Be_AniData_ST2SI_I();
            Be_AniData_Transitions.Be_AniData_SI2ST_I();
        }
    }
}
