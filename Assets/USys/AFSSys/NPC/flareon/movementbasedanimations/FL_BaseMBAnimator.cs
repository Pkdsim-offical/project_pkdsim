using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Flareon.movementbasedanimations.Jumping;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Flareon.movementbasedanimations.Running;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Flareon.movementbasedanimations.Strafe;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Flareon.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Flareon.movementbasedanimations
{
	public class Flareon_LFS_AnimatorBaseMovementController : MonoBehaviour 
	{
		private FL_LFS_Jumping FL_MBA_Jumping;
		
		private FL_LFS_Running FL_MBA_Running;


		private FL_LFS_Turning FL_MBA_Turning;

		private FL_LFS_Strafing FL_MBA_Strafe;

		public void FL_LFS_MovementAnimatorController()
		{
			FL_MBA_Running.FL_LFS_RunningController();

			FL_MBA_Jumping.FL_LFS_JumpingController();

			FL_MBA_Turning.FL_LFS_TurningController();	

			FL_MBA_Strafe.FL_LFS_StrafingController();
		}
	}
}