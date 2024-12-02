using project_pkdsim.Assets.Models.ANIMATOR.NPC.Espeon.idlebaseanimation.IdleSitting;
using project_pkdsim.Assets.Models.ANIMATOR.NPC.Espeon.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.NPC.Espeon.idlebaseanimation
{
	public class ES_BaseIdleAnimator : MonoBehaviour 
	{
		private ES_IdleStanding ES_idlestanding;
		
		private ES_IdleSitting ES_idlesitting;
		

		private void ES_BaseIdleAnimatorController()
		{
			ES_idlestanding.ES_IdleStandingController();
			ES_idlesitting.ES_IdleSittingController();	
		}
	}
}