using project_pkdsim.Assets.USys.TABSys.Pkphone.TABSys_PkPhoneAPPS.SocialMediaLink.I.DiscordLink;
using project_pkdsim.Assets.USys.TABSys.Pkphone.TABSys_PkPhoneAPPS.SocialMediaLink.I.PatreonLink;
using UnityEngine;

namespace project_pkdsim.Assets.USys.TABSys.Pkphone.TABSys_PkPhoneAPPS.SocialMediaLink.I.SocialMedia
{
	public class SocialMediaLinkI : MonoBehaviour 
	{
		private DiscordLinker DiscordLink;
		private PatreonLinker PatreonLink;

		public void LoadSocialMediaLinks() 
		{
			Load_DiscordLink();
			Load_PatreonLink();
		}

		public void Load_DiscordLink()
		{
			DiscordLink.OnDiscordLinkLoad();
		}
		
		public void Load_PatreonLink()
		{
			PatreonLink.OnPatreonLinkLoad();
		}
	}
}