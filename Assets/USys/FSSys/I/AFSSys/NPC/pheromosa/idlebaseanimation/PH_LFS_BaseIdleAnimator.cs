using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Pheromosa.idlebaseanimation.IdleSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Pheromosa.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Pheromosa.idlebaseanimation
{
	public class Pheromosa_LFS_IdleAnimatorController : MonoBehaviour 
	{
		private PH_LFS_IdleStanding PH_LFS_idlestanding;
		
		private PH_LFS_IdleSitting PH_LFS_idlesitting;
		
		public void	PH_LFS_IdleAnimatorController()
		{
			PH_LFS_IdleStandingAnimatorController();
			PH_LFS_IdleSittingAnimatorController();
		}
		private void PH_LFS_IdleStandingAnimatorController()
		{
			PH_LFS_idlestanding.PH_LFS_IdleStandingController();
		}
		private void PH_LFS_IdleSittingAnimatorController()
		{
			PH_LFS_idlesitting.PH_LFS_IdleSittingController();
		}
	}
}