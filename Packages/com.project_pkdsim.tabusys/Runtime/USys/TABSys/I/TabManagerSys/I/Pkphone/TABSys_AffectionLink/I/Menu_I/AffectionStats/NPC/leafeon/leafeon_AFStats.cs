using project_pkdsim.USys.LOSys.Modules.LoveSys.Modules.LoveScripts.Modules.NPC.I_data.Leafeon;
using project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Base;

namespace project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Leafeon
{
    public class Leafeon_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Leafeon_LL Leafeon_LL;
        public HeartBarUI heartBarUI;
        public void Leafeon_AFStatsI()
        {
            Leafeon_LL.Leafeon_LLI();
            int activeLevels = Leafeon_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);
        }
    }
}