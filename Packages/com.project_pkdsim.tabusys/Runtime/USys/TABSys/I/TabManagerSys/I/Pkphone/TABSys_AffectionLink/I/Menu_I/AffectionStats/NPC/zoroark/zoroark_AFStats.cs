using project_pkdsim.USys.LOSys.Modules.LoveSys.Modules.LoveScripts.Modules.NPC.I_data.Zoroark;
using project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Base;

namespace project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Zoroark
{
    public class Zoroark_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Zoroark_LL Zoroark_LL;
        public HeartBarUI heartBarUI;
        public void Zoroark_AFStatsI()
        {
            Zoroark_LL.Zoroark_LLI();
            int activeLevels = Zoroark_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);
        }
    }
}