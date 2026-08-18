using project_pkdsim.USys.LOSys.Modules.LoveSys.Modules.LoveScripts.Modules.NPC.I_data.Lopunny;
using project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Base;

namespace project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Lopunny
{
    public class Lopunny_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Lopunny_LL Lopunny_LL;
        public HeartBarUI heartBarUI;
        public void Lopunny_AFStatsI()
        {
            Lopunny_LL.Lopunny_LLI();
            int activeLevels = Lopunny_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);
        }
    }
}