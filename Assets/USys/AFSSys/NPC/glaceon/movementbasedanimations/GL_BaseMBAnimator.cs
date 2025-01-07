using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Glaceon.movementbasedanimations.Jumping;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Glaceon.movementbasedanimations.Running;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Glaceon.movementbasedanimations.Strafe;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Glaceon.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Glaceon.movementbasedanimations
{
	public class GLaceon_LFS_MovementBasedAnimatorController : MonoBehaviour 
	{
		private GL_LFS_Jumping GL_MBA_Jumping;
		
		private GL_LFS_Running GL_MBA_Running;

		private GL_LFS_Turning GL_MBA_Turning;

		private GL_LFS_Strafing GL_MBA_Strafe;

		public void GL_LFS_MovementAnimatorController()
		{
			GL_MBA_Running.GL_LFS_RunningController();

			GL_MBA_Jumping.GL_LFS_JumpingController();

			GL_MBA_Turning.GL_LFS_TurningController();	

			GL_MBA_Strafe.GL_LFS_StrafingController();
		}
	}
}