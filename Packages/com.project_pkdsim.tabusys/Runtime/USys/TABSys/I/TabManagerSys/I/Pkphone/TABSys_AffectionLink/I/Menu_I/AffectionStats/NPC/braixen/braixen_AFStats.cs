using project_pkdsim.USys.LOSys.Modules.LoveSys.Modules.LoveScripts.Modules.NPC.I_data.Braixen;
using project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Base;

namespace project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Braixen
{
    public class Braixen_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Braixen_LL Braixen_LL;
        public HeartBarUI heartBarUI;
        public void Braixen_AFStatsI()
        {
            Braixen_LL.Braixen_LLI();
            int activeLevels = Braixen_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);
        }
    }
}