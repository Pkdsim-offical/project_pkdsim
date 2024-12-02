using project_pkdsim.Assets.Models.ANIMATOR.NPC.Leafeon.idlebaseanimation.IdleSitting;
using project_pkdsim.Assets.Models.ANIMATOR.NPC.Leafeon.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.NPC.Leafeon.idlebaseanimation
{
	public class LE_BaseIdleAnimator : MonoBehaviour 
	{
		private LE_IdleStanding LE_idlestanding;
		
		private LE_IdleSitting LE_idlesitting;

		private void LE_BaseIdleAnimatorController()
		{
			LE_idlestanding.LE_IdleStandingController();
			LE_idlesitting.LE_IdleSittingController();	
		}
	}
}