
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Ab_AniData.AniData_Idle;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Ab_AniData.AniData_Transitions;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AB_AniData
{
    public class Ab_AniData
        {
        private Ab_AniData_Transition Ab_AniData_Transitions;
        private Ab_AniData_Idle Ab_AniData_Idle;
            public void Load_Ab_AnimationData()
            {
                    Load_AbAniData_Idle();
                    Load_AbAniData_Transition();
            }
        public void Load_AbAniData_Idle() {
            Ab_AniData_Idle.Ab_AniData_IdleST_I();
            Ab_AniData_Idle.Ab_AniData_IdleSI_I();
        }
        public void Load_AbAniData_Transition() {
            Ab_AniData_Transitions.Ab_AniData_SI2ST_I();
            Ab_AniData_Transitions.Ab_AniData_ST2SI_I();
        }
    }
}