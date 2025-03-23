using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Cinderace.movementbasedanimations.Jumping;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Cinderace.movementbasedanimations.Running;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Cinderace.movementbasedanimations.Strafe;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Cinderace.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Cinderace.movementbasedanimations
{
	public class Cinderace_LFS_AnimatorBaseMovementController : MonoBehaviour 
	{
		private C_LFS_Jumping C_MBA_Jumping;
		
		private C_LFS_Running C_MBA_Running;


		private C_LFS_Turning C_MBA_Turning;

		private C_LFS_Strafing C_MBA_Strafe;

		public void C_LFS_MovementAnimatorController()
		{
			C_MBA_Running.C_LFS_RunningController();

			C_MBA_Jumping.C_LFS_JumpingController();

			C_MBA_Turning.C_LFS_TurningController();	

			C_MBA_Strafe.C_LFS_StrafingController();
		}
	}
}