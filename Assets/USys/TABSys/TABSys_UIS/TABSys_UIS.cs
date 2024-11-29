using UnityEngine;
using UnityEngine.UI;

namespace project_pkdsim.Assets.USys.TABSys.TABSys_UIS
{
    public class TABSys_UIS : MonoBehaviour
    {
        public GameObject PkPhone_HomePagePanel;
        public GameObject PkPhone_PkpediaPanel;

        public GameObject PkPhone_SettingsPanel;
        public Button PkPhone_HomePage;
        public Button PkPhone_Pkpedia;
        public Button PkPhone_Settings;

        private void Start()
        {
            // Ensure the main menu is active and settings panel is inactive at the start
            PkPhone_HomePagePanel.SetActive(true);
            PkPhone_PkpediaPanel.SetActive(false);
            PkPhone_SettingsPanel.SetActive(false);

            // Assign button click listeners
            PkPhone_HomePage.onClick.AddListener(OpenHomePagePanel);
            PkPhone_Pkpedia.onClick.AddListener(OpenMainMenuPanel);
            PkPhone_Settings.onClick.AddListener(OpenSettingPanel);
        }

        private void OpenHomePagePanel()
        {
            PkPhone_HomePagePanel.SetActive(false);
            PkPhone_PkpediaPanel.SetActive(true);
            PkPhone_SettingsPanel.SetActive(false);
        }

        private void OpenMainMenuPanel()
        {
            PkPhone_PkpediaPanel.SetActive(false);
            PkPhone_HomePagePanel.SetActive(true);
            PkPhone_SettingsPanel.SetActive(false);
        }
        private void OpenSettingPanel()
        {
            PkPhone_PkpediaPanel.SetActive(false);
            PkPhone_HomePagePanel.SetActive(false);
            PkPhone_SettingsPanel.SetActive(true);
        }
    }
}