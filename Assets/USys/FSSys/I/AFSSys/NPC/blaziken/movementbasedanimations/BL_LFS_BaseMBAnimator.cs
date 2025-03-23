using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Blaziken.movementbasedanimations.Jumping;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Blaziken.movementbasedanimations.Running;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Blaziken.movementbasedanimations.Strafe;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Blaziken.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Blaziken.movementbasedanimations
{
	public class Blaziken_LFS_AnimatorBaseMovementController : MonoBehaviour 
	{
		private BL_LFS_Jumping BL_MBA_Jumping;
		
		private BL_LFS_Running BL_MBA_Running;


		private BL_LFS_Turning BL_MBA_Turning;

		private BL_LFS_Strafing BL_MBA_Strafe;

		public void BL_LFS_MovementAnimatorController()
		{
			BL_MBA_Running.BL_LFS_RunningController();

			BL_MBA_Jumping.BL_LFS_JumpingController();

			BL_MBA_Turning.BL_LFS_TurningController();	

			BL_MBA_Strafe.BL_LFS_StrafingController();
		}
	}
}