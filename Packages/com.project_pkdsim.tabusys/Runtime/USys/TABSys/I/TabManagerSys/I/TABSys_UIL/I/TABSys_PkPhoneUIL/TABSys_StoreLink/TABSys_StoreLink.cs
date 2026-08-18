using project_pkdsim.USys.TABSys.Modules.TabManagerSys.Modules.TABSys_UIL.Modules.TABSys_PkPhoneUIL.TABSys_BaseLink;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace project_pkdsim.USys.TABSys.Modules.TabManagerSys.Modules.TABSys_UIL.Modules.TABSys_PkPhoneUIL.TABSys_PkPhoneAPPS.TABSys_StoreLink
{
	public class TABSys_StorePanelLinker : TABSys_BaseLinker
	{
		private GameObject PkPhone_StorePanel;
		private Button PkPhone_Store;

		protected void OpenStorePanel()
		{
			SetAllPanelsInactive();
			PkPhone_StorePanel.SetActive(true);

			// if set active gives true load "homepage"
			if (PkPhone_StorePanel.activeSelf == true)
			{
				SceneManager.LoadScene("Homepage");
			}
		}

		private void PkPhone_Store_Panel_Listener()
		{
			PkPhone_Store.onClick.AddListener(OpenStorePanel);
		}
		public void TABSys_StoreMenuI()
        {
            PkPhone_Store_Panel_Listener();
            OpenStorePanel();
        }
	}
}