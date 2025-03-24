using project_pkdsim.Assets.USys.SkyboxSys.I.Day;
using project_pkdsim.Assets.USys.SkyboxSys.I.Night;
using UnityEngine;

namespace project_pkdsim.Assets.USys.SkyboxSys.I
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
	}
}