using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Vaporeon
{
	public class VAPOR_Animator : MonoBehaviour 
	{
		public Animator Vaporeon_Animator;
		public RuntimeAnimatorController someController;	
		private void Vaporeon_AnimatorController()
		{
			Vaporeon_Animator = gameObject.GetComponent<Animator>();
			Vaporeon_Animator.runtimeAnimatorController = someController;
		}
	}
}