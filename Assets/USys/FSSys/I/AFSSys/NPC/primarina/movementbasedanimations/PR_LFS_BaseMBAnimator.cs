using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Primarina.movementbasedanimations.Jumping;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Primarina.movementbasedanimations.Running;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Primarina.movementbasedanimations.Strafe;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Primarina.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Primarina.movementbasedanimations
{
	public class Primarina_LFS_AnimatorBaseMovementController : MonoBehaviour 
	{
		private PR_LFS_Jumping Primarina_MBA_Jumping;
		
		private PR_LFS_Running Primarina_MBA_Running;


		private PR_LFS_Turning Primarina_MBA_Turning;

		private PR_LFS_Strafing Primarina_MBA_Strafe;

		public void PR_LFS_MovementAnimatorController()
		{
			Primarina_MBA_Running.PR_LFS_RunningController();

			Primarina_MBA_Jumping.PR_LFS_JumpingController();

			Primarina_MBA_Turning.PR_LFS_TurningController();	

			Primarina_MBA_Strafe.PR_LFS_StrafingController();
		}
	}
}