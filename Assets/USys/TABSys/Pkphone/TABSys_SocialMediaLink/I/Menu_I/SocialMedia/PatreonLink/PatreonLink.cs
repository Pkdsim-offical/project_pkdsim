using UnityEngine;
using UnityEngine.UI;

namespace project_pkdsim.Assets.USys.TABSys.Pkphone.TABSys_PkPhoneAPPS.SocialMediaLink.I.PatreonLink
{
	public class PatreonLinker : MonoBehaviour 
	{
		private GameObject PatreonSMLink;
		private Button PatreonLinkButton;

		private void Start()
		{
			OnPatreonLinkLoad();
		}
		public void OnPatreonLinkLoad()
		{
			AddListener();
			ShowIcon();
		}
		private void ShowIcon()
		{
			PatreonSMLink = GameObject.Find("PatreonSMLink");
		}
		private void AddListener()
		{
			PatreonLinkButton.onClick.AddListener(OnButtonClick);
		}
		private void OnButtonClick()
		{
			Application.OpenURL("https://www.patreon.com/pkdsim_offical");
		}
	}
}