using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Espeon.idlebaseanimation.IdleSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Espeon.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Espeon.idlebaseanimation
{
	public class Espeon_LFS_AnimatorIdleController : MonoBehaviour 
	{
		private ES_LFS_IdleStanding Espeon_LFS_idlestanding;
		
		private ES_LFS_IdleSitting Espeon_LFS_idlesitting;
		
		public void ES_LFS_IdleAnimatorController()
		{
			ES_LFS_IdleStandingAnimatorController();
			ES_LFS_IdleSittingAnimatorController();
		}
		private void ES_LFS_IdleStandingAnimatorController()
		{
			Espeon_LFS_idlestanding.ES_LFS_IdleStandingController();
		}
		private void ES_LFS_IdleSittingAnimatorController()
		{
			Espeon_LFS_idlesitting.ES_LFS_IdleSittingController();
		}
	}
}