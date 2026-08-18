
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Umbreon.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Umbreon.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Umbreon.idlebaseanimations
{
	public class Umbreon_LFS_IdleAnimatorController : MonoBehaviour 
	{
		private UM_LFS_IdleStanding UM_idlestanding;
		
		private UM_LFS_IdleSitting UM_idlesitting;
		public void UM_LFS_IdleAnimatorController()
		{
			UM_idlestanding.UM_LFS_IdleStandingController();
			UM_idlesitting.UM_LFS_IdleSittingController();	
		}
	}
}
