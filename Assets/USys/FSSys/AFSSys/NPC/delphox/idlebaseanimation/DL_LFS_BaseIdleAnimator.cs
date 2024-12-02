using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Delphox.idlebaseanimation.IdleSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Delphox.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Delphox.idlebaseanimation
{
	public class Delphox_LFS_IdleAnimatorController : MonoBehaviour 
	{
		private DL_LFS_IdleStanding DL_LFS_idlestanding;
		
		private DL_LFS_IdleSitting DL_LFS_idlesitting;
		
		public void	DL_LFS_IdleAnimatorController()
		{
			DL_LFS_IdleStandingAnimatorController();
			DL_LFS_IdleSittingAnimatorController();
		}
		private void DL_LFS_IdleStandingAnimatorController()
		{
			DL_LFS_idlestanding.DL_LFS_IdleStandingController();
		}
		private void DL_LFS_IdleSittingAnimatorController()
		{
			DL_LFS_idlesitting.DL_LFS_IdleSittingController();
		}
	}
}