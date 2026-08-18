using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Sylveon.movementbasedanimations.Jumping;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Sylveon.movementbasedanimations.Running;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Sylveon.movementbasedanimations.Strafing;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Sylveon.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Sylveon.movementbasedanimations
{
	public class Sylveon_LFS_MovementAnimatorController : MonoBehaviour 
	{
		private SYL_LFS_Jumping Sylveon_MBA_Jumping;
		
		private SYL_LFS_Running Sylveon_MBA_Running;

		private SYL_LFS_Turning Sylveon_MBA_Turning;

		private SYL_LFS_Strafing Sylveon_MBA_Strafe;

		public void SYL_LFS_MovementAnimatorController()
		{
			Sylveon_MBA_Running.SYL_LFS_RunningController();

			Sylveon_MBA_Jumping.SYL_LFS_JumpingController();

			Sylveon_MBA_Turning.SYL_LFS_TurningController();	

			Sylveon_MBA_Strafe.SYL_LFS_StrafingController();
		}	
	}
}