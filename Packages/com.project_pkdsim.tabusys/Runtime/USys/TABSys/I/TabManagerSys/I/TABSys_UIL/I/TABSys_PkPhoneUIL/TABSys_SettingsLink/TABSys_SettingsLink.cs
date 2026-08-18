using project_pkdsim.USys.TABSys.Modules.TabManagerSys.Modules.TABSys_UIL.Modules.TABSys_PkPhoneUIL.TABSys_BaseLink;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace project_pkdsim.USys.TABSys.Modules.TabManagerSys.Modules.TABSys_UIL.Modules.TABSys_PkPhoneUIL.TABSys_PkPhoneAPPS.TABSys_SettingsLink
{
    public class TABSys_SettingsPanelLinker : TABSys_BaseLinker
    {
        private GameObject PkPhone_SettingsPanel;
        private Button PkPhone_Settings;

        private void OpenSettingsPanel()
        {
            SetAllPanelsInactive();
            PkPhone_SettingsPanel.SetActive(true);

            // if set active gives true load "homepage"
            if (PkPhone_SettingsPanel.activeSelf == true)
            {
                SceneManager.LoadScene("Homepage");
            }
        }

        private void PkPhone_Settings_Panel_Listeners()
        {
            PkPhone_Settings.onClick.AddListener(OpenSettingsPanel);
        }
        public void TABSys_SettingsMenuI()
        {
            PkPhone_Settings_Panel_Listeners();
            OpenSettingsPanel();
        }
    }
}