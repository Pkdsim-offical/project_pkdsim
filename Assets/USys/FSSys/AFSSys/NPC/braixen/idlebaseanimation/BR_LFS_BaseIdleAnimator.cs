using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Braixen.idlebaseanimation.IdleSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Braixen.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Braixen.idlebaseanimation
{
	public class Braixen_LFS_IdleAnimatorController : MonoBehaviour 
	{
		private BR_LFS_IdleStanding BR_LFS_idlestanding;
		
		private BR_LFS_IdleSitting BR_LFS_idlesitting;
		
		public void	BR_LFS_IdleAnimatorController()
		{
			BR_LFS_IdleStandingAnimatorController();
			BR_LFS_IdleSittingAnimatorController();
		}
		private void BR_LFS_IdleStandingAnimatorController()
		{
			BR_LFS_idlestanding.BR_LFS_IdleStandingController();
		}
		private void BR_LFS_IdleSittingAnimatorController()
		{
			BR_LFS_idlesitting.BR_LFS_IdleSittingController();
		}
	}
}