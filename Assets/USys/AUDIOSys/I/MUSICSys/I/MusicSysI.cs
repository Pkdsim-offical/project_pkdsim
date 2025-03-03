using project_pkdsim.Assets.USys.AUDIOSys.I.MUSICSys.I.Loader;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AUDIOSys.I.MUSICSys.I
{
	public class MusicSysI : MonoBehaviour
	{
		private MusicSysLoader MusicLoader;
		private void MusicSys_I() 
		{
			LoadMusicSys();
		}
		private void LoadMusicSys()
		{
			LoadMusicLoader();
		}
		private void LoadMusicLoader()
		{
			MusicLoader.MusicLoaderI();
		}
	}
}