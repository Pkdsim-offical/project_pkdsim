using project_pkdsim.USys.LOSys.Modules.LoveSys.Modules.LoveScripts.Modules.NPC.I_data.Jolteon;
using project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Base;

namespace project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Jolteon
{
    public class Jolteon_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Jolteon_LL Jolteon_LL;
        public HeartBarUI heartBarUI;
        public void Jolteon_AFStatsI()
        {
            Jolteon_LL.Jolteon_LLI();
            int activeLevels = Jolteon_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);

        }
    }
}