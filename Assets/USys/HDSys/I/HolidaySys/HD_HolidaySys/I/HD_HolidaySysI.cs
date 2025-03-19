using project_pkdsim.Assets.USys.HolidaySys.ULoader;
using project_pkdsim.Assets.USys.HolidaySys.Base;
using project_pkdsim.Assets.USys.HolidaySys.HolidayDatabaseSys;
using UnityEngine;


namespace project_pkdsim.Assets.USys.HolidaySys.I
{
	public class HD_HolidaySysI : MonoBehaviour
	{
		private Holiday_Base HDSys_Base;

		private HDataSys HDatabaseSys;

		private HDSys_Loader HDSys_Loader;

		public void  HD_HolidaySys_I() 
		{
			Get_HDSysLoader();
			Get_HDSysDatabase();
			Get_HDSysBase();
		}
		private void Get_HDSysLoader() 
		{
			HDSys_Loader.HDSys_LoaderI();
		}
		private void Get_HDSysDatabase() 
		{
			HDatabaseSys.HDataSysI();
		}
		private void Get_HDSysBase() 
		{
			
		}
	}
}