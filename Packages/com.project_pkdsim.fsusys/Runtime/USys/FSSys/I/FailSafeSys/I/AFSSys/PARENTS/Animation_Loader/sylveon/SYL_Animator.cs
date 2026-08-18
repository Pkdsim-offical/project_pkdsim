using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Dad.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Mom.Animator_I;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon
{
	public class LFS_SylveonParentsFailSafe : MonoBehaviour 
	{
		private SylveonParentDad_FailSafe SylveonParentDad_FailSafe;
		private SylveonParentMom_FailSafe SylveonParentMom_FailSafe;
		public void LoadFailSafeSylveonParents_AnimatorController()
		{
			LoadFailSafe_SylveonParentDad_FailSafe();
			LoadFailSafe_SylveonParentMom_FailSafe();	
		}
		private void LoadFailSafe_SylveonParentDad_FailSafe()
		{
			// SylveonParentDad_FailSafe.LoadFailSafeSylveonParentDad_AnimatorController();
		}
		private void LoadFailSafe_SylveonParentMom_FailSafe()
		{
			// SylveonParentMom_FailSafe.LoadFailSafeSylveonParentMom_AnimatorController();
		}
	}
}