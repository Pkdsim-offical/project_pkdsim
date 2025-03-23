using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Jolteon.movementbasedanimations.Jumping;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Jolteon.movementbasedanimations.Running;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Jolteon.movementbasedanimations.Strafe;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Jolteon.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Jolteon.movementbasedanimations
{
	public class Jolteon_LFS_AnimatorMovementController : MonoBehaviour 
	{
		private JT_LFS_Jumping Jolteon_MBA_Jumping;
		
		private JT_LFS_Running Jolteon_MBA_Running;

		private JT_LFS_Turning Jolteon_MBA_Turning;

		private JT_LFS_Strafing Jolteon_MBA_Strafe;

		public void JT_LFS_BaseIdleAnimatorController()
		{
			Jolteon_MBA_Running.JT_LFS_RunningController();

			Jolteon_MBA_Jumping.JT_LFS_JumpingController();

			Jolteon_MBA_Turning.JT_LFS_TurningController();	

			Jolteon_MBA_Strafe.JT_LFS_StrafingController();
		}
	}
}