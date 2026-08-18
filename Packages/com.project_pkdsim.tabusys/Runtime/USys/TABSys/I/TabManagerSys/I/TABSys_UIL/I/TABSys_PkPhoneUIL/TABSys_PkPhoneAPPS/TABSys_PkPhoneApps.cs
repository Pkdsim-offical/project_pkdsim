using project_pkdsim.USys.TABSys.Modules.TabManagerSys.Modules.TABSys_UIL.Modules.TABSys_PkPhoneUIL.TABSys_PkPhoneAPPS.TABSys_PkpediaLink;
using project_pkdsim.USys.TABSys.Modules.TabManagerSys.Modules.TABSys_UIL.Modules.TABSys_PkPhoneUIL.TABSys_PkPhoneAPPS.TABSys_SettingsLink;
using project_pkdsim.USys.TABSys.Modules.TabManagerSys.Modules.TABSys_UIL.Modules.TABSys_PkPhoneUIL.TABSys_PkPhoneAPPS.TABSys_WayPointLink;
using project_pkdsim.USys.TABSys.Modules.TabManagerSys.Modules.TABSys_UIL.Modules.TABSys_PkPhoneUIL.TABSys_PkPhoneAPPS.TABSys_StoreLink;
using project_pkdsim.USys.TABSys.Modules.TabManagerSys.Modules.TABSys_UIL.Modules.TABSys_PkPhoneUIL.TABSys_PkPhoneAPPS.TABSys_SocialMediaLink;
using project_pkdsim.USys.TABSys.Modules.TabManagerSys.Modules.TABSys_UIL.Modules.TABSys_PkPhoneUIL.TABSys_PkPhoneAPPS.TABSys_MusicLink;
using project_pkdsim.USys.TABSys.Modules.TabManagerSys.Modules.TABSys_UIL.Modules.TABSys_PkPhoneUIL.TABSys_PkPhoneAPPS.TABSys_AffectionLink;
using project_pkdsim.USys.TABSys.Modules.TabManagerSys.Modules.TABSys_UIL.Modules.TABSys_PkPhoneUIL.TABSys_PkPhoneAPPS.TABSys_HomeLink;
using UnityEngine;


namespace project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.Modules.TABSys_UIL.Modules.TABSys_PkPhoneUIL.TABSys_PkPhoneAPPS
{
	public class TABSys_PkPhoneAppsPanel : MonoBehaviour 
	{
		private TABSys_PkpediaPanelLinker TABSys_PkPhoneUI_PkpediaAPP;
		private TABSys_SettingsPanelLinker TABSys_PkPhoneUI_SettingsAPP;
		private TABSys_WaypointPanelLinker TABSys_PkPhoneUI_WaypointsAPP;
		private TABSys_StorePanelLinker TABSys_PkPhoneUI_StoreAPP;
		private TABSys_SocialMediaPanelLinker TABSys_PkPhoneUI_SocialMediaAPP;
		private TABSys_MusicPanelLinker TABSys_PkPhoneUI_MusicAPP;
		private TABSys_AffectionPanelLinker TABSys_PkPhoneUI_AffectionAPP;
		private TABSys_HomePagePanelLinker TABSys_PkPhoneUI_HomePageAPP;

		private void PkPhone_PkpediaAPP()
		{
			TABSys_PkPhoneUI_PkpediaAPP.TABSys_PkpediaMenuI();
		}
		private void PkPhone_SettingsAPP()
		{
			TABSys_PkPhoneUI_SettingsAPP.TABSys_SettingsMenuI();
		}
		private void PkPhone_WaypointAPP() 
		{
			TABSys_PkPhoneUI_WaypointsAPP.TABSys_WaypointMenuI();
		}
		private void PkPhone_StoreAPP() 
		{
			TABSys_PkPhoneUI_StoreAPP.TABSys_StoreMenuI();	
		}
		private void PkPhone_SocialMediaAPP() 
		{
			TABSys_PkPhoneUI_SocialMediaAPP.TABSys_SocialMediaMenuI();
		}
		private void PkPhone_MusicAPP() 
		{
			TABSys_PkPhoneUI_MusicAPP.TABSys_MusicMenuI();
		}
		private void PkPhone_AffectionAPP() 
		{
			TABSys_PkPhoneUI_AffectionAPP.TABSys_AffectionMenuI();
		}
		private void PkPhone_HomePageAPP() 
		{
			TABSys_PkPhoneUI_HomePageAPP.TABSys_HomePageMenuI();
		}
		public void TabSys_PkPhoneApps()
		{
			PkPhone_PkpediaAPP();
			PkPhone_SettingsAPP();
			PkPhone_WaypointAPP();
			PkPhone_StoreAPP();
			PkPhone_SocialMediaAPP();
			PkPhone_MusicAPP();
			PkPhone_AffectionAPP();
			PkPhone_HomePageAPP();
		}
		public TABSys_PkPhoneAppsPanel()
		{
			TABSys_PkPhoneUI_PkpediaAPP = new TABSys_PkpediaPanelLinker();
			TABSys_PkPhoneUI_SettingsAPP = new TABSys_SettingsPanelLinker();
			TABSys_PkPhoneUI_WaypointsAPP = new TABSys_WaypointPanelLinker();
			TABSys_PkPhoneUI_StoreAPP = new TABSys_StorePanelLinker();
			TABSys_PkPhoneUI_SocialMediaAPP = new TABSys_SocialMediaPanelLinker();
			TABSys_PkPhoneUI_MusicAPP = new TABSys_MusicPanelLinker();
			TABSys_PkPhoneUI_AffectionAPP = new TABSys_AffectionPanelLinker();
			TABSys_PkPhoneUI_HomePageAPP = new TABSys_HomePagePanelLinker();
		}
	}
}