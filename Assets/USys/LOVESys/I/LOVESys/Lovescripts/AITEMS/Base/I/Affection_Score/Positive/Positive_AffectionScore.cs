using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.AITEMS.Base.I.Affection_Score.Shared;
using UnityEngine;

namespace project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.AITEMS.Base.Affection_Score.Positive
{
	public class Positive_AffectionScore : MonoBehaviour 
	{
		private AffectionScore_Shared AffectionScoreShared; // Create an instance field
		// gives +3 affection
		public void Affection_ItemsSys_Positive()
		{
			AffectionScoreShared.affectionScore += 3;
		}
	}
}