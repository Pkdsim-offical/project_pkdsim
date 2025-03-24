using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Vaporeon.idlebaseanimation.IdleSitting;
using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Vaporeon.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Vaporeon.idlebaseanimation
{
	public class Vaporeon_IdleAnimatorController : MonoBehaviour 
	{
		private VP_IdleStanding VP_idlestanding;
		
		private VP_IdleSitting VP_idlesitting;
		private void VP_BaseIdleAnimatorController()
		{
			VP_idlestanding.VP_IdleStandingController();
			VP_idlesitting.VP_IdleSittingController();	
		}
	}
}