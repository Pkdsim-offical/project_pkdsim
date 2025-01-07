using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Jolteon.movementbasedanimations.Jumping;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Jolteon.movementbasedanimations.Running;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Jolteon.movementbasedanimations.Strafe;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Jolteon.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.NPC.Jolteon.movementbasedanimations
{
	public class Jolteon_LFS_AnimatorMovementController : MonoBehaviour 
	{
		private JT_LFS_Jumping JT_MBA_Jumping;
		
		private JT_LFS_Running JT_MBA_Running;

		private JT_LFS_Turning JT_MBA_Turning;

		private JT_LFS_Strafing JT_MBA_Strafe;

		private void JT_BaseIdleAnimatorController()
		{
			JT_MBA_Running.JT_LFS_RunningController();

			JT_MBA_Jumping.JT_LFS_JumpingController();

			JT_MBA_Turning.JT_LFS_TurningController();	

			JT_MBA_Strafe.JT_LFS_StrafingController();
		}
	}
}