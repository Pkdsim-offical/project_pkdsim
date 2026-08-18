using project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_WayPointLink.Modules.Menu_I;
using UnityEngine;

namespace project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_WayPointLink.Modules
{
	public class TABSys_WayPointLINK : MonoBehaviour 
	{
		private TabSys_WaypointMenu TABSys_WayPointMenu;
		public void TABSys_WaypointMenuI() 
		{
			TABSys_WayPointMenu.DisplayMenu();
		}
	}
}