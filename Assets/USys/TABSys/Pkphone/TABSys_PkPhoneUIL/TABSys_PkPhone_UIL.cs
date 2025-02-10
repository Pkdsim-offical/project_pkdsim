using UnityEngine;
using UnityEngine.UI;

namespace project_pkdsim.Assets.USys.TABSys.TABSys_UIS
{
    // PkPhone UI Listener 
    public class TABSys_PkphoneUIL : MonoBehaviour
    {
        public GameObject PkPhone_HomePagePanel;
        public GameObject PkPhone_PkpediaPanel;
        public GameObject PkPhone_SettingsPanel;
        public GameObject PkPhone_WaypointPanel;
        public Button PkPhone_HomePage;
        public Button PkPhone_Pkpedia;
        public Button PkPhone_Settings;
        public Button PkPhone_Waypoint;

        private void Start()
        {
            // Ensure the main menu is active and settings panel is inactive at the start
            PkPhone_HomePagePanel.SetActive(true);
            PkPhone_PkpediaPanel.SetActive(false);
            PkPhone_SettingsPanel.SetActive(false);
            PkPhone_WaypointPanel.SetActive(false);

            // Assign button click listeners
            PkPhone_HomePage.onClick.AddListener(OpenHomePagePanel);
            PkPhone_Pkpedia.onClick.AddListener(OpenMainMenuPanel);
            PkPhone_Settings.onClick.AddListener(OpenSettingPanel);
            PkPhone_Waypoint.onClick.AddListener(OpenWaypointPanel);
        }

        private void OpenHomePagePanel()
        {
            PkPhone_HomePagePanel.SetActive(true);
            PkPhone_PkpediaPanel.SetActive(false);
            PkPhone_SettingsPanel.SetActive(false);
            PkPhone_WaypointPanel.SetActive(false);
        }

        private void OpenMainMenuPanel()
        {
            PkPhone_PkpediaPanel.SetActive(false);
            PkPhone_HomePagePanel.SetActive(false);
            PkPhone_SettingsPanel.SetActive(false);
            PkPhone_WaypointPanel.SetActive(false);
        }
        private void OpenSettingPanel()
        {
            PkPhone_PkpediaPanel.SetActive(false);
            PkPhone_HomePagePanel.SetActive(false);
            PkPhone_SettingsPanel.SetActive(true);
            PkPhone_WaypointPanel.SetActive(false);
        }
        private void OpenWaypointPanel() 
        {
            PkPhone_PkpediaPanel.SetActive(false);
            PkPhone_HomePagePanel.SetActive(false);
            PkPhone_SettingsPanel.SetActive(false);
            PkPhone_WaypointPanel.SetActive(true);
        }
    }
}