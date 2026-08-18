using project_pkdsim.USys.LOSys.Modules.LoveSys.Modules.LoveScripts.AITEMS.Base.Modules.Affection_Score.Shared;
using UnityEngine;

namespace project_pkdsim.USys.LOSys.Modules.LoveSys.Modules.LoveScripts.AITEMS.Base.Affection_Score.Neutral
{
	public class Neutral_AffectionScore : MonoBehaviour 
	{
		private AffectionScore_Shared AffectionScoreShared; // Create an instance field
		// gives +0 affection
		public void Affection_ItemsSys_Neutral()
		{
			AffectionScoreShared.affectionScore += 0;
		}
	}
}