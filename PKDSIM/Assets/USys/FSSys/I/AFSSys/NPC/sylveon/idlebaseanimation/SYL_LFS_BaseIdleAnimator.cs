using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Sylveon.idlebaseanimations.IdleSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Sylveon.idlebaseanimations.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Sylveon.idlebaseanimation
{
	public class Sylveon_LFS_IdleAnimatorController : MonoBehaviour 
	{
		private SYL_LFS_IdleStanding Sylveon_LFS_idlestanding;
		
		private SYL_LFS_IdleSitting Sylveon_LFS_idlesitting;

		public void SYL_LFS_IdleAnimatorController()
		{
			SYL_LFS_IdleSittingController();
			SYL_LFS_IdleStandingController();
		}
		private void SYL_LFS_IdleSittingController() 
		{
			Sylveon_LFS_idlesitting.SYL_IdleSittingController();
		}
		private void SYL_LFS_IdleStandingController() 
		{
			Sylveon_LFS_idlestanding.SYL_IdleStandingController();
		}
	}
}