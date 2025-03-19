using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Frostlass.idlebaseanimation.IdleSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Frostlass.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Frostlass.idlebaseanimation
{
	public class Frostlass_LFS_IdleAnimatorController : MonoBehaviour 
	{
		private FR_LFS_IdleStanding Frostlass_LFS_idlestanding;
		
		private FR_LFS_IdleSitting Frostlass_LFS_idlesitting;
		
		public void	FR_LFS_IdleAnimatorController()
		{
			FR_LFS_IdleStandingAnimatorController();
			FR_LFS_IdleSittingAnimatorController();
		}
		private void FR_LFS_IdleStandingAnimatorController()
		{
			Frostlass_LFS_idlestanding.FR_LFS_IdleStandingController();
		}
		private void FR_LFS_IdleSittingAnimatorController()
		{
			Frostlass_LFS_idlesitting.FR_LFS_IdleSittingController();
		}
	}
}