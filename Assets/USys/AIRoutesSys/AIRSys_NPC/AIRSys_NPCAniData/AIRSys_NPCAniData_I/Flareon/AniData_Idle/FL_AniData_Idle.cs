
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Fl_AniData.AniData_Idle.AniData_IdleSitting;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Fl_AniData.AniData_Idle.AniData_IdleStanding;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Fl_AniData.AniData_Idle
{
    public class Fl_AniData_Idle
    {
        private Fl_AniData_IdleSI Fl_AniData_IdleSitting;
        private Fl_AniData_IdleST Fl_AniData_IdleStanding;
        public void Fl_AniData_IdleST_I()
        {
            Fl_AniData_IdleStanding.Fl_AniData_IdleStandingI();
        }
        public void Fl_AniData_IdleSI_I()
        {
            Fl_AniData_IdleSitting.Fl_AniData_IdleSittingI();
        }
    }
}