using project_pkdsim.USys.LOSys.Modules.LoveSys.Modules.LoveScripts.Modules.NPC.I_data.Lunala;
using project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Base;

namespace project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Lunala
{
    public class Lunala_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Lunala_LL Lunala_LL;
        public HeartBarUI heartBarUI;
        public void Lunala_AFStatsI()
        {
            Lunala_LL.Lunala_LLI();
            int activeLevels = Lunala_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);
        }
    }
}