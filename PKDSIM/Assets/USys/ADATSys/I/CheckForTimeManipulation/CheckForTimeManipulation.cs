using System;
using System.Collections.Generic;
using project_pkdsim.Assets.USys.AntiDateAndTimeSys.I.HandleTimeCheating;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AntiDateAndTimeSys.I.CheckForTimeManipulation
{
	public class Check_For_Time_Manipulation : MonoBehaviour 
	{
		private Handle_Time_Cheating HandleTimeCheating; 
		private List<DateTime> lastPlayDates = new List<DateTime>();
		public void CheckForTimeManipulation() 
		{
			CheckForTimeManipulationI();
		}
		private void CheckForTimeManipulationI()
		{
			if (lastPlayDates.Count < 2) return; // Not enough data to compare

			DateTime lastSession = lastPlayDates[lastPlayDates.Count - 2];
			DateTime currentSession = DateTime.Now;

			if (currentSession < lastSession)
			{
				Debug.LogWarning("Possible time manipulation detected! System clock was set backward.");
				Debug.LogWarning("Last session: " + lastSession);
				Debug.LogWarning("Current session: " + currentSession);
				HandleTimeCheating.HandleTimeCheating();
			}
		}
	}
}