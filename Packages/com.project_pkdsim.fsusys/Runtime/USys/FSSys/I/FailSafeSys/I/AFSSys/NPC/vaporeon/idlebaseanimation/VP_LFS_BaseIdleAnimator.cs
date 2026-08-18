using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Vaporeon.idlebaseanimations.IdleSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Vaporeon.idlebaseanimations.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Vaporeon.idlebaseanimation
{
	public class Vaporeon_LFS_IdleAnimatorController : MonoBehaviour 
	{
		private VP_LFS_IdleStanding VP_LFS_idlestanding;
		
		private VP_LFS_IdleSitting VP_LFS_idlesitting;
		public void VP_LFS_Base_IdleAnimatorController()
		{
			VP_LFS_idlestanding.VP_LFS_IdleStandingController();
			VP_LFS_idlesitting.VP_LFS_IdleSittingController();	
		}
	}
}