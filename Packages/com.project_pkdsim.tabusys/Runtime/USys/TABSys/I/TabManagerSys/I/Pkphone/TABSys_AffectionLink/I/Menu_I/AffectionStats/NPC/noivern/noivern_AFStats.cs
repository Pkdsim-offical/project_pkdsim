using project_pkdsim.USys.LOSys.Modules.LoveSys.Modules.LoveScripts.Modules.NPC.I_data.Noivern;
using project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Base;

namespace project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Noivern
{
    public class Noivern_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Noivern_LL Noivern_LL;
        public HeartBarUI heartBarUI;
        public void Noivern_AFStatsI()
        {
            Noivern_LL.Noivern_LLI();
            int activeLevels = Noivern_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);
        }
    }
}