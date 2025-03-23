using System.Collections.Generic;
using UnityEngine;

namespace project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.Affection.BASE
{
	public class LOVE_Asys_Base : MonoBehaviour
	{
		private bool Stranger;
		private bool Acquaintances;
		private bool Friends;
		private bool BestFriends;
		private bool Lovers;
		private bool Couple;

		public object LoveLevel_progress_A6 { get; private set; }
		public object LoveLevel_progress_A5 { get; private set; }
		public object LoveLevel_progress_A4 { get; private set; }
		public object LoveLevel_progress_A3 { get; private set; }
		public object LoveLevel_progress_A2 { get; private set; }
		public object LoveLevel_progress_A1 { get; private set; }

        public List<bool> LoveLevel_ProgressStates { get; }

		protected LOVE_Asys_Base()
		{
			LoveLevel_ProgressStates = new List<bool>
			{
				Stranger,
				Acquaintances,
				Friends,
				BestFriends,
				Lovers,
				Couple
			};

			LOVE_Asys_Level1();
			LOVE_Asys_Level2();
			LOVE_Asys_Level3();
			LOVE_Asys_Level4();
			LOVE_Asys_Level5();
			LOVE_Asys_Level6();
		}

		private void LOVE_Asys_Level1()
		{
			LoveLevel_progress_A1 = LoveLevel_ProgressStates[0];
		}

		private void LOVE_Asys_Level2()
		{
			LoveLevel_progress_A2 = LoveLevel_ProgressStates[1];
		}

		private void LOVE_Asys_Level3()
		{
			LoveLevel_progress_A3 = LoveLevel_ProgressStates[2];
		}

		private void LOVE_Asys_Level4()
		{
			LoveLevel_progress_A4 = LoveLevel_ProgressStates[3];
		}

		private void LOVE_Asys_Level5()
		{
			LoveLevel_progress_A5 = LoveLevel_ProgressStates[4];
		}

		private void LOVE_Asys_Level6()
		{
			LoveLevel_progress_A6 = LoveLevel_ProgressStates[5];
		}
	}
}