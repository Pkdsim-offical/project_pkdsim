using project_pkdsim.Assets.Models.ANIMATOR.NPC.Umbreon.idlebaseanimation.IdleSitting;
using project_pkdsim.Assets.Models.ANIMATOR.NPC.Umbreon.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Umbreon.idlebaseanimations
{
	public class Umbreon_LFS_AnimatorBaseIdleController : MonoBehaviour 
	{
		private UM_IdleStanding UM_idlestanding;
		
		private UM_IdleSitting UM_idlesitting;
		private void UM_BaseIdleAnimatorController()
		{
			UM_idlestanding.UM_IdleStandingController();
			UM_idlesitting.UM_IdleSittingController();	
		}
	}
}