using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lopunny.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lopunny.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lopunny.converteranimations.IdleTo
{
	public class LO_LFS_IdleTo : MonoBehaviour 
	{
		private LO_LFS_IdleToRun Lopunny_LFS_IdleToRun;
		private LO_LFS_IdleToWalk Lopunny_LFS_IdleToWalk;
		public void LO_LFS_IdleToController()
		{
			Load_LO_LFS_idleToRun();
			Load_LO_LFS_idleToWalk();
		}
		private void Load_LO_LFS_idleToRun()
		{
			Lopunny_LFS_IdleToRun.LO_LFS_IdleToRunController();
		}
		private void Load_LO_LFS_idleToWalk()
		{
			Lopunny_LFS_IdleToWalk.LO_LFS_IdleToWalkController();
		}
	}
}