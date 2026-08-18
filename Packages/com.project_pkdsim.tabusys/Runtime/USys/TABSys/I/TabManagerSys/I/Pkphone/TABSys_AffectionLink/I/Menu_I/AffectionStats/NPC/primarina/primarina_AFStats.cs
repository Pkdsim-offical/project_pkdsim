using project_pkdsim.USys.LOSys.Modules.LoveSys.Modules.LoveScripts.Modules.NPC.I_data.Primarina;
using project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Base;

namespace project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Primarina
{
    public class Primarina_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Primarina_LL Primarina_LL;
        public HeartBarUI heartBarUI;
        public void Primarina_AFStatsI()
        {
            Primarina_LL.Primarina_LLI();
            int activeLevels = Primarina_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);
        }
    }
}