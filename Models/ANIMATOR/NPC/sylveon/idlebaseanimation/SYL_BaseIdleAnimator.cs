using project_pkdsim.Assets.Models.ANIMATOR.NPC.Sylveon.idlebaseanimation.IdleSitting;
using project_pkdsim.Assets.Models.ANIMATOR.NPC.Sylveon.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.NPC.Sylveon.idlebaseanimation
{
	public class SYL_BaseIdleAnimator : MonoBehaviour 
	{
		private SYL_IdleStanding SYL_idlestanding;
		
		private SYL_IdleSitting SYL_idlesitting;

		private void SYL_BaseIdleAnimatorController()
		{
			SYL_idlestanding.SYL_IdleStandingController();
			SYL_idlesitting.SYL_IdleSittingController();	
		}
	}
}