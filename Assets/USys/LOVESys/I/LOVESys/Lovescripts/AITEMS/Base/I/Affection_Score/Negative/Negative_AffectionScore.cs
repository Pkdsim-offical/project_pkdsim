using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.AITEMS.Base.I.Affection_Score.Shared;
using UnityEngine;

namespace project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.AITEMS.Base.Affection_Score.Negative
{
	public class Negative_AffectionScore : MonoBehaviour 
	{
		private AffectionScore_Shared AffectionScoreShared; // Create an instance field
		// gives -5 affection
		public void Affection_ItemsSys_Negative()
		{
			AffectionScoreShared.affectionScore -= 3;
		}
	}
}