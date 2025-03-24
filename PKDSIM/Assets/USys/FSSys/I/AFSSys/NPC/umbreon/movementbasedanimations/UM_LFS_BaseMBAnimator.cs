using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Umbreon.movementbasedanimations.Strafe;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Umbreon.movementbasedanimations.Jumping;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Umbreon.movementbasedanimations.Running;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Umbreon.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Umbreon.movementbasedanimations
{
	public class Umbreon_LFS_AnimatorBaseMovementController : MonoBehaviour 
	{
		private UM_LFS_Jumping Umbreon_MBA_Jumping;
		
		private UM_LFS_Running Umbreon_MBA_Running;

		private UM_LFS_Turning Umbreon_MBA_Turning;

		private UM_LFS_Strafing Umbreon_MBA_Strafe;

		public void UM_LFS_MovementAnimatorController()
		{
			Umbreon_MBA_Running.UM_LFS_RunningController();

			Umbreon_MBA_Jumping.UM_LFS_JumpingController();

			Umbreon_MBA_Turning.UM_LFS_TurningController();	

			Umbreon_MBA_Strafe.UM_LFS_StrafingController();
		}	
	}
}