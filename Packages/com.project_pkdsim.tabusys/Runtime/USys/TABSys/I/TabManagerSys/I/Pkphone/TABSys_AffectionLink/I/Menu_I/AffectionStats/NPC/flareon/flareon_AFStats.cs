using project_pkdsim.USys.LOSys.Modules.LoveSys.Modules.LoveScripts.Modules.NPC.I_data.Flareon;
using project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Base;

namespace project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Flareon
{
    public class Flareon_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Flareon_LL Flareon_LL;
        public HeartBarUI heartBarUI;
        public void Flareon_AFStatsI()
        {
            Flareon_LL.Flareon_LLI();
            int activeLevels = Flareon_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);
        }
    }
}