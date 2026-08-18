using project_pkdsim.USys.LOSys.Modules.LoveSys.Modules.LoveScripts.Modules.NPC.I_data.Umbreon;
using project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Base;

namespace project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Umbreon
{
    public class Umbreon_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Umbreon_LL Umbreon_LL;
        public HeartBarUI heartBarUI; 
        public void Umbreon_AFStatsI()
        {
            Umbreon_LL.Umbreon_LLI();
            int activeLevels = Umbreon_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);
        }
    }
}