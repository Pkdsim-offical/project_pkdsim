using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Dad.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.Animator_I;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult
{
	public class LFS_DragapultParentsFailSafe : MonoBehaviour 
	{
		private DragapultParentDad_FailSafe DragapultParentDad_FailSafe;
		private DragapultParentMom_FailSafe DragapultParentMom_FailSafe;
		public void LoadFailSafeDragapultParents_AnimatorController()
		{
			LoadFailSafe_DragapultParentDad_FailSafe();
			LoadFailSafe_DragapultParentMom_FailSafe();	
		}
		private void LoadFailSafe_DragapultParentDad_FailSafe()
		{
			// DragapultParentDad_FailSafe.LoadFailSafeDragapultParentDad_AnimatorController();
		}
		private void LoadFailSafe_DragapultParentMom_FailSafe()
		{
			// DragapultParentMom_FailSafe.LoadFailSafeDragapultParentMom_AnimatorController();
		}
	}
}