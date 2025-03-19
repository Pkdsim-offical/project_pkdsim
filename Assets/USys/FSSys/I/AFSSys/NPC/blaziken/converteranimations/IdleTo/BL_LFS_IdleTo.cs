using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Blaziken.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Blaziken.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Blaziken.converteranimations.IdleTo
{
	public class BL_LFS_IdleTo : MonoBehaviour 
	{
		private BL_LFS_IdleToRun Blaziken_LFS_IdleToRun;
		private BL_LFS_IdleToWalk Blaziken_LFS_IdleToWalk;
		public void BL_LFS_IdleToController()
		{
			Load_BL_LFS_idleToRun();
			Load_BL_LFS_idleToWalk();
		}
		private void Load_BL_LFS_idleToRun()
		{
			Blaziken_LFS_IdleToRun.BL_LFS_IdleToRunController();
		}
		private void Load_BL_LFS_idleToWalk()
		{
			Blaziken_LFS_IdleToWalk.BL_LFS_IdleToWalkController();
		}
	}
}