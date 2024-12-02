using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Flareon.idlebaseanimation.IdleSitting;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Flareon.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Flareon.idlebaseanimation
{
	public class Flareon_LFS_IdleAnimatorController : MonoBehaviour 
	{
		private FL_LFS_IdleStanding FL_LFS_idlestanding;
		
		private FL_LFS_IdleSitting FL_LFS_idlesitting;
		
		public void	FL_LFS_IdleAnimatorController()
		{
			FL_LFS_IdleStandingAnimatorController();
			FL_LFS_IdleSittingAnimatorController();
		}
		private void FL_LFS_IdleStandingAnimatorController()
		{
			FL_LFS_idlestanding.FL_LFS_IdleStandingController();
		}
		private void FL_LFS_IdleSittingAnimatorController()
		{
			FL_LFS_idlesitting.FL_LFS_IdleSittingController();
		}
	}
}