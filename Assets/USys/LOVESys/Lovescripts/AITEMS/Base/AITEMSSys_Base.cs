using UnityEngine;

namespace project_pkdsim.Assets.USys.LOVESys.AITEMS.Base
{
	public class AITEMSSys_Base : MonoBehaviour
	{
		private bool negative = false;
		private bool neutral = false;
		private bool positive = false;

		private int affectionScore = 0;  // +1, 0, -1 based on state

		// Update is called once per frame
		protected void Update()
		{
			Affection_ITEMSSys();
		}

		public void Affection_ITEMSSys()
		{
			// Ensure only one state is true at a time
			ValidateStates();

			Affection_ITEMSSys_BASE(this.negative, this.neutral, this.positive);

			if (!this.negative && !this.neutral && !this.positive)
			{
				Debug.LogError("Affection_ITEMSSys: No valid affection state is active");
			}
			else
			{
				Debug.Log("Affection Score: " + affectionScore);
			}
		}

		public bool Affection_ITEMSSys_BASE(bool negative, bool neutral, bool positive)
		{
			this.negative = negative;
			this.neutral = neutral;
			this.positive = positive;

			bool ActionTaken = false;

			if (this.negative)
			{
				Affection_ITEMSSys_Negative();
				ActionTaken = true;
			}
			else if (this.neutral)
			{
				Affection_ITEMSSys_Neutral();
				ActionTaken = true;
			}
			else if (this.positive)
			{
				Affection_ITEMSSys_Positive();
				ActionTaken = true;
			}
			return ActionTaken;
		}

		/// gives -1 affection
		public void Affection_ITEMSSys_Negative()
		{
			affectionScore -= 1;
		}

		/// gives +0 affection
		public void Affection_ITEMSSys_Neutral()
		{
			affectionScore = 0;
		}

		/// gives +1 affection
		public void Affection_ITEMSSys_Positive()
		{
			affectionScore += 1;
		}

		// Ensure that only one state is active at a time
		private void ValidateStates()
		{
			if (negative)
			{
				neutral = false;
				positive = false;
			}
			else if (neutral)
			{
				negative = false;
				positive = false;
			}
			else if (positive)
			{
				negative = false;
				neutral = false;
			}
		}
	}
}
