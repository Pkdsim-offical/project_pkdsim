using project_pkdsim.USys.ADSys.Modules.ADATSys.Modules.AntiDateAndTime.Modules.CheckForTimeManipulation;
using project_pkdsim.USys.ADSys.Modules.ADATSys.Modules.AntiDateAndTime.Modules.LoadPlayHistory;
using project_pkdsim.USys.ADSys.Modules.ADATSys.Modules.AntiDateAndTime.Modules.SaveCurrentPlayDate;
using UnityEngine;

namespace project_pkdsim.USys.ADSys.Modules.ADATSys.Modules.AntiDateAndTime
{
	public class AntiDateATimeSysI : MonoBehaviour
	{
		private Load_Play_History LoadPlayHistory;
		private Save_Current_Play_Date SaveCurrentPlayDate;
		private Check_For_Time_Manipulation CheckForTimeManipulation;

		public void AntiDateAndTimeSys_I()
		{
			AntiDATSysI();
		}
		private void AntiDATSysI()
		{
			LoadPlayHistory.LoadPlayHistory();
			CheckForTimeManipulation.CheckForTimeManipulation();
			SaveCurrentPlayDate.SaveCurrentPlayDate();
		}
	}
}
