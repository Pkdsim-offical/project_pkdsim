using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Delphox.movementbasedanimations.Jumping;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Delphox.movementbasedanimations.Running;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Delphox.movementbasedanimations.Strafe;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Delphox.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Delphox.movementbasedanimations
{
	public class Delphox_LFS_AnimatorBaseMovementController : MonoBehaviour 
	{
		private DL_LFS_Jumping DL_MBA_Jumping;
		
		private DL_LFS_Running DL_MBA_Running;


		private DL_LFS_Turning DL_MBA_Turning;

		private DL_LFS_Strafing DL_MBA_Strafe;

		public void DL_LFS_MovementAnimatorController()
		{
			DL_MBA_Running.DL_LFS_RunningController();

			DL_MBA_Jumping.DL_LFS_JumpingController();

			DL_MBA_Turning.DL_LFS_TurningController();	

			DL_MBA_Strafe.DL_LFS_StrafingController();
		}
	}
}