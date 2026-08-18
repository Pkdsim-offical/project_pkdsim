using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Espeon.Dad.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Espeon.Mom.Animator_I;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Espeon
{
	public class LFS_EspeonParentsFailSafe : MonoBehaviour 
	{
		private EspeonParentDad_FailSafe EspeonParentDad_FailSafe;
		private EspeonParentMom_FailSafe EspeonParentMom_FailSafe;
		public void LoadFailSafeEspeonParents_AnimatorController()
		{
			LoadFailSafe_EspeonParentDad_FailSafe();
			LoadFailSafe_EspeonParentMom_FailSafe();
		}
		private void LoadFailSafe_EspeonParentDad_FailSafe()
		{
			// EspeonParentDad_FailSafe.LoadFailSafeEspeonParentDad_AnimatorController();
		}
		private void LoadFailSafe_EspeonParentMom_FailSafe()
		{
			// EspeonParentMom_FailSafe.LoadFailSafeEspeonParentMom_AnimatorController();
		}
	}
}