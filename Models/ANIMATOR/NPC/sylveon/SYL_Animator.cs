using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.NPC.Sylveon
{
	public class SYL_Animator : MonoBehaviour 
	{
		public Animator Sylveon_Animator;
		public RuntimeAnimatorController someController;
		private void Sylveon_AnimatorController()
		{
			Sylveon_Animator = gameObject.GetComponent<Animator>();
			Sylveon_Animator.runtimeAnimatorController = someController;
		}
	}
}