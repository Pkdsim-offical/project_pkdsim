using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Hatterene.idlebaseanimation.IdleSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Hatterene.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Hatterene.idlebaseanimation
{
	public class Hatterene_LFS_IdleAnimatorController : MonoBehaviour 
	{
		private HAT_LFS_IdleStanding HAT_LFS_idlestanding;
		
		private HAT_LFS_IdleSitting HAT_LFS_idlesitting;
		
		public void	HAT_LFS_IdleAnimatorController()
		{
			HAT_LFS_IdleStandingAnimatorController();
			HAT_LFS_IdleSittingAnimatorController();
		}
		private void HAT_LFS_IdleStandingAnimatorController()
		{
			HAT_LFS_idlestanding.HAT_LFS_IdleStandingController();
		}
		private void HAT_LFS_IdleSittingAnimatorController()
		{
			HAT_LFS_idlesitting.HAT_LFS_IdleSittingController();
		}
	}
}