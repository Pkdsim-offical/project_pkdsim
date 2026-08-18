using project_pkdsim.USys.AUSys.Modules.AUDIOSys.Modules.MUSICSys.Modules.Loader;
using UnityEngine;

namespace project_pkdsim.USys.AUSys.Modules.AUDIOSys.Modules.MUSICSys.Modules
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