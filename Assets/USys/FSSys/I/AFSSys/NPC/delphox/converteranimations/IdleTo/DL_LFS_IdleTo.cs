using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Delphox.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Delphox.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Delphox.converteranimations.IdleTo
{
	public class DL_LFS_IdleTo : MonoBehaviour 
	{
		private DL_LFS_IdleToRun Delphox_LFS_IdleToRun;
		private DL_LFS_IdleToWalk Delphox_LFS_IdleToWalk;
		public void DL_LFS_IdleToController()
		{
			Load_DL_LFS_idleToRun();
			Load_DL_LFS_idleToWalk();
		}
		private void Load_DL_LFS_idleToRun()
		{
			Delphox_LFS_IdleToRun.DL_LFS_IdleToRunController();
		}
		private void Load_DL_LFS_idleToWalk()
		{
			Delphox_LFS_IdleToWalk.DL_LFS_IdleToWalkController();
		}
	}
}