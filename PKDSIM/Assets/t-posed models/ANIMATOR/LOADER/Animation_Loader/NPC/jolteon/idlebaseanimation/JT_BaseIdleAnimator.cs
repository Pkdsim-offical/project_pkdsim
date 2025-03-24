using project_pkdsim.Assets.Models.ANIMATOR.NPC.Jolteon.idlebaseanimation.IdleSitting;
using project_pkdsim.Assets.Models.ANIMATOR.NPC.Jolteon.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Jolteon.idlebaseanimation
{
	public class Jolteon_AnimatorIdleController : MonoBehaviour 
	{
		private JT_IdleStanding JT_idlestanding;
		
		private JT_IdleSitting JT_idlesitting;

		private void JT_BaseIdleAnimatorController()
		{
			JT_idlestanding.JT_IdleStandingController();
			JT_idlesitting.JT_IdleSittingController();	
		}
	}
}