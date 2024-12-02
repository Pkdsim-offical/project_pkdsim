using project_pkdsim.Assets.Models.ANIMATOR.NPC.Flareon.idlebaseanimation.IdleSitting;
using project_pkdsim.Assets.Models.ANIMATOR.NPC.Flareon.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.NPC.Flareon.idlebaseanimation
{
	public class FL_BaseIdleAnimator : MonoBehaviour 
	{
		private FL_IdleStanding FL_idlestanding;
		
		private FL_IdleSitting FL_idlesitting;
		
		private void FL_BaseIdleAnimatorController()
		{
			FL_idlestanding.FL_IdleStandingController();
			FL_idlesitting.FL_IdleSittingController();	
		}
	}
}