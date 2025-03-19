using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Sylveon.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Sylveon.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Sylveon.converteranimations.IdleTo
{
	public class SYL_LFS_IdleTo : MonoBehaviour 
	{
		private SYL_LFS_IdleToRun Sylveon_LFS_IdleToRun;
		private SYL_LFS_IdleToWalk Sylveon_LFS_IdleToWalk;
		public void SYL_LFS_IdleToController()
		{
			Load_SYL_LFS_idleToRun();
			Load_SYL_LFS_idleToWalk();
		}
		private void Load_SYL_LFS_idleToRun()
		{
			Sylveon_LFS_IdleToRun.SYL_LFS_IdleToRunController();
		}
		private void Load_SYL_LFS_idleToWalk()
		{
			Sylveon_LFS_IdleToWalk.SYL_LFS_IdleToWalkController();
		}
	}
}