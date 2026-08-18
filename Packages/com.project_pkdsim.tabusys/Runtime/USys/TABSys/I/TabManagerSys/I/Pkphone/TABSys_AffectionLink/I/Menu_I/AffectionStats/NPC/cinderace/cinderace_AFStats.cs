using project_pkdsim.USys.LOSys.Modules.LoveSys.Modules.LoveScripts.Modules.NPC.I_data.Cinderace;
using project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Base;

namespace project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Cinderace
{
    public class Cinderace_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Cinderace_LL Cinderace_LL;
        public HeartBarUI heartBarUI;
        public void Cinderace_AFStatsI()
        {
            Cinderace_LL.Cinderace_LLI();
            int activeLevels = Cinderace_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);
        }
    }
}