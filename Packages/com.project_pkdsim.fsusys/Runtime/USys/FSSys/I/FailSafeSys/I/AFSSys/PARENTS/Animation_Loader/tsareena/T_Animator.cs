using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Dad.Animator_I;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Mom.Animator_I;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena
{
	public class LFS_TsareenaParentsFailSafe : MonoBehaviour 
	{
		private TsareenaParentDad_FailSafe TsareenaParentDad_FailSafe;
		private TsareenaParentMom_FailSafe TsareenaParentMom_FailSafe;
		public void LoadFailSafeTsareenaParents_AnimatorController()
		{
			LoadFailSafe_TsareenaParentDad_FailSafe();
			LoadFailSafe_TsareenaParentMom_FailSafe();	
		}
		private void LoadFailSafe_TsareenaParentDad_FailSafe()
		{
			// TsareenaParentDad_FailSafe.LoadFailSafeTsareenaParentDad_AnimatorController();
		}
		private void LoadFailSafe_TsareenaParentMom_FailSafe()
		{
			// TsareenaParentMom_FailSafe.LoadFailSafeTsareenaParentMom_AnimatorController();
		}
	}
}