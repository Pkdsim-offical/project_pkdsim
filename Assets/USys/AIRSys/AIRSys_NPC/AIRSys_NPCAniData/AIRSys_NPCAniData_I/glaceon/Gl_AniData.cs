using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Gl_AniData.AniData_Idle;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Gl_AniData.AniData_Transitions;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.Gl_AniData
{
        public class Gl_AniData
        {
                private Gl_AniData_Transition Gl_AniData_Transitions;
                private Gl_AniData_Idle Gl_AniData_Idle;
                public void Load_Gl_AnimationData()
                {
                        Load_GlAniData_Idle();
                        Load_GlAniData_Transition();
                }
                public void Load_GlAniData_Idle() {
                        Gl_AniData_Idle.Gl_AniData_IdleST_I();
                        Gl_AniData_Idle.Gl_AniData_IdleSI_I();
                }
                public void Load_GlAniData_Transition() {
                        Gl_AniData_Transitions.Gl_AniData_SI2ST_I();
                        Gl_AniData_Transitions.Gl_AniData_ST2SI_I();
                }
        }
}