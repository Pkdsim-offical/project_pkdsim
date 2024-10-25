
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Fl_AniData.AniData_Idle;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Fl_AniData.AniData_Transitions;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.Fl_AniData
{
    public class Fl_AniData
    {
        private Fl_AniData_Transition Fl_AniData_Transitions;
        private Fl_AniData_Idle Fl_AniData_Idle;
            public void  Load_Fl_AnimationData()
            {
                    Load_FlAniData_Idle();
                    Load_FlAniData_Transition();
            }
        public void Load_FlAniData_Idle() {
            Fl_AniData_Idle.Fl_AniData_IdleST_I();
            Fl_AniData_Idle.Fl_AniData_IdleSI_I();
        }
        public void Load_FlAniData_Transition() {
            Fl_AniData_Transitions.Fl_AniData_SI2ST_I();
            Fl_AniData_Transitions.Fl_AniData_ST2SI_I();
        }
    }
}