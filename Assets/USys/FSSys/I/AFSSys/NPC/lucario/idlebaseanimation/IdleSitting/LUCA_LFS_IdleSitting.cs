using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lucario.idlebaseanimation.IdleSitting
{
	public class LUCA_LFS_IdleSitting : MonoBehaviour 
	{
		private Animator Lucario_Animator;
		public void LUCA_LFS_IdleSittingController()
		{
			Lucario_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Lucario_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}