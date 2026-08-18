using project_pkdsim.USys.TABSys.Modules.TabManagerSys.Modules.TABSys_UIL.Modules.TABSys_PkPhoneUIL.TABSys_BaseLink;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace project_pkdsim.USys.TABSys.Modules.TabManagerSys.Modules.TABSys_UIL.Modules.TABSys_PkPhoneUIL.TABSys_PkPhoneAPPS.TABSys_SocialMediaLink
{
	public class TABSys_SocialMediaPanelLinker : TABSys_BaseLinker
	{
		private GameObject PkPhone_SocialMediaPanel;
		private Button PkPhone_SocialMedia;

		private void OpenSocialMediaPanel()
		{
			SetAllPanelsInactive();
			PkPhone_SocialMediaPanel.SetActive(true);
			if (PkPhone_SocialMediaPanel.activeSelf == true)
			{
				SceneManager.LoadScene("Homepage");
			}
		}

		private void PkPhone_SocialMedia_Panel_Listener()
		{
			PkPhone_SocialMedia.onClick.AddListener(OpenSocialMediaPanel);
		}
		public void TABSys_SocialMediaMenuI()
        {
            PkPhone_SocialMedia_Panel_Listener();
            OpenSocialMediaPanel();
        }
	}
}