using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Vaporeon.idlebaseanimations.IdleSitting;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Vaporeon.idlebaseanimations.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Vaporeon.idlebaseanimation
{
	public class Vaporeon_LFS_AnimatorIdleController : MonoBehaviour 
	{
		private VP_LFS_IdleStanding VP_LFS_idlestanding;
		
		private VP_LFS_IdleSitting VP_LFS_idlesitting;
		private void VP_LFS_BaseIdleAnimatorController()
		{
			VP_LFS_idlestanding.VP_LFS_IdleStandingController();
			VP_LFS_idlesitting.VP_LFS_IdleSittingController();	
		}
	}
}