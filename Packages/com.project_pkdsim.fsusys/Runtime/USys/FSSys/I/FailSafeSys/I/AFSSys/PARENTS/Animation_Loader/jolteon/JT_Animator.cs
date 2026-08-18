using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Dad.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Mom.Animator_I;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon
{
	public class LFS_JolteonParentsFailSafe : MonoBehaviour 
	{
		private JolteonParentDad_FailSafe JolteonParentDad_FailSafe;
		private JolteonParentMom_FailSafe JolteonParentMom_FailSafe;
		public void LoadFailSafeJolteonParents_AnimatorController()
		{
			LoadFailSafe_JolteonParentDad_FailSafe();
			LoadFailSafe_JolteonParentMom_FailSafe();	
		}
		private void LoadFailSafe_JolteonParentDad_FailSafe()
		{
			// JolteonParentDad_FailSafe.LoadFailSafeJolteonParentDad_AnimatorController();
		}
		private void LoadFailSafe_JolteonParentMom_FailSafe()
		{
			// JolteonParentMom_FailSafe.LoadFailSafeJolteonParentMom_AnimatorController();
		}
	}
}