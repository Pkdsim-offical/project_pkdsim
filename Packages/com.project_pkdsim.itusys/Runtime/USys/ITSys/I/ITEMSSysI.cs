
using project_pkdsim.USys.ITSys.Modules.UItemsSystemSys;

namespace project_pkdsim.USys.ITSys.Modules
{
	public class ITSysI
	{
        private UnityItemsSystemSys UnityItemsSystemSys;
        public void ITSys_I()
        {
            GetItemsSys();
        }
        public void GetItemsSys()
        {
            UnityItemsSystemSys.UnityItemsSystemSysI();
        }
	}
}