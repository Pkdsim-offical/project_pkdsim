using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using project_pkdsim.USys.TABSys.Modules.TabManagerSys.Modules.TABSys_UIL.Modules.TABSys_PkPhoneUIL.TABSys_BaseLink;

namespace project_pkdsim.USys.TABSys.Modules.TabManagerSys.Modules.TABSys_UIL.Modules.TABSys_PkPhoneUIL.TABSys_PkPhoneAPPS.TABSys_WayPointLink
{
	public class TABSys_WaypointPanelLinker : TABSys_BaseLinker
	{
		private GameObject PkPhone_WaypointPanel;
		private Button PkPhone_Waypoint;

		protected void OpenWaypointPanel()
		{
			SetAllPanelsInactive();
			PkPhone_WaypointPanel.SetActive(true);

			// if set active gives true load "waypointpage"
			if (PkPhone_WaypointPanel.activeSelf == true)
			{
				SceneManager.LoadScene("Pkphone_HOUSETPMenu");
			}
		}

		private void PkPhone_Waypoint_Panel_Listener()
		{
			PkPhone_Waypoint.onClick.AddListener(OpenWaypointPanel);
		}
		public void TABSys_WaypointMenuI()
        {
            PkPhone_Waypoint_Panel_Listener();
            OpenWaypointPanel();
        }
	}
}