using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Dad.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Mom.Animator_I;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir
{
	public class LFS_GardevoirParentsFailSafe : MonoBehaviour 
	{
		private GardevoirParentDad_FailSafe GardevoirParentDad_FailSafe;
		private GardevoirParentMom_FailSafe GardevoirParentMom_FailSafe;
		public void LoadFailSafeGardevoirParents_AnimatorController()
		{
			LoadFailSafe_GardevoirParentDad_FailSafe();
			LoadFailSafe_GardevoirParentMom_FailSafe();	
		}
		private void LoadFailSafe_GardevoirParentDad_FailSafe()
		{
			// GardevoirParentDad_FailSafe.LoadFailSafeGardevoirParentDad_AnimatorController();
		}
		private void LoadFailSafe_GardevoirParentMom_FailSafe()
		{
			// GardevoirParentMom_FailSafe.LoadFailSafeGardevoirParentMom_AnimatorController();
		}	
	}
}