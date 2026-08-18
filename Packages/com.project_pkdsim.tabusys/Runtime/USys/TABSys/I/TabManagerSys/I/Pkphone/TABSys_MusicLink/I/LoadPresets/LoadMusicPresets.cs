using project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_MusicLink.Modules.LoadPresets.LoadGenre;
using project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_MusicLink.Modules.LoadPresets.LoadCustom;
using UnityEngine;

namespace project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_MusicLink.Modules.LoadPresets
{
	public class LoadMusicPresets : MonoBehaviour 
	{
		private LoadMusicGenre LoadGenre;
		private LoadCustomMusic LoadCustom;
		public void MusicPresetLoader() 
		{
			GenreMusicLoader();
			CustomMusicLoader();
		}
		private void  GenreMusicLoader() 
		{
			LoadGenre.Genre_I();
		}
		private void CustomMusicLoader() 
		{
			LoadCustom.LoadCustomPreset();
		}
	}
}