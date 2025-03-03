using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Garchomp.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Garchomp.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Garchomp.converteranimations.IdleTo
{
	public class GARC_LFS_IdleTo : MonoBehaviour 
	{
		private GARC_LFS_IdleToRun Garchomp_LFS_IdleToRun;
		private GARC_LFS_IdleToWalk Garchomp_LFS_IdleToWalk;
		public void GARC_LFS_IdleToController()
		{
			Load_GARC_LFS_IdleToRun();
			Load_GARC_LFS_IdleToWalk();
		}
		private void Load_GARC_LFS_IdleToRun()
		{
			Garchomp_LFS_IdleToRun.GARC_LFS_IdleToRunController();
		}
		private void Load_GARC_LFS_IdleToWalk()
		{
			Garchomp_LFS_IdleToWalk.GARC_LFS_IdleToWalkController();
		}
	}
}