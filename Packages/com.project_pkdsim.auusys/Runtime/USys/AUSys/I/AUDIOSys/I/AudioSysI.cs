
using project_pkdsim.USys.AUSys.Modules.AUDIOSys.Modules.MUSICSys;
using project_pkdsim.USys.AUSys.Modules.AUDIOSys.Modules.SoundFXSys;
using project_pkdsim.USys.AUSys.Modules.AUDIOSys.Modules.VoiceActorsSys;
using UnityEngine;

namespace project_pkdsim.USys.AUSys.Modules.AUDIOSys.Modules
{
	public class AudioSysI : MonoBehaviour 
	{
		private MusicSys MusicSys;
		private VASys VASys;
		private SFXSys SFXSys;
		public void AudiosSys_I()
		{
			LoadMusicSys();
			LoadVASys();
			LoadSFXSys();
		}
		private void LoadMusicSys() 
		{
			MusicSys.MusicSysI();
		}
		private void LoadVASys() 
		{
			VASys.VASysI();
		}
		private void LoadSFXSys() 
		{
			SFXSys.SFXSysI();
		}
	}
}