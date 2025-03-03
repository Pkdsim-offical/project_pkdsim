using project_pkdsim.Assets.USys.TABSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_PkpediaLink;
using project_pkdsim.Assets.USys.TABSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_SettingsLink;
using project_pkdsim.Assets.USys.TABSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_SocialMediaLink;
using project_pkdsim.Assets.USys.TABSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_StoreLink;
using project_pkdsim.Assets.USys.TABSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_WayPointLink;
using project_pkdsim.Assets.USys.TABSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_MusicLink;
using UnityEngine;

namespace project_pkdsim.Assets.USys.TABSys.Pkphone.TABSys_PkPhoneAPPS
{
	public class TABSys_PkPhoneApps : MonoBehaviour 
	{
		private TABSys_PkpediaLinker TABSys_PkPhoneUI_PkpediaAPP;
		private TABSys_SettingsLinker TABSys_PkPhoneUI_SettingsAPP;
		private TABSys_WaypointLinker TABSys_PkPhoneUI_WaypointsAPP;
		private TABSys_StoreLinker TABSys_PkPhoneUI_StoreAPP;
		private TABSys_SocialMediaLinker TABSys_PkPhoneUI_SocialMediaAPP;
		private TABSys_MusicLinker TABSys_PkPhoneUI_MusicAPP;

		private void PkPhone_pkpediaAPP()
		{
			TABSys_PkPhoneUI_PkpediaAPP.TABSys_pkpediaLink();
		}
		private void PkPhone_SetAPP()
		{
			TABSys_PkPhoneUI_SettingsAPP.TABSys_settingsLink();
		}
		private void PkPhone_WaypointAPP() 
		{
			TABSys_PkPhoneUI_WaypointsAPP.TABSys_waypointLink();
		}
		private void PkPhone_StoreAPP() 
		{
			TABSys_PkPhoneUI_StoreAPP.TABSys_storeLink();	
		}
		private void PkPhone_SocialMediaAPP() 
		{
			TABSys_PkPhoneUI_SocialMediaAPP.TABSys_socialmediaLink();
		}
		private void PkPhone_MusicAPP() 
		{
			TABSys_PkPhoneUI_MusicAPP.TABSys_musicLink();
		}
		public void TabSys_PkPhoneApps() 
		{
			PkPhone_pkpediaAPP();
			PkPhone_SetAPP();
			PkPhone_WaypointAPP();
			PkPhone_StoreAPP();
			PkPhone_SocialMediaAPP();
			PkPhone_MusicAPP();
		}
		public TABSys_PkPhoneApps()
		{
			TABSys_PkPhoneUI_PkpediaAPP = new TABSys_PkpediaLinker();
			TABSys_PkPhoneUI_SettingsAPP = new TABSys_SettingsLinker();
			TABSys_PkPhoneUI_WaypointsAPP = new TABSys_WaypointLinker();
			TABSys_PkPhoneUI_StoreAPP = new TABSys_StoreLinker();
			TABSys_PkPhoneUI_SocialMediaAPP = new TABSys_SocialMediaLinker();
			TABSys_PkPhoneUI_MusicAPP = new TABSys_MusicLinker();
		}
	}
}