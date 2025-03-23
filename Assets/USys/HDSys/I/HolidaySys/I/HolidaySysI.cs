using project_pkdsim.Assets.USys.HolidaySys.AntiHolidayChecker;
using project_pkdsim.Assets.USys.HolidaySys;
using UnityEngine;

namespace project_pkdsim.Assets.USys.HolidaySys
{
	public class HDSysI : MonoBehaviour 
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