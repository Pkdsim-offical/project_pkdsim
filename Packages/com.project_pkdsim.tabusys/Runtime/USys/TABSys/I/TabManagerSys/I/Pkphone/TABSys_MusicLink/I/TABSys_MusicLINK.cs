using project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_MusicLink.Modules.LoadPresets;
using UnityEngine;

namespace project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_MusicLink.Modules
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