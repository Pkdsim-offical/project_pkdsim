using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Espeon.movementbasedanimations.Jumping;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Espeon.movementbasedanimations.Running;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Espeon.movementbasedanimations.Strafe;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Espeon.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Espeon.movementbasedanimations
{
	public class Espeon_LFS_AnimatorBaseMovementController : MonoBehaviour 
	{
		private ES_LFS_Jumping Espeon_LFS_Jumping;
		
		private ES_LFS_Running Espeon_LFS_Running;

		private ES_LFS_Turning Espeon_LFS_Turning;

		private ES_LFS_Strafing Espeon_LFS_Strafe;

		public void ES_LFS_MovementAnimatorController()
		{
			Espeon_LFS_Running.ES_LFS_RunningController();

			Espeon_LFS_Jumping.ES_LFS_JumpingController();

			Espeon_LFS_Turning.ES_LFS_TurningController();	

			Espeon_LFS_Strafe.ES_LFS_StrafingController();
		}
	}
}