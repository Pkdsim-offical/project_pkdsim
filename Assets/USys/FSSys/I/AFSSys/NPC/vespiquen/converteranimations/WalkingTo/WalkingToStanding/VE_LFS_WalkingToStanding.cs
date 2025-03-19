using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Vespiquen.converteranimations.WalkingTo.WalkingToStanding
{
	public class VE_LFS_WalkingToStanding : MonoBehaviour 
	{
		private Animator Vespiquen_Animator;
		public void VE_LFS_WalkingToStandingController()
		{
			Vespiquen_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Vespiquen_Animator.Play("WalkingTo_Standing");         // Start in the WalkingToStandingCon state
		}
	}
}