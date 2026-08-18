using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Dad.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Mom.Animator_I;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina
{
	public class LFS_PrimarinaParentsFailSafe : MonoBehaviour 
	{
		private PrimarinaParentDad_FailSafe PrimarinaParentDad_FailSafe;
		private PrimarinaParentMom_FailSafe PrimarinaParentMom_FailSafe;
		public void LoadFailSafePrimarinaParents_AnimatorController()
		{
			LoadFailSafe_PrimarinaParentDad_FailSafe();
			LoadFailSafe_PrimarinaParentMom_FailSafe();	
		}
		private void LoadFailSafe_PrimarinaParentDad_FailSafe()
		{
			// PrimarinaParentDad_FailSafe.LoadFailSafePrimarinaParentDad_AnimatorController();
		}
		private void LoadFailSafe_PrimarinaParentMom_FailSafe()
		{
			// PrimarinaParentMom_FailSafe.LoadFailSafePrimarinaParentMom_AnimatorController();
		}	
	}
}