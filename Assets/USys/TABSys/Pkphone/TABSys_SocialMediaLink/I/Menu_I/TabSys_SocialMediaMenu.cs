using UnityEngine;
using UnityEngine.UI;
using TMPro;
using project_pkdsim.Assets.USys.TABSys.Pkphone.TABSys_PkPhoneAPPS.SocialMediaLink.I.SocialMedia;

namespace project_pkdsim.Assets.USys.TABSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_SocialMediaLink.I.Menu_I
{
    public class TabSys_SocialMediaMenu : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI Alerter;
        [SerializeField] private SocialMediaLinkI SocialMediaLinker;
        [SerializeField] private GameObject DiscordPanel;
        [SerializeField] private GameObject PatreonPanel;
        [SerializeField] private Button ConfirmButton;
        [SerializeField] private Button CancelButton;

        private bool IsDiscordPanel;
        private bool IsPatreonPanel;

        private void Start()
        {
            // Ensure panels are not active at start
            if (DiscordPanel) 
			{
				DiscordPanel.SetActive(false);
			}
			if (PatreonPanel) 
			{
				PatreonPanel.SetActive(false);
			}
            // Assign button listeners
            if (ConfirmButton) 
			{
				ConfirmButton.onClick.AddListener(OnConfirmButton);
			}
            if (CancelButton) 
			{
				CancelButton.onClick.AddListener(CloseMenu);
			}
        }

        public void DisplayMenu()
        {
            if (IsDiscordPanel)
			{
                DisplayDiscordPanel();
			}
			else if (IsPatreonPanel)
			{
                DisplayPatreonPanel();
			}
            else
			{
                ClosePanel();
			}
        }

        private void DisplayDiscordPanel()
        {
            if (DiscordPanel) 
			{
				DiscordPanel.SetActive(true);
			}
        }

        private void DisplayPatreonPanel()
        {
            if (PatreonPanel) 
			{
				PatreonPanel.SetActive(true);
			}
        }

        private void ClosePanel()
        {
            if (DiscordPanel)
			{ 
				DiscordPanel.SetActive(false);
			}
			if (PatreonPanel) 
			{
				PatreonPanel.SetActive(false);
			}
        }

        private void CloseMenu()
        {
            ClosePanel();
        }

        private void OnConfirmButton()
        {
            if (IsDiscordPanel)
			{
                SocialMediaLinker?.Load_DiscordLink();
			}
            else if (IsPatreonPanel)
			{
                SocialMediaLinker?.Load_PatreonLink();
			}
        }
    }
}
