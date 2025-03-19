using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Pheromosa.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Pheromosa.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Pheromosa.converteranimations.IdleTo
{
	public class PH_LFS_IdleTo : MonoBehaviour 
	{
		private PH_LFS_IdleToRun Pheromosa_LFS_IdleToRun;
		private PH_LFS_IdleToWalk Pheromosa_LFS_IdleToWalk;
		public void PH_LFS_IdleToController()
		{
			Load_PH_LFS_idleToRun();
			Load_PH_LFS_idleToWalk();
		}
		private void Load_PH_LFS_idleToRun()
		{
			Pheromosa_LFS_IdleToRun.PH_LFS_IdleToRunController();
		}
		private void Load_PH_LFS_idleToWalk()
		{
			Pheromosa_LFS_IdleToWalk.PH_LFS_IdleToWalkController();
		}
	}
}