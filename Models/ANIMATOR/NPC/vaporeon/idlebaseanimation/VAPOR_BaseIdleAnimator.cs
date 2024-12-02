using project_pkdsim.Assets.Models.ANIMATOR.NPC.Vaporeon.idlebaseanimation.IdleSitting;
using project_pkdsim.Assets.Models.ANIMATOR.NPC.Vaporeon.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.NPC.Vaporeon.idlebaseanimation
{
	public class VAPOR_BaseIdleAnimator : MonoBehaviour 
	{
		private VAPOR_IdleStanding VAPOR_idlestanding;
		
		private VAPOR_IdleSitting VAPOR_idlesitting;
		private void VAPOR_BaseIdleAnimatorController()
		{
			VAPOR_idlestanding.VAPOR_IdleStandingController();
			VAPOR_idlesitting.VAPOR_IdleSittingController();	
		}
	}
}