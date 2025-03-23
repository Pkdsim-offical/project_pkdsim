using project_pkdsim.Assets.Models.ANIMATOR.NPC.Salazzle.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.Assets.Models.ANIMATOR.NPC.Salazzle.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Salazzle.converteranimations.IdleTo
{
	public class SA_LFS_IdleTo : MonoBehaviour 
	{
		private SA_LFS_IdleToRun Salazzle_LFS_IdleToRun;
		private SA_LFS_IdleToWalk Salazzle_LFS_IdleToWalk;
		public void SA_LFS_IdleToController()
		{
			SA_LFS_IdleToRun();
			SA_LFS_IdleToWalk();
		}
		private void SA_LFS_IdleToRun()
		{
			Salazzle_LFS_IdleToRun.SA_LFS_IdleToRunController();
		}
		private void SA_LFS_IdleToWalk()
		{
			Salazzle_LFS_IdleToWalk.SA_LFS_IdleToWalkController();
		}
	}
}