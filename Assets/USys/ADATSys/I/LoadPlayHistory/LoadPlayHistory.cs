using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AntiDateAndTimeSys.I.LoadPlayHistory
{
	public class Load_Play_History : MonoBehaviour 
	{
		private List<DateTime> lastPlayDates = new List<DateTime>();
		public void LoadPlayHistory() 
		{
			LoadPlayHistoryI();
		}
		private void LoadPlayHistoryI()
		{
			string savedDates = PlayerPrefs.GetString("PlayHistory", "");
			if (!string.IsNullOrEmpty(savedDates))
			{
				lastPlayDates = savedDates.Split(',')
					.Select(date => DateTime.Parse(date))
					.ToList();
			}
		}
	}
}