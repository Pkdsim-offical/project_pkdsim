using project_pkdsim.USys.LOSys.Modules.LoveSys.Modules.LoveScripts.Modules.NPC.I_data.Vaporeon;
using project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Base;

namespace project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Vaporeon
{
    public class Vaporeon_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Vaporeon_LL Vaporeon_LL;
        public HeartBarUI heartBarUI;
        public void Vaporeon_AFStatsI()
        {
            Vaporeon_LL.Vaporeon_LLI();
            int activeLevels = Vaporeon_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);
        }
    }
}