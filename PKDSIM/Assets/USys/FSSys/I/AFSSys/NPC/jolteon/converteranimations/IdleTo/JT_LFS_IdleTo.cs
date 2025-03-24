using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Jolteon.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Jolteon.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Jolteon.converteranimations.IdleTo
{
	public class JT_LFS_IdleTo : MonoBehaviour 
	{
		private JT_LFS_IdleToRun Jolteon_LFS_IdleToRun;
		private JT_LFS_IdleToWalk Jolteon_LFS_IdleToWalk;
		public void JT_LFS_IdleToController()
		{
			Load_JT_LFS_idleToRun();
			Load_JT_LFS_idleToWalk();
		}
		private void Load_JT_LFS_idleToRun()
		{
			Jolteon_LFS_IdleToRun.JT_LFS_IdleToRunController();
		}
		private void Load_JT_LFS_idleToWalk()
		{
			Jolteon_LFS_IdleToWalk.JT_LFS_IdleToWalkController();
		}
	}
}