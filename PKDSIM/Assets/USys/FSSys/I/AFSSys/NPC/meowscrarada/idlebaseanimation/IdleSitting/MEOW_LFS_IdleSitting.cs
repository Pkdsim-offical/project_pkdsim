using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Meowscarada.idlebaseanimation.IdleSitting
{
	public class MEOW_LFS_IdleSitting : MonoBehaviour 
	{
		private Animator Meowscarada_Animator;
		public void MEOW_LFS_IdleSittingController()
		{
			Meowscarada_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Meowscarada_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}