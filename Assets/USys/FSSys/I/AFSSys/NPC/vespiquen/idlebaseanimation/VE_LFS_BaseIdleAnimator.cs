using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Vespiquen.idlebaseanimation.IdleSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Vespiquen.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Vespiquen.idlebaseanimation
{
	public class Vespiquen_LFS_IdleAnimatorController : MonoBehaviour 
	{
		private VE_LFS_IdleStanding VE_LFS_idlestanding;
		
		private VE_LFS_IdleSitting VE_LFS_idlesitting;
		
		public void	VE_LFS_IdleAnimatorController()
		{
			VE_LFS_IdleStandingAnimatorController();
			VE_LFS_IdleSittingAnimatorController();
		}
		private void VE_LFS_IdleStandingAnimatorController()
		{
			VE_LFS_idlestanding.VE_LFS_IdleStandingController();
		}
		private void VE_LFS_IdleSittingAnimatorController()
		{
			VE_LFS_idlesitting.VE_LFS_IdleSittingController();
		}
	}
}