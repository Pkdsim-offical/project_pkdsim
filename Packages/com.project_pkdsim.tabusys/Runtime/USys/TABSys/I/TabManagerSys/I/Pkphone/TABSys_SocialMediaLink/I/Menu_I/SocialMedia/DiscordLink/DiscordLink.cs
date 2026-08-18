using UnityEngine;
using UnityEngine.UI;

namespace project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.SocialMediaLink.Modules.DiscordLink
{
	public class DiscordLinker : MonoBehaviour 
	{
		private GameObject DiscordSMLink;
		private Button DiscordLinkButton;

		private void Start()
		{
			OnDiscordLinkLoad();
		}
		public void OnDiscordLinkLoad()
		{
			AddListener();
			ShowIcon();
		}
		private void ShowIcon()
		{
			DiscordSMLink = GameObject.Find("DiscordSMLink");
		}
		private void AddListener()
		{
			DiscordLinkButton.onClick.AddListener(OnButtonClick);
		}
		private void OnButtonClick()
		{
			Application.OpenURL("https://discord.gg/pkdsim_offical");
		}
	}
}