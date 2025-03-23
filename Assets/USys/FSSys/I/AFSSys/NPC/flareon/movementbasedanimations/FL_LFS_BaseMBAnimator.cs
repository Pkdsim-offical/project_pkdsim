using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Flareon.movementbasedanimations.Jumping;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Flareon.movementbasedanimations.Running;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Flareon.movementbasedanimations.Strafe;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Flareon.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Flareon.movementbasedanimations
{
	public class Flareon_LFS_AnimatorBaseMovementController : MonoBehaviour 
	{
		private FL_LFS_Jumping Flareon_MBA_Jumping;
		
		private FL_LFS_Running Flareon_MBA_Running;


		private FL_LFS_Turning Flareon_MBA_Turning;

		private FL_LFS_Strafing Flareon_MBA_Strafe;

		public void FL_LFS_MovementAnimatorController()
		{
			Flareon_MBA_Running.FL_LFS_RunningController();

			Flareon_MBA_Jumping.FL_LFS_JumpingController();

			Flareon_MBA_Turning.FL_LFS_TurningController();	

			Flareon_MBA_Strafe.FL_LFS_StrafingController();
		}
	}
}