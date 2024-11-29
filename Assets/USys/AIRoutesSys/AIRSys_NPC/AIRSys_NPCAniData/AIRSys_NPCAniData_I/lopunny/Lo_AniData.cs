using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Lo_AniData.AniData_Idle;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Lo_AniData.AniData_Transitions;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.Lo_AniData {
        public class Lo_AniData
        {
                private Lo_AniData_Transition Lo_AniData_Transitions;
                private Lo_AniData_Idle Lo_AniData_Idle;
                public void Load_Lo_AnimationData()
                {
                        Load_LoAniData_Idle();
                        Load_LoAniData_Transition();
                }
                public void Load_LoAniData_Idle() {
                        Lo_AniData_Idle.Lo_AniData_IdleST_I();
                        Lo_AniData_Idle.Lo_AniData_IdleSI_I();
                }
                public void Load_LoAniData_Transition() {
                        Lo_AniData_Transitions.Lo_AniData_SI2ST_I();
                        Lo_AniData_Transitions.Lo_AniData_ST2SI_I();
                }
        }
}