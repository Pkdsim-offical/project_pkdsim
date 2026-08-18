using project_pkdsim.USys.LOSys.Modules.LoveSys.Modules.LoveScripts.Modules.NPC.I_data.Tsareena;
using project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Base;

namespace project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Tsareena
{
    public class Tsareena_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Tsareena_LL Tsareena_LL;
        public HeartBarUI heartBarUI;
        public void Tsareena_AFStatsI()
        {
            Tsareena_LL.Tsareena_LLI();
            int activeLevels = Tsareena_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);
        }
    }
}