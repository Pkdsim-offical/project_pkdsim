using project_pkdsim.Assets.USys.AUDIOSys.I.MUSICSys.I.Presets;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AUDIOSys.I.MUSICSys.I.Loader.I
{
	public class MusicSysLoaderI : MonoBehaviour 
	{
		private MusicPresets MusicPresets;
		public void MusicLoader_I() 
		{
			MusicLoaderPresets();
		}
		private void MusicLoaderPresets()
		{
			MusicPresets.Presets();
		}
	}
}