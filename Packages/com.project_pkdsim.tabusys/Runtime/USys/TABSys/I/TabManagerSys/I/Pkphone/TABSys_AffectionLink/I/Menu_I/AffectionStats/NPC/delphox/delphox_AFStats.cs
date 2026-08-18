using project_pkdsim.USys.LOSys.Modules.LoveSys.Modules.LoveScripts.Modules.NPC.I_data.Delphox;
using project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Base;

namespace project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats.Delphox
{
    public class Delphox_AFStats : TABSys_AffectionStatsMenuBase
    {
        private Delphox_LL Delphox_LL;
        public HeartBarUI heartBarUI;
        public void Delphox_AFStatsI()
        {
            Delphox_LL.Delphox_LLI();
            int activeLevels = Delphox_LL.GetActiveLoveLevel();
            heartBarUI.UpdateHearts(activeLevels);
        }
    }
}