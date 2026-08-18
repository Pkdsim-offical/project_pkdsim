using project_pkdsim.USys.LOSys.Modules.LoveSys.Modules.LoveScripts.Modules.NPC.I_data.Beedrill;
using project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Base;

namespace project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Beedrill
{
    public class Beedrill_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Beedrill_LL Beedrill_LL;
        public HeartBarUI heartBarUI;
        public void Beedrill_AFStatsI()
        {
            Beedrill_LL.Beedrill_LLI();
            int activeLevels = Beedrill_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);
        }
    }
}