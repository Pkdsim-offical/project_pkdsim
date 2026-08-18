using project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I.AffectionStats;
using UnityEngine;

namespace project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.Modules.Menu_I
{
	public class TABSys_AffectionMenu : MonoBehaviour
	{
		private TABSys_AffectionStatsMenu TabSys_AffectionStatsMenu;
        public void DisplayMenu() 
        {
            AffectionMenuI();
        }
        private void  AffectionMenuI() 
        {
            TabSys_AffectionStatsMenu.DisplayMenu();
        }
	}
}