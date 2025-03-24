using project_pkdsim.Assets.Editor.Workspaces.AASys.CloudSaveInitializerSys;
using project_pkdsim.Assets.Editor.Workspaces.AASys.ClearAddressablesCacheSys;
using UnityEngine;

namespace project_pkdsim.Assets.Editor.Workspaces.AASys.I
{
	public class Editor_AASysI : MonoBehaviour 
	{
		private AA_CASys AA_CASys;
		private AA_CLSASys AA_CLSASys;
		private void Get_AA_CLSASys()
		{
			AA_CLSASys.AASys_CloudSaveInitializer();
		}
		private void Get_AA_CASys()
		{
			AA_CASys.AASys_ClearCacheInitializer();
		}
		public void AASys_Init() 
		{
			Get_AA_CASys();
			Get_AA_CLSASys();
		}
	}
}