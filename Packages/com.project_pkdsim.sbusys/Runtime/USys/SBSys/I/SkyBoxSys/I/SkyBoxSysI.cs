using project_pkdsim.USys.SBSys.Modules.SkyboxSys.Modules.Day;
using project_pkdsim.USys.SBSys.Modules.SkyboxSys.Modules.Night;
using UnityEngine;

namespace project_pkdsim.USys.SBSys.Modules.SkyboxSys.Modules.SkyboxSys
{
	public class SkyBoxSysI : MonoBehaviour 
	{
		private Skybox_Day Skybox_Day;
		private Skybox_Night Skybox_Night;
		public void SkyBox_LoadDay() 
		{
			Skybox_Day.Skybox_DayI();
		}
		
		public void SkyBox_LoadNight() 
		{
			Skybox_Night.Skybox_NightI();
		}
		public void SkyBoxSys_I() 
		{
			SkyBox_LoadDay();
			SkyBox_LoadNight();
		}
	}
}