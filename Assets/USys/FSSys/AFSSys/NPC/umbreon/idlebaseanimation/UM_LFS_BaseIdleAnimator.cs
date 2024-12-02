
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Umbreon.idlebaseanimation.IdleSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Umbreon.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Umbreon.idlebaseanimations
{
	public class Umbreon_LFS_AnimatorBaseIdleController : MonoBehaviour 
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
