using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Dad.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.Animator_I;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny
{
	public class LFS_LopunnyParentsFailSafe : MonoBehaviour 
	{
		private LopunnyParentDad_FailSafe LopunnyParentDad_FailSafe;
		private LopunnyParentMom_FailSafe LopunnyParentMom_FailSafe;
		public void LoadFailSafeLopunnyParents_AnimatorController()
		{
			LoadFailSafe_LopunnyParentDad_FailSafe();
			LoadFailSafe_LopunnyParentMom_FailSafe();	
		}
		private void LoadFailSafe_LopunnyParentDad_FailSafe()
		{
			// LopunnyParentDad_FailSafe.LoadFailSafeLopunnyParentDad_AnimatorController();
		}
		private void LoadFailSafe_LopunnyParentMom_FailSafe()
		{
			// LopunnyParentMom_FailSafe.LoadFailSafeLopunnyParentMom_AnimatorController();
		}	
	}
}