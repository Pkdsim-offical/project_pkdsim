using project_pkdsim.USys.TABSys.Modules.TabManagerSys.Modules.TABSys_UIL.Modules.TABSys_PkPhoneUIL.TABSys_BaseLink;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace project_pkdsim.USys.TABSys.Modules.TabManagerSys.Modules.TABSys_UIL.Modules.TABSys_PkPhoneUIL.TABSys_PkPhoneAPPS.TABSys_AffectionLink
{
	public class TABSys_AffectionPanelLinker : TABSys_BaseLinker
	{
		private GameObject PkPhone_AffectionPanel;
		private Button PkPhone_Affection;

		private void OpenAffectionPanel()
		{
			SetAllPanelsInactive();
			PkPhone_AffectionPanel.SetActive(true);

			// if set active gives true load "PkPhone_AffectionMenu"
			if (PkPhone_AffectionPanel.activeSelf == true)
			{
				SceneManager.LoadScene("PkPhone_AffectionMenu");
			}
		}

		private void PkPhone_Affection_Panel_Listener()
		{
			PkPhone_Affection.onClick.AddListener(OpenAffectionPanel);
		}
		public void TABSys_AffectionMenuI()
        {
            PkPhone_Affection_Panel_Listener();
            OpenAffectionPanel();
        }
	}
}