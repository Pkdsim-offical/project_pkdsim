using project_pkdsim.USys.TABSys.Modules.TabManagerSys.Modules.TABSys_UIL.Modules.TABSys_PkPhoneUIL.TABSys_BaseLink;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


namespace project_pkdsim.USys.TABSys.Modules.TabManagerSys.Modules.TABSys_UIL.Modules.TABSys_PkPhoneUIL.TABSys_PkPhoneAPPS.TABSys_HomeLink
{
	public class TABSys_HomePagePanelLinker : TABSys_BaseLinker
	{
		private GameObject PkPhone_HomePagePanel;
		private Button PkPhone_HomePage;

		private void OpenHomePagePanel()
		{
			SetAllPanelsInactive();
			PkPhone_HomePagePanel.SetActive(true);

			// if set active gives true load "homepage"
			if (PkPhone_HomePagePanel.activeSelf == true)
			{
				SceneManager.LoadScene("Pkphone_HomePageMenu");
			}
			// else "quit"
			else
			{
				Application.Quit();
			}
		}

		private void PkPhone_HomePage_Panel_Listeners()
		{
			PkPhone_HomePage.onClick.AddListener(OpenHomePagePanel);
		}

		public void TABSys_HomePageMenuI()
		{
			PkPhone_HomePage_Panel_Listeners();
			OpenHomePagePanel();
		}
	}
}