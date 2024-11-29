using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Ha_AniData.AniData_Idle;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Ha_AniData.AniData_Transitions;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.Ha_AniData {
        public class Ha_AniData
        {
                private Ha_AniData_Transition Ha_AniData_Transitions;
                private Ha_AniData_Idle Ha_AniData_Idle;
                public void Load_Ha_AnimationData()
                {
                        Load_HaAniData_Idle();
                        Load_HaAniData_Transition();
                }
                public void Load_HaAniData_Idle() {
                        Ha_AniData_Idle.Ha_AniData_IdleST_I();
                        Ha_AniData_Idle.Ha_AniData_IdleSI_I();
                }
                public void Load_HaAniData_Transition() {
                        Ha_AniData_Transitions.Ha_AniData_SI2ST_I();
                        Ha_AniData_Transitions.Ha_AniData_ST2SI_I();
                }
        }
}
