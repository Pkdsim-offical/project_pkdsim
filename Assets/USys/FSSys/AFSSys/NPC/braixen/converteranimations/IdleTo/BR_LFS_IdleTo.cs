using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Braixen.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Braixen.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Braixen.converteranimations.IdleTo
{
	public class BR_LFS_IdleTo : MonoBehaviour 
	{
		private BR_LFS_IdleToRun Braixen_LFS_IdleToRun;
		private BR_LFS_IdleToWalk Braixen_LFS_IdleToWalk;
		public void BR_LFS_IdleToController()
		{
			Load_BR_LFS_idleToRun();
			Load_BR_LFS_idleToWalk();
		}
		private void Load_BR_LFS_idleToRun()
		{
			Braixen_LFS_IdleToRun.BR_LFS_IdleToRunController();
		}
		private void Load_BR_LFS_idleToWalk()
		{
			Braixen_LFS_IdleToWalk.BR_LFS_IdleToWalkController();
		}
	}
}