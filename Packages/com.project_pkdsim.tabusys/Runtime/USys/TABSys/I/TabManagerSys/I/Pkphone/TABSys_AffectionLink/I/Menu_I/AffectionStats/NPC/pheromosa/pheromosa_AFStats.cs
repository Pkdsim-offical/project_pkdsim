using project_pkdsim.USys.LOSys.Modules.LoveSys.Modules.LoveScripts.Modules.NPC.I_data.Pheromosa;
using project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Base;

namespace project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Pheromosa
{
    public class Pheromosa_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Pheromosa_LL Pheromosa_LL;
        public HeartBarUI heartBarUI;
        public void Pheromosa_AFStatsI()
        {
            Pheromosa_LL.Pheromosa_LLI();
            int activeLevels = Pheromosa_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);
        }
    }
}