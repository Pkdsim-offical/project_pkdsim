using UnityEngine;

namespace project_pkdsim.Assets.USys.TABSys.Pkphone.TABSys_PkPhoneAPPS
{
	public class TABSys_PkPhoneApps : MonoBehaviour 
	{
	// Use this for initialization
		private project_pkdsim.Assets.USys.TABSys.TABSys_PkpediaLink.TABSys_PkpediaLink TABSys_PkPhoneUI_PkpediaAPP;
		private project_pkdsim.Assets.USys.TABSys.TABSys_SettingsLink.TABSys_SettingsLink TABSys_PkPhoneUI_SettingsAPP;
		private project_pkdsim.Assets.USys.TABSys.TABSys_WayPointLink.TABSys_WaypointLink TABSys_PkPhoneUI_WaypointsAPP;
		private void PkPhone_pkpediaAPP()
		{
			TABSys_PkPhoneUI_PkpediaAPP.TABSys_pkpediaLink();
		}
		private void PkPhone_SetAPP()
		{
			TABSys_PkPhoneUI_SettingsAPP.TABSys_settingsLink();
		}
		private void PkPhone_WaypointAPP() 
		{
			TABSys_PkPhoneUI_WaypointsAPP.TABSys_waypointLink();
		}
		public TABSys_PkPhoneApps()
		{
			TABSys_PkPhoneUI_PkpediaAPP = new project_pkdsim.Assets.USys.TABSys.TABSys_PkpediaLink.TABSys_PkpediaLink();
			TABSys_PkPhoneUI_SettingsAPP = new project_pkdsim.Assets.USys.TABSys.TABSys_SettingsLink.TABSys_SettingsLink();
			TABSys_PkPhoneUI_WaypointsAPP = new project_pkdsim.Assets.USys.TABSys.TABSys_WayPointLink.TABSys_WaypointLink();
		}
		public void TabSys_PkPhoneApps() 
		{
			PkPhone_pkpediaAPP();
			PkPhone_SetAPP();
			PkPhone_WaypointAPP();
		}
	}
}