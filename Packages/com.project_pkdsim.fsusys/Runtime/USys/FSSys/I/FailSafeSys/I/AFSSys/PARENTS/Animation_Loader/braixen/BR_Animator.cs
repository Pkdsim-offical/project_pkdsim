using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Braixen.Dad.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Braixen.Mom.Animator_I;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Braixen
{
	public class LFS_BraixenParentsFailSafe : MonoBehaviour 
	{
		private BraixenParentDad_FailSafe BraixenParentDad_FailSafe;
		private BraixenParentMom_FailSafe BraixenParentMom_FailSafe;
		public void LoadFailSafeBraixenParents_AnimatorController()
		{
			LoadFailSafe_BraixenParentDad_FailSafe();
			LoadFailSafe_BraixenParentMom_FailSafe();	
		}
		private void LoadFailSafe_BraixenParentDad_FailSafe()
		{
			// BraixenParentDad_FailSafe.LoadFailSafeBraixenParentDad_AnimatorController();
		}
		private void LoadFailSafe_BraixenParentMom_FailSafe()
		{
			// BraixenParentMom_FailSafe.LoadFailSafeBraixenParentMom_AnimatorController();
		}
	}
}