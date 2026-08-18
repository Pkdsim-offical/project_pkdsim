
using project_pkdsim.USys.LOSys.Modules.LoveSys.Modules.LoveScripts.Modules.NPC.I_data.Garchomp;
using project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Base;

namespace project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Garchomp
{
    public class Garchomp_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Garchomp_LL Garchomp_LL;
        public HeartBarUI heartBarUI;
        public void Garchomp_AFStatsI()
        {
            Garchomp_LL.Garchomp_LLI();
            int activeLevels = Garchomp_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);

        }
    }
}