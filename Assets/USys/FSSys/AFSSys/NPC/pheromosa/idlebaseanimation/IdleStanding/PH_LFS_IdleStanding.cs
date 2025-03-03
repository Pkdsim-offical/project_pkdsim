using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Pheromosa.idlebaseanimation.IdleStanding
{
	public class PH_LFS_IdleStanding : MonoBehaviour 
	{
		public Animator Pheromosa_Animator;
		public void PH_LFS_IdleStandingController()
		{
			// Assign the idle animation clip
			Pheromosa_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Pheromosa_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}