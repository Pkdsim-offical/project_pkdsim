using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Vespiquen.movementbasedanimations.Jumping;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Vespiquen.movementbasedanimations.Running;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Vespiquen.movementbasedanimations.Strafe;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Vespiquen.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Vespiquen.movementbasedanimations
{
	public class Vespiquen_LFS_AnimatorBaseMovementController : MonoBehaviour 
	{
		private VE_LFS_Jumping VE_MBA_Jumping;
		
		private VE_LFS_Running VE_MBA_Running;


		private VE_LFS_Turning VE_MBA_Turning;

		private VE_LFS_Strafing VE_MBA_Strafe;

		public void VE_LFS_MovementAnimatorController()
		{
			VE_MBA_Running.VE_LFS_RunningController();

			VE_MBA_Jumping.VE_LFS_JumpingController();

			VE_MBA_Turning.VE_LFS_TurningController();	

			VE_MBA_Strafe.VE_LFS_StrafingController();
		}
	}
}