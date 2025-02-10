using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Luca_AniData.AniData_Idle;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Luca_AniData.AniData_Transitions;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.Luca_AniData {
        public class Luca_AniData
        {
                private Luca_AniData_Transition Luca_AniData_Transitions;
                private Luca_AniData_Idle Luca_AniData_Idle;
                public void Load_Luca_AnimationData()
                {
                        Load_LucaAniData_Idle();
                        Load_LucaAniData_Transition();
                }
                public void Load_LucaAniData_Idle() {
                        Luca_AniData_Idle.Luca_AniData_IdleST_I();
                        Luca_AniData_Idle.Luca_AniData_IdleSI_I();
                }
                public void Load_LucaAniData_Transition() {
                        Luca_AniData_Transitions.Luca_AniData_SI2ST_I();
                        Luca_AniData_Transitions.Luca_AniData_ST2SI_I();
                }
        }
}