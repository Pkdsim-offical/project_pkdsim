using project_pkdsim.USys.LOSys.Modules.LoveSys.Modules.LoveScripts.Modules.NPC.I_data.Blaziken;
using project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Base;

namespace project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Blaziken
{
    public class Blaziken_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Blaziken_LL Blaziken_LL;
        public HeartBarUI heartBarUI;
        public void Blaziken_AFStatsI()
        {
            Blaziken_LL.Blaziken_LLI();
            int activeLevels = Blaziken_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);
        }
    }
}