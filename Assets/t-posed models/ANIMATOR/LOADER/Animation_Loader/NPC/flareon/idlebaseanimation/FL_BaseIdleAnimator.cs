using project_pkdsim.Assets.Models.ANIMATOR.NPC.Flareon.idlebaseanimation.IdleSitting;
using project_pkdsim.Assets.Models.ANIMATOR.NPC.Flareon.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Flareon.idlebaseanimation
{
	public class Flareon_AnimatorIdleController : MonoBehaviour 
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