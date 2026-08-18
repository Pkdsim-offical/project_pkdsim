using project_pkdsim.USys.LOSys.Modules.LoveSys.Modules.LoveScripts.Modules.NPC.I_data.Lucario;
using project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Base;

namespace project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Lucario
{
    public class Lucario_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Lucario_LL Lucario_LL;
        public HeartBarUI heartBarUI;
        public void Lucario_AFStatsI()
        {
            Lucario_LL.Lucario_LLI();
            int activeLevels = Lucario_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);
        }
    }
}