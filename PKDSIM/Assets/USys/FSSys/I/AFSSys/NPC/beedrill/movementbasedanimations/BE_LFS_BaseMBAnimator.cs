using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Beedrill.movementbasedanimations.Jumping;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Beedrill.movementbasedanimations.Running;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Beedrill.movementbasedanimations.Strafe;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Beedrill.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Beedrill.movementbasedanimations
{
	public class Beedrill_LFS_AnimatorBaseMovementController : MonoBehaviour 
	{
		private BE_LFS_Jumping Beedrill_MBA_Jumping;
		
		private BE_LFS_Running Beedrill_MBA_Running;


		private BE_LFS_Turning Beedrill_MBA_Turning;

		private BE_LFS_Strafing Beedrill_MBA_Strafe;

		public void BE_LFS_MovementAnimatorController()
		{
			Beedrill_MBA_Running.BE_LFS_RunningController();

			Beedrill_MBA_Jumping.BE_LFS_JumpingController();

			Beedrill_MBA_Turning.BE_LFS_TurningController();	

			Beedrill_MBA_Strafe.BE_LFS_StrafingController();
		}
	}
}