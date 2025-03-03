using project_pkdsim.Assets.USys.AntiDateAndTimeSys.I.CheckForTimeManipulation;
using project_pkdsim.Assets.USys.AntiDateAndTimeSys.I.LoadPlayHistory;
using project_pkdsim.Assets.USys.AntiDateAndTimeSys.I.SaveCurrentPlayDate;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AntiDateAndTimeSys.I
{
	public class ADATSysI : MonoBehaviour
	{
		private Load_Play_History LoadPlayHistory;
		private Save_Current_Play_Date SaveCurrentPlayDate;
		private Check_For_Time_Manipulation CheckForTimeManipulation;
		public void ADATSys_I() 
		{
			AntiDateAndTimeSysI();
		}
		private void AntiDateAndTimeSysI()
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
