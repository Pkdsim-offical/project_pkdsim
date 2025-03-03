using project_pkdsim.Assets.USys.TABSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_MusicLink.I.LoadPresets.LoadGenre;
using project_pkdsim.Assets.USys.TABSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_MusicLink.I.LoadPresets.LoadCustom;
using UnityEngine;

namespace project_pkdsim.Assets.USys.TABSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_MusicLink.I.LoadPresets
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