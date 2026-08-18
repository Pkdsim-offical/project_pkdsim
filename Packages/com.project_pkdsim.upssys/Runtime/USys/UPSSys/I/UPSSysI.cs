using project_pkdsim.USys.UPSSys.Modules.UnityPlayerSaveSys;

namespace project_pkdsim.USys.UPSSys.Modules
{
	public class UPSSysI
	{
        private UnityPlayerSaveFIleSys UnityPlayerSaveFIleSys;
		public void UPSSys_I() 
		{
            GetUnityPlayerSaveFIleSys();
		}
        public void GetUnityPlayerSaveFIleSys()
        {
            UnityPlayerSaveFIleSys.UnityPlayerSaveFIleSysI();
        }
	}
}