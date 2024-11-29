using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.NPC.Glaceon
{
	public class GL_Animator : MonoBehaviour 
	{
		public Animator Glaceon_Animator;
		public RuntimeAnimatorController someController;

		private void Glaceon_AnimatorController()
		{
			Glaceon_Animator = gameObject.GetComponent<Animator>();
			Glaceon_Animator.runtimeAnimatorController = someController;
		}
	}
}