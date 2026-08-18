using project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_WayPointLink.Modules.Menu_I.Houses;
using UnityEngine;

namespace project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_WayPointLink.Modules.Menu_I
{
    public class TabSys_WaypointMenu : MonoBehaviour
    {
        private TabSys_WaypointMenuHouses TabSys_WaypointMenuHouses;
        public void DisplayMenu() 
        {
            DisplayHousesI();
        }
        private void  DisplayHousesI() 
        {
            TabSys_WaypointMenuHouses.DisplayMenu();
        }
    }
}