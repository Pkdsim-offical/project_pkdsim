using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Dad.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Mom.Mom.Animator_I;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene
{
	public class LFS_HattereneParentsFailSafe : MonoBehaviour 
	{
		private HattereneParentDad_FailSafe HattereneParentDad_FailSafe;
		private HattereneParentMom_FailSafe HattereneParentMom_FailSafe;
		public void LoadFailSafeHattereneParents_AnimatorController()
		{
			LoadFailSafe_HattereneParentDad_FailSafe();
			LoadFailSafe_HattereneParentMom_FailSafe();	
		}
		private void LoadFailSafe_HattereneParentDad_FailSafe()
		{
			// HattereneParentDad_FailSafe.LoadFailSafeHattereneParentDad_AnimatorController();
		}
		private void LoadFailSafe_HattereneParentMom_FailSafe()
		{
			// HattereneParentMom_FailSafe.LoadFailSafeHattereneParentMom_AnimatorController();
		}	
	}
}