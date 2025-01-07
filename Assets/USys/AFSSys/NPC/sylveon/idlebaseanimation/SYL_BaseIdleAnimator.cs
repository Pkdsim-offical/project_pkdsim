using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Sylveon.idlebaseanimations.IdleSitting;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Sylveon.idlebaseanimations.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Sylveon.idlebaseanimation
{
	public class Sylveon_LFS_IdleAnimatorController : MonoBehaviour 
	{
		private SYL_LFS_IdleStanding SYL_idlestanding;
		
		private SYL_LFS_IdleSitting SYL_idlesitting;

		private void SYL_BaseIdleAnimatorController()
		{
			SYL_idlestanding.SYL_IdleStandingController();
			SYL_idlesitting.SYL_IdleSittingController();	
		}
	}
}