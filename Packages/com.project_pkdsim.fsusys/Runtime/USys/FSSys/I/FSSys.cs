using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules;

namespace project_pkdsim.USys.FSSys.Modules
{
	public class FSSysI 
	{
        private FailSafeSysI FailSafeSys;
		public void FSSys_I()
        {
            Get_FailSafeSys();
        }
        private void Get_FailSafeSys()
        {
            FailSafeSys.FSSys_I();
        }
	}
}