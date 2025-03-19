using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Braixen.movementbasedanimations.Jumping;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Braixen.movementbasedanimations.Running;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Braixen.movementbasedanimations.Strafe;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Braixen.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Braixen.movementbasedanimations
{
	public class Braixen_LFS_AnimatorBaseMovementController : MonoBehaviour 
	{
		private BR_LFS_Jumping BR_MBA_Jumping;
		
		private BR_LFS_Running BR_MBA_Running;


		private BR_LFS_Turning BR_MBA_Turning;

		private BR_LFS_Strafing BR_MBA_Strafe;

		public void BR_LFS_MovementAnimatorController()
		{
			BR_MBA_Running.BR_LFS_RunningController();

			BR_MBA_Jumping.BR_LFS_JumpingController();

			BR_MBA_Turning.BR_LFS_TurningController();	

			BR_MBA_Strafe.BR_LFS_StrafingController();
		}
	}
}