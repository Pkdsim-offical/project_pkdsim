using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Dad.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Mom.Animator_I;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario
{
	public class LFS_LucarioParentsFailSafe : MonoBehaviour 
	{
		private LucarioParentDad_FailSafe LucarioParentDad_FailSafe;
		private LucarioParentMom_FailSafe LucarioParentMom_FailSafe;
		public void LoadFailSafeLucarioParents_AnimatorController()
		{
			LoadFailSafe_LucarioParentDad_FailSafe();
			LoadFailSafe_LucarioParentMom_FailSafe();	
		}
		private void LoadFailSafe_LucarioParentDad_FailSafe()
		{
			// LucarioParentDad_FailSafe.LoadFailSafeLucarioParentDad_AnimatorController();
		}
		private void LoadFailSafe_LucarioParentMom_FailSafe()
		{
			// LucarioParentMom_FailSafe.LoadFailSafeLucarioParentMom_AnimatorController();
		}	
	}
}