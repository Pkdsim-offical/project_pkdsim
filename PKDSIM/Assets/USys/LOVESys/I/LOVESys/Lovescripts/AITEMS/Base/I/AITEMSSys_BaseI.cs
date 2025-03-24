using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.AITEMS.Base.Affection_Score;
using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.AITEMS.Base.Reactions;
using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.AITEMS.Base.ValidateState;
using UnityEngine;

namespace project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.AITEMS.Base.I
{
	public class AITEMSSys_BaseI : MonoBehaviour
	{
		private AITEMSSys_ValidateStates ValidateStates;

		private AITEMSSys_Reactions Reactions;
		private AffectionScore Affection_Score;

		public void AITEMSSys_Base_I()
		{
			Affection_ITEMSSys();
		}

		private void Affection_ITEMSSys()
		{

		}

		// private void Affection_ITEMSSys()
		// {
		// 	// Ensure only one state is true at a time
		// 	ValidateStates();

		// 	Affection_ITEMSSys_BASE(this.negative, this.neutral, this.positive, this.immune);

		// 	if (!this.negative && !this.neutral && !this.positive && !this.immune)
		// 	{
		// 		Debug.LogError("Affection_ITEMSSys: No valid affection state is active");
		// 	}
		// 	else
		// 	{
		// 		Debug.Log("Affection Score: " + affectionScore);
		// 	}
		// }
	}
}
