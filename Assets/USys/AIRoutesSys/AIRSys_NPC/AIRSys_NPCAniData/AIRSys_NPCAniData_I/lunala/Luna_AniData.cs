using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Luna_AniData.AniData_Idle;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Luna_AniData.AniData_Transitions;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.Luna_AniData {
        public class Luna_AniData
        {
                private Luna_AniData_Transition Luna_AniData_Transitions;
                private Luna_AniData_Idle Luna_AniData_Idle;
                public void Load_Luna_AnimationData()
                {
                        Load_LunaAniData_Idle();
                        Load_LunaAniData_Transition();
                }
                public void Load_LunaAniData_Idle() {
                        Luna_AniData_Idle.Luna_AniData_IdleST_I();
                        Luna_AniData_Idle.Luna_AniData_IdleSI_I();
                }
                public void Load_LunaAniData_Transition() {
                        Luna_AniData_Transitions.Luna_AniData_SI2ST_I();
                        Luna_AniData_Transitions.Luna_AniData_ST2SI_I();
                }
        }
}
