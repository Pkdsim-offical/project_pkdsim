using project_pkdsim.USys.HDSys.Modules.HOLIDAYSys.Modules.DataBase.ULoader;
using project_pkdsim.USys.HDSys.Modules.HOLIDAYSys.Modules.DataBase.HolidayDatabaseSys;
using UnityEngine;


namespace project_pkdsim.USys.HDSys.Modules.HOLIDAYSys.Modules.DataBase.Modules
{
	public class HD_HolidaySysI : MonoBehaviour
	{
		private HDataSys HDatabaseSys;

		private HDSys_Loader HDSys_Loader;

		public void  HD_HolidaySys_I() 
		{
			Get_HDSysLoader();
			Get_HDSysDatabase();
		}
		private void Get_HDSysLoader() 
		{
			HDSys_Loader.HDSys_LoaderI();
		}
		private void Get_HDSysDatabase() 
		{
			HDatabaseSys.HDataSysI();
		}
	}
}