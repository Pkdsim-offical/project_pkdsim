using project_pkdsim.Assets.Models.ANIMATOR.NPC.Glaceon.idlebaseanimation.IdleSitting;
using project_pkdsim.Assets.Models.ANIMATOR.NPC.Glaceon.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.NPC.Glaceon.idlebaseanimation
{
	public class GL_BaseIdleAnimator : MonoBehaviour 
	{
		private GL_IdleStanding GL_idlestanding;
		
		private GL_IdleSitting GL_idlesitting;
			

		private void GL_BaseIdleAnimatorController()
		{
			GL_idlestanding.GL_IdleStandingController();
			GL_idlesitting.GL_IdleSittingController();	
		}
	}
}