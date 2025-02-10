
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Zo_AniData.AniData_Idle;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Zo_AniData.AniData_Transitions;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.Zo_AniData
{
    public class Zo_AniData
    {
        private Zo_AniData_Transition Zo_AniData_Transitions;
        private Zo_AniData_Idle Zo_AniData_Idle;
        public void Load_Zo_AnimationData()
            {
                    Load_ZoAniData_Idle();
                    Load_ZoAniData_Transition();
            }
            public void Load_ZoAniData_Idle() {
                Zo_AniData_Idle.Zo_AniData_IdleST_I();
                Zo_AniData_Idle.Zo_AniData_IdleSI_I();
            }
            public void Load_ZoAniData_Transition() {
                Zo_AniData_Transitions.Zo_AniData_SI2ST_I();
                Zo_AniData_Transitions.Zo_AniData_ST2SI_I();
            }
    }
}