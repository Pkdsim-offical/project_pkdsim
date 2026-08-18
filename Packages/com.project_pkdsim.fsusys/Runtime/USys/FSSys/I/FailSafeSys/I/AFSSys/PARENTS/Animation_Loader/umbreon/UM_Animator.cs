using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Dad.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Mom.Animator_I;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon
{
	public class LFS_UmbreonParentsFailSafe : MonoBehaviour 
	{
		// pre interface
		private UmbreonParentDad_FailSafe UmbreonParentDad_FailSafe;
		private UmbreonParentMom_FailSafe UmbreonParentMom_FailSafe;
		public void LoadFailSafeUmbreonParents_AnimatorController()
		{
			LoadFailSafe_UmbreonParentDad_FailSafe();
			LoadFailSafe_UmbreonParentMom_FailSafe();	
		}
		private void LoadFailSafe_UmbreonParentDad_FailSafe()
		{
			// UmbreonParentDad_FailSafe.LoadFailSafeUmbreonParentDad_AnimatorController();
		}
		private void LoadFailSafe_UmbreonParentMom_FailSafe()
		{
			// UmbreonParentMom_FailSafe.LoadFailSafeUmbreonParentMom_AnimatorController();
		}	
	}
}