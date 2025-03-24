using project_pkdsim.Assets.USys.AUDIOSys.I.MUSICSys;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AUDIOSys.I
{
	public class AudioSysI : MonoBehaviour 
	{
		private MusicSys MusicSys;
		public void AudiosSys_I()
		{
			LoadMusicSys();
		}
		private void LoadMusicSys() 
		{
			MusicSys.MusicSysI();
		}
	}
}