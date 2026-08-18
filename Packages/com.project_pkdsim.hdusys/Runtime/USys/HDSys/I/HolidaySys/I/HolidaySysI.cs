using project_pkdsim.USys.HDSys.Modules.HOLIDAYSys.Modules.AntiHolidayChecker;
using UnityEngine;

namespace project_pkdsim.USys.HDSys.Modules.HOLIDAYSys.Modules.DataBase.Modules
{
	public class HolidaySysI : MonoBehaviour 
	{
		private HD_HolidaySys HolidaySys;
		private AntiHolidayCheatChecker AntiHolidayCheatChecker;
		public void HDSys_I()
		{
			Get_HD_HolidaySys();
			Get_AntiHolidayCheatChecker();
		}
		private void Get_HD_HolidaySys()
		{
			HolidaySys.HDSysI();
		}
		private void Get_AntiHolidayCheatChecker()
		{
			AntiHolidayCheatChecker.AntiHolidayCheckerI();
		}
	}
}