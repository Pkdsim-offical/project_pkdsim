using project_pkdsim.USys.LOSys.Modules.LoveSys.Modules.LoveScripts.Modules.NPC.I_data.Gardevoir;
using project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Base;

namespace project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Gardevoir
{
    public class Gardevoir_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Gardevoir_LL Gardevoir_LL;
        public HeartBarUI heartBarUI;
        public void Gardevoir_AFStatsI()
        {
            Gardevoir_LL.Gardevoir_LLI();
            int activeLevels = Gardevoir_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);
        }
    }
}