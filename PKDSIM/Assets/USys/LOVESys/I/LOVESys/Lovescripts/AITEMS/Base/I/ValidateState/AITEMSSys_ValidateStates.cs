using UnityEngine;

namespace project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.AITEMS.Base.ValidateState
{
	public class AITEMSSys_ValidateStates : MonoBehaviour 
	{
		// Ensure that only one state is active at a time
		private bool negative = false;
		private bool neutral = false;
		private bool positive = false;
		private bool immune = false;
		
		public void ValidateStates()
		{
			if (negative)
			{
				neutral = false;
				positive = false;
				immune = false;
			}
			else if (neutral)
			{
				negative = false;
				positive = false;
				immune = false;
			}
			else if (positive)
			{
				negative = false;
				neutral = false;
				immune = false;
			}
			else if(immune)
			{
				neutral = false;
				negative = false;
				positive = false;
			}
		}
	}
}