using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Dad.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Mom.Animator_I;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon
{
	public class LFS_GlaceonParentsFailSafe : MonoBehaviour 
	{
		private GlaceonParentDad_FailSafe GlaceonParentDad_FailSafe;
		private GlaceonParentMom_FailSafe GlaceonParentMom_FailSafe;
		public void LoadFailSafeGlaceonParents_AnimatorController()
		{
			LoadFailSafe_GlaceonParentDad_FailSafe();
			LoadFailSafe_GlaceonParentMom_FailSafe();	
		}
		private void LoadFailSafe_GlaceonParentDad_FailSafe()
		{
			// GlaceonParentDad_FailSafe.LoadFailSafeGlaceonParentDad_AnimatorController();
		}
		private void LoadFailSafe_GlaceonParentMom_FailSafe()
		{
			// GlaceonParentMom_FailSafe.LoadFailSafeGlaceonParentMom_AnimatorController();
		}
	}
}