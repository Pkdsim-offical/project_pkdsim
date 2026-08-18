using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.PLAYER.movementbasedanimations.Jumping;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.PLAYER.movementbasedanimations.Running;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.PLAYER.movementbasedanimations.Strafing;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.PLAYER.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.PLAYER.movementbasedanimations
{
	public class Player_LFS_MovementAnimatorController : MonoBehaviour 
	{
		private PL_LFS_Jumping PL_MBA_Jumping;
		
		private PL_LFS_Running PL_MBA_Running;


		private PL_LFS_Turning PL_MBA_Turning;

		private PL_LFS_Strafing PL_MBA_Strafe;

		public void PL_LFS_MovementAnimatorController()
		{
			PL_MBA_Running.PL_LFS_RunningController();

			PL_MBA_Jumping.PL_LFS_JumpingController();

			PL_MBA_Turning.PL_LFS_TurningController();	

			PL_MBA_Strafe.PL_LFS_StrafingController();
		}
	}
}