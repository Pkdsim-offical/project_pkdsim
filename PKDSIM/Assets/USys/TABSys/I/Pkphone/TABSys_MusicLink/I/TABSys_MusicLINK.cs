using project_pkdsim.Assets.USys.TabSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_MusicLink.I.LoadPresets;
using UnityEngine;

namespace project_pkdsim.Assets.USys.TabSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_MusicLink.I
{
	public class TABSys_MusicLINK : MonoBehaviour
    {
		private LoadMusicPresets LoadMusicPresets;
		public void TABSys_MusicLink() 
		{
			LoadMusicPresetsI();
		}
		private void LoadMusicPresetsI() 
		{
			LoadMusicPresets.MusicPresetLoader();
		}
	}
}