using project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.SocialMediaLink.Modules.DiscordLink;
using project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.SocialMediaLink.Modules.PatreonLink;
using UnityEngine;

namespace project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.SocialMediaLink.Modules.SocialMedia
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