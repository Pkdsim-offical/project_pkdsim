using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Mom.Mom.Animator_I;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace
{
	public class LFS_CinderaceParentsFailSafe : MonoBehaviour 
	{
		private CinderaceParentDad_FailSafe CinderaceParentDad_FailSafe;
		private CinderaceParentMom_FailSafe CinderaceParentMom_FailSafe;
		public void LoadFailSafeCinderaceParents_AnimatorController()
		{
			LoadFailSafe_CinderaceParentDad_FailSafe();
			LoadFailSafe_CinderaceParentMom_FailSafe();
		}
		private void LoadFailSafe_CinderaceParentDad_FailSafe()
		{
			// CinderaceParentDad_FailSafe.LoadFailSafeCinderaceParentDad_AnimatorController();
		}
		private void LoadFailSafe_CinderaceParentMom_FailSafe()
		{
			// CinderaceParentMom_FailSafe.LoadFailSafeCinderaceParentMom_AnimatorController();
		}
	}
}