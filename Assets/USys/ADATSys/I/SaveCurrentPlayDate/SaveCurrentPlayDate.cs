using System;
using System.Collections.Generic;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AntiDateAndTimeSys.I.SaveCurrentPlayDate
{
	public class Save_Current_Play_Date : MonoBehaviour 
	{
		private List<DateTime> lastPlayDates = new List<DateTime>();
		public void SaveCurrentPlayDate() 
		{
			SaveCurrentPlayDateI();
		}
		private void SaveCurrentPlayDateI()
		{
			lastPlayDates.Add(DateTime.Now);
			if (lastPlayDates.Count > 5) // Keep only the last 5 sessions
				lastPlayDates.RemoveAt(0);

			PlayerPrefs.SetString("PlayHistory", string.Join(",", lastPlayDates));
			PlayerPrefs.Save();
		}
	}
}