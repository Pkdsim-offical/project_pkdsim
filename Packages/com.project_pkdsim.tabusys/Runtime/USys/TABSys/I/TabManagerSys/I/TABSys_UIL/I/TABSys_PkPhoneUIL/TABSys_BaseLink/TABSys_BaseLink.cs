using UnityEngine;

namespace project_pkdsim.USys.TABSys.Modules.TabManagerSys.Modules.TABSys_UIL.Modules.TABSys_PkPhoneUIL.TABSys_BaseLink
{
	// PkPhone UI Listener 
	public class TABSys_BaseLinker : MonoBehaviour
	{
		private GameObject PkPhone_HomePagePanel;
		private GameObject PkPhone_PkpediaPanel;
		private GameObject PkPhone_SettingsPanel;
		private GameObject PkPhone_WaypointPanel;
		private GameObject PkPhone_StorePanel;
		private GameObject PkPhone_SocialMediaPanel;
		private GameObject PkPhone_MusicPanel;
		private GameObject PkPhone_AffectionPanel;

		protected void SetAllPanelsInactive()
		{
			PkPhone_HomePagePanel.SetActive(false);
			PkPhone_PkpediaPanel.SetActive(false);
			PkPhone_SettingsPanel.SetActive(false);
			PkPhone_WaypointPanel.SetActive(false);
			PkPhone_StorePanel.SetActive(false);
			PkPhone_SocialMediaPanel.SetActive(false);
			PkPhone_MusicPanel.SetActive(false);
			PkPhone_AffectionPanel.SetActive(false);
		}
	}
}