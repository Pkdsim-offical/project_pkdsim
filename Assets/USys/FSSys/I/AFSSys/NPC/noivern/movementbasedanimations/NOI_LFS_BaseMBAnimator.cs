using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Noivern.movementbasedanimations.Jumping;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Noivern.movementbasedanimations.Running;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Noivern.movementbasedanimations.Strafe;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Noivern.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Noivern.movementbasedanimations
{
	public class Noivern_LFS_AnimatorBaseMovementController : MonoBehaviour 
	{
		private NOI_LFS_Jumping Noivern_MBA_Jumping;
		
		private NOI_LFS_Running Noivern_MBA_Running;


		private NOI_LFS_Turning Noivern_MBA_Turning;

		private NOI_LFS_Strafing Noivern_MBA_Strafe;

		public void NOI_LFS_MovementAnimatorController()
		{
			Noivern_MBA_Running.NOI_LFS_RunningController();

			Noivern_MBA_Jumping.NOI_LFS_JumpingController();

			Noivern_MBA_Turning.NOI_LFS_TurningController();	

			Noivern_MBA_Strafe.NOI_LFS_StrafingController();
		}
	}
}