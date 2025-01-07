using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Glaceon.idlebaseanimation.IdleStanding;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Glaceon.idlebaseanimation.IdleSitting;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Glaceon.idlebaseanimation
{
	public class Glaceon_LFS_IdleAnimatorController : MonoBehaviour 
	{
		private GL_LFS_IdleStanding GL_LFS_idlestanding;
		
		private GL_LFS_IdleSitting GL_LFS_idlesitting;
		
		public void GL_LFS_IdleAnimatorController()
		{
			GL_LFS_IdleStandingAnimatorController();
			GL_LFS_IdleSittingAnimatorController();
		}
		private void GL_LFS_IdleStandingAnimatorController()
		{
			GL_LFS_idlestanding.GL_LFS_IdleStandingController();
		}
		private void GL_LFS_IdleSittingAnimatorController()
		{
			GL_LFS_idlesitting.GL_LFS_IdleSittingController();
		}
	}
}