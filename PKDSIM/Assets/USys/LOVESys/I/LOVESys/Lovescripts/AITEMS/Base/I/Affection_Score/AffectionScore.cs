using System.Collections.Generic;
using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.AITEMS.Base.Affection_Score.Positive;
using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.AITEMS.Base.Affection_Score.Neutral;
using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.AITEMS.Base.Affection_Score.Negative;
using UnityEngine;
using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.AITEMS.Base.Affection_Score.Immune;

namespace project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.AITEMS.Base.Affection_Score
{
	public class AffectionScore : MonoBehaviour 
	{
		// Create an instance field
		private bool negative = false;
		private bool neutral = false;
		private bool positive = false;
		private bool immune = false;

		// Imports
		private Negative_AffectionScore Negative_AffectionScore;
		private Neutral_AffectionScore Neutral_AffectionScore;
		private Positive_AffectionScore Positive_AffectionScore;
		private Immune_AffectionScore Immune_AffectionScore;

		public bool Affection_ITEMSSys_BASE(bool negative, bool neutral, bool positive, bool immune)
		{
			this.negative = negative;
			this.neutral = neutral;
			this.positive = positive;
			this.immune = immune;

			bool ActionTaken = false;

			if (this.negative)
			{
				Negative_AffectionScore.Affection_ItemsSys_Negative();
				ActionTaken = true;
			}
			else if (this.neutral)
			{
				Neutral_AffectionScore.Affection_ItemsSys_Neutral();
				ActionTaken = true;
			}
			else if (this.positive)
			{
				Positive_AffectionScore.Affection_ItemsSys_Positive();
				ActionTaken = true;
			}
			else if(this.immune)
			{
				Immune_AffectionScore.Affection_ItemsSys_Immune();
				ActionTaken= true;
			}
			return ActionTaken;
		}
	}
}