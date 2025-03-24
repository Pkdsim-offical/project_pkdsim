using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Gardevoir.idlebaseanimation.IdleSitting
{
	public class GARD_LFS_IdleSitting : MonoBehaviour 
	{
		private Animator Gardevoir_Animator;
		public void GARD_LFS_IdleSittingController()
		{
			Gardevoir_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Gardevoir_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}