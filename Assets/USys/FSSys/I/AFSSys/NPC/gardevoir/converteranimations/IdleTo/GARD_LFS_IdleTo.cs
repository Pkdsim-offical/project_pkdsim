using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Gardevoir.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Gardevoir.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Gardevoir.converteranimations.IdleTo
{
	public class GARD_LFS_IdleTo : MonoBehaviour 
	{
		private GARD_LFS_IdleToWalk Gardevoir_LFS_IdleToWalk;
		private GARD_LFS_IdleToRun Gardevoir_LFS_IdleToRun;
		public void GARD_LFS_IdleToController()
		{
			Load_GARD_LFS_idleToRun();
			Load_GARD_LFS_idleToWalk();
		}
		private void Load_GARD_LFS_idleToRun()
		{
			Gardevoir_LFS_IdleToRun.GARD_LFS_IdleToRunController();
		}
		private void Load_GARD_LFS_idleToWalk()
		{
			Gardevoir_LFS_IdleToWalk.GARD_LFS_IdleToWalkController();
		}
	}
}