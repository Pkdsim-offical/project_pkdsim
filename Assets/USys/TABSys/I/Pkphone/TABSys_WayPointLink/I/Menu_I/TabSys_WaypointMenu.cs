using project_pkdsim.Assets.USys.TabSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_WayPointLink.I.Menu_I.Houses;
using UnityEngine;

namespace project_pkdsim.Assets.USys.TabSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_WayPointLink.I.Menu_I
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