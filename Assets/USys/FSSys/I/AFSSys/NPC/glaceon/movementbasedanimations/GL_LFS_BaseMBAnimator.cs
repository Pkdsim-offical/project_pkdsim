using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Glaceon.movementbasedanimations.Jumping;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Glaceon.movementbasedanimations.Running;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Glaceon.movementbasedanimations.Strafe;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Glaceon.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Glaceon.movementbasedanimations
{
	public class GLaceon_LFS_MovementBasedAnimatorController : MonoBehaviour 
	{
		private GL_LFS_Jumping Glaceon_MBA_Jumping;
		
		private GL_LFS_Running Glaceon_MBA_Running;

		private GL_LFS_Turning Glaceon_MBA_Turning;

		private GL_LFS_Strafing Glaceon_MBA_Strafe;

		public void GL_LFS_MovementAnimatorController()
		{
			Glaceon_MBA_Running.GL_LFS_RunningController();

			Glaceon_MBA_Jumping.GL_LFS_JumpingController();

			Glaceon_MBA_Turning.GL_LFS_TurningController();	

			Glaceon_MBA_Strafe.GL_LFS_StrafingController();
		}
	}
}