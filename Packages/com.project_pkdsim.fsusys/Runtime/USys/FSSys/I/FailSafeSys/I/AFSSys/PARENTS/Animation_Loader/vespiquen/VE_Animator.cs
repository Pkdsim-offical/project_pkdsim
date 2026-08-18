using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Mom.Animator_I;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen
{
	public class LFS_VespiquenParentsFailSafe : MonoBehaviour 
	{
		private VespiquenParentDad_FailSafe VespiquenParentDad_FailSafe;
		private VespiquenParentMom_FailSafe VespiquenParentMom_FailSafe;
		public void LoadFailSafeVespiquenParents_AnimatorController()
		{
			LoadFailSafe_VespiquenParentDad_FailSafe();
			LoadFailSafe_VespiquenParentMom_FailSafe();	
		}
		private void LoadFailSafe_VespiquenParentDad_FailSafe()
		{
			// VespiquenParentDad_FailSafe.LoadFailSafeVespiquenParentDad_AnimatorController();
		}
		private void LoadFailSafe_VespiquenParentMom_FailSafe()
		{
			// VespiquenParentMom_FailSafe.LoadFailSafeVespiquenParentMom_AnimatorController();
		}
	}
}