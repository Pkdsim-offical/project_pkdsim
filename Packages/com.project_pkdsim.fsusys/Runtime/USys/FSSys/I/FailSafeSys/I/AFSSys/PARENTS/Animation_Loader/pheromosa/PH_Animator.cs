using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Dad.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Mom.Animator_I;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa
{
	public class LFS_PheromosaParentsFailSafe : MonoBehaviour 
	{
		private PheromosaParentDad_FailSafe PheromosaParentDad_FailSafe;
		private PheromosaParentMom_FailSafe PheromosaParentMom_FailSafe;
		public void LoadFailSafePheromosaParents_AnimatorController()
		{
			LoadFailSafe_PheromosaParentDad_FailSafe();
			LoadFailSafe_PheromosaParentMom_FailSafe();	
		}
		private void LoadFailSafe_PheromosaParentDad_FailSafe()
		{
			// PheromosaParentDad_FailSafe.LoadFailSafePheromosaParentDad_AnimatorController();
		}
		private void LoadFailSafe_PheromosaParentMom_FailSafe()
		{
			// PheromosaParentMom_FailSafe.LoadFailSafePheromosaParentMom_AnimatorController();
		}	
	}
}