using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Garchomp.idlebaseanimation.IdleSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Garchomp.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Garchomp.idlebaseanimation
{
	public class Garchomp_LFS_IdleAnimatorController : MonoBehaviour 
	{
		private GARC_LFS_IdleStanding Garchomp_LFS_idlestanding;
		
		private GARC_LFS_IdleSitting Garchomp_LFS_idlesitting;
		
		public void	GARC_LFS_IdleAnimatorController()
		{
			GARC_LFS_IdleStandingAnimatorController();
			GARC_LFS_IdleSittingAnimatorController();
		}
		private void GARC_LFS_IdleStandingAnimatorController()
		{
			Garchomp_LFS_idlestanding.GARC_LFS_IdleStandingController();
		}
		private void GARC_LFS_IdleSittingAnimatorController()
		{
			Garchomp_LFS_idlesitting.GARC_LFS_IdleSittingController();
		}
	}
}