using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Gardevoir.idlebaseanimation.IdleSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Gardevoir.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Gardevoir.idlebaseanimation
{
	public class Gardevoir_LFS_IdleAnimatorController : MonoBehaviour 
	{
		private GARD_LFS_IdleStanding Gardevoir_LFS_idlestanding;
		
		private GARD_LFS_IdleSitting Gardevoir_LFS_idlesitting;
		
		public void	GARD_LFS_IdleAnimatorController()
		{
			GARD_LFS_IdleStandingAnimatorController();
			GARD_LFS_IdleSittingAnimatorController();
		}
		private void GARD_LFS_IdleStandingAnimatorController()
		{
			Gardevoir_LFS_idlestanding.GARD_LFS_IdleStandingController();
		}
		private void GARD_LFS_IdleSittingAnimatorController()
		{
			Gardevoir_LFS_idlesitting.GARD_LFS_IdleSittingController();
		}
	}
}