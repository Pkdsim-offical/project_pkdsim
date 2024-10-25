using UnityEngine;

namespace Assets.USys.LOVESys.AITEMS.Base
{
	public class AITEMSSys_Base : MonoBehaviour
	{
		private bool negative = true;
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

		public void Affection_ITEMSSys_BASE(bool negative, bool neutral, bool positive)
		{
			this.negative = negative;
			this.neutral = neutral;
			this.positive = positive;

			if (this.negative)
			{
				Affection_ITEMSSys_Negative();
			}
			else if (this.neutral)
			{
				Affection_ITEMSSys_Neutral();
			}
			else if (this.positive)
			{
				Affection_ITEMSSys_Positive();
			}
		}

		public void Affection_ITEMSSys_Negative()
		{
			affectionScore = -1;
		}

		public void Affection_ITEMSSys_Neutral()
		{
			affectionScore = 0;
		}

		public void Affection_ITEMSSys_Positive()
		{
			affectionScore = 1;
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
