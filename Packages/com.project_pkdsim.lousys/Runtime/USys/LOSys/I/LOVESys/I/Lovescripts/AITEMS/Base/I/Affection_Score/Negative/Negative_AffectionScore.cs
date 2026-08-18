using project_pkdsim.USys.LOSys.Modules.LoveSys.Modules.LoveScripts.AITEMS.Base.Modules.Affection_Score.Shared;
using UnityEngine;

namespace project_pkdsim.USys.LOSys.Modules.LoveSys.Modules.LoveScripts.AITEMS.Base.Affection_Score.Negative
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