using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Primarina.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Primarina.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Primarina.converteranimations.IdleTo
{
	public class PR_LFS_IdleTo : MonoBehaviour 
	{
		private PR_LFS_IdleToRun Primarina_LFS_IdleToRun;
		private PR_LFS_IdleToWalk Primarina_LFS_IdleToWalk;
		public void PR_LFS_IdleToController()
		{
			Load_PR_LFS_IdleToRun();
			Load_PR_LFS_IdleToWalk();
		}
		private void Load_PR_LFS_IdleToRun()
		{
			Primarina_LFS_IdleToRun.PR_LFS_IdleToRunController();
		}
		private void Load_PR_LFS_IdleToWalk()
		{
			Primarina_LFS_IdleToWalk.PR_LFS_IdleToWalkController();
		}
	}
}