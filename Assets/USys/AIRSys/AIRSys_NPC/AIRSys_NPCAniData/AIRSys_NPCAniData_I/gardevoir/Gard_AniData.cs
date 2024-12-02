using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Gard_AniData.AniData_Idle;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Gard_AniData.AniData_Transitions;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.Gard_AniData 
{
        public class Gard_AniData
        {
                private Gard_AniData_Transition Gard_AniData_Transitions;
                private Gard_AniData_Idle Gard_AniData_Idle;
                public void Load_Gard_AnimationData()
                {
                        Load_GardAniData_Idle();
                        Load_GardAniData_Transition();
                }
                public void Load_GardAniData_Idle() {
                        Gard_AniData_Idle.Gard_AniData_IdleST_I();
                        Gard_AniData_Idle.Gard_AniData_IdleSI_I();
                }
                public void Load_GardAniData_Transition() {
                        Gard_AniData_Transitions.Gard_AniData_SI2ST_I();
                        Gard_AniData_Transitions.Gard_AniData_ST2SI_I();
                }
        }
}