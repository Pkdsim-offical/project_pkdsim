using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.NPC.Espeon.idlebaseanimation.IdleSitting
{
	public class ES_LFS_IdleSitting : MonoBehaviour 
	{
		public Animator Espeon_Animator;
		public void ES_LFS_IdleSittingController()
		{
			Espeon_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Espeon_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}