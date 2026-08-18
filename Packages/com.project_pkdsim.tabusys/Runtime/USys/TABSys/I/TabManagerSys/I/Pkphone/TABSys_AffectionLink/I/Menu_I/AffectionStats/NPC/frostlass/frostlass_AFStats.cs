using project_pkdsim.USys.LOSys.Modules.LoveSys.Modules.LoveScripts.Modules.NPC.I_data.Frostlass;
using project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Base;

namespace project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Frostlass
{
    public class Frostlass_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Frostlass_LL Frostlass_LL;
        public HeartBarUI heartBarUI;
        public void Frostlass_AFStatsI()
        {
            Frostlass_LL.Frostlass_LLI();
            int activeLevels = Frostlass_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);
        }
    }
}