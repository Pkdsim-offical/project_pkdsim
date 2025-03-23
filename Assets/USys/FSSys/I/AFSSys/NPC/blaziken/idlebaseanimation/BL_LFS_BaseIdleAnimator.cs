using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Blaziken.idlebaseanimation.IdleSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Blaziken.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Blaziken.idlebaseanimation
{
	public class Blaziken_LFS_IdleAnimatorController : MonoBehaviour 
	{
		private BL_LFS_IdleStanding BL_LFS_idlestanding;
		
		private BL_LFS_IdleSitting BL_LFS_idlesitting;
		
		public void	BL_LFS_IdleAnimatorController()
		{
			BL_LFS_IdleStandingAnimatorController();
			BL_LFS_IdleSittingAnimatorController();
		}
		private void BL_LFS_IdleStandingAnimatorController()
		{
			BL_LFS_idlestanding.BL_LFS_IdleStandingController();
		}
		private void BL_LFS_IdleSittingAnimatorController()
		{
			BL_LFS_idlesitting.BL_LFS_IdleSittingController();
		}
	}
}