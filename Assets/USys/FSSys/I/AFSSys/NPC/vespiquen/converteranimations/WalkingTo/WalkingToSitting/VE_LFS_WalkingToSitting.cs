using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Vespiquen.converteranimations.WalkingTo.WalkingToSitting
{
	public class VE_LFS_WalkingToSitting : MonoBehaviour 
	{
		private Animator Vespiquen_Animator;
		public void VE_LFS_WalkingToSittingController()
		{
			Vespiquen_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Vespiquen_Animator.Play("WalkingTo_Sitting");         // Start in the WalkingTo animation state
		}
	}
}