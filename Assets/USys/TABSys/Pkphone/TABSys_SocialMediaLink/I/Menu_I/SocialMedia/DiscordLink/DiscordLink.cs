using UnityEngine;
using UnityEngine.UI;

namespace project_pkdsim.Assets.USys.TABSys.Pkphone.TABSys_PkPhoneAPPS.SocialMediaLink.I.DiscordLink
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