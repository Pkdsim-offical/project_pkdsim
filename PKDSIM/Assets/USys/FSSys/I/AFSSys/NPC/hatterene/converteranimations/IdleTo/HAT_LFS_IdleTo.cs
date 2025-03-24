using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Hatterene.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Hatterene.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Hatterene.converteranimations.IdleTo
{
	public class HAT_LFS_IdleTo : MonoBehaviour 
	{
		
		private HAT_LFS_IdleToRun Hatterene_LFS_IdleToRun;
		private HAT_LFS_IdleToWalk Hatterene_LFS_IdleToWalk;
		public void HAT_LFS_IdleToController()
		{
			Load_HAT_LFS_idleToRun();
			Load_HAT_LFS_idleToWalk();
		}
		private void Load_HAT_LFS_idleToRun()
		{
			Hatterene_LFS_IdleToRun.HAT_LFS_IdleToRunController();
		}
		private void Load_HAT_LFS_idleToWalk()
		{
			Hatterene_LFS_IdleToWalk.HAT_LFS_IdleToWalkController();
		}
	}
}