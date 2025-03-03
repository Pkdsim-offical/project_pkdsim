using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Umbreon.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Umbreon.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Umbreon.converteranimations.IdleTo
{
	public class UM_LFS_IdleTo : MonoBehaviour 
	{
		private UM_LFS_IdleToRun Umbreon_LFS_IdleToRun;
		private UM_LFS_IdleToWalk Umbreon_LFS_IdleToWalk;

		public void UM_LFS_IdleToController()
		{
			Load_UM_LFS_idleToRun();
			Load_UM_LFS_idleToWalk();
		}
		private void Load_UM_LFS_idleToRun()
		{
			Umbreon_LFS_IdleToRun.UM_LFS_IdleToRunController();
		}
		private void Load_UM_LFS_idleToWalk()
		{
			Umbreon_LFS_IdleToWalk.UM_LFS_IdleToWalkController();
		}
	}
}