
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Bl_AniData.AniData_Idle;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Bl_AniData.AniData_Transitions;


namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.Bl_AniData
{
    public class Bl_AniData
    {
        private Bl_AniData_Transition Bl_AniData_Transitions;
        private Bl_AniData_Idle Bl_AniData_Idle;

        public void Load_Bl_AnimationData()
        {
            
        }
        public void Load_BlAniData_Idle() {
            Bl_AniData_Idle.Bl_AniData_IdleST_I();
            Bl_AniData_Idle.Bl_AniData_IdleSI_I();
        }
        public void Load_BlAniData_Transition() {
            Bl_AniData_Transitions.Bl_AniData_SI2ST_I();
            Bl_AniData_Transitions.Bl_AniData_ST2SI_I();
        }
    }
}