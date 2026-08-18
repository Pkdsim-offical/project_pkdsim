using project_pkdsim.USys.LOSys.Modules.LoveSys.Modules.LoveScripts.Modules.NPC.I_data.Espeon;
using project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Base;

namespace project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Espeon
{
    public class Espeon_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Espeon_LL Espeon_LL;
        public HeartBarUI heartBarUI;
        public void Espeon_AFStatsI()
        {
            Espeon_LL.Espeon_LLI();
            int activeLevels = Espeon_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);
        }
    }
}