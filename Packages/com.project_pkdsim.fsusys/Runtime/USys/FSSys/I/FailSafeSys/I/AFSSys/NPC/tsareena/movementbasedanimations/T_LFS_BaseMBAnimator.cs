using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Tsareena.movementbasedanimations.Jumping;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Tsareena.movementbasedanimations.Running;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Tsareena.movementbasedanimations.Strafing;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Tsareena.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Tsareena.movementbasedanimations
{
	public class Tsareena_LFS_MovementAnimatorController : MonoBehaviour 
	{
		private T_LFS_Jumping Tsareena_MBA_Jumping;
		
		private T_LFS_Running Tsareena_MBA_Running;


		private T_LFS_Turning Tsareena_MBA_Turning;

		private T_LFS_Strafing Tsareena_MBA_Strafe;

		public void T_LFS_MovementAnimatorController()
		{
			Tsareena_MBA_Running.T_LFS_RunningController();

			Tsareena_MBA_Jumping.T_LFS_JumpingController();

			Tsareena_MBA_Turning.T_LFS_TurningController();	

			Tsareena_MBA_Strafe.T_LFS_StrafingController();
		}
	}
}