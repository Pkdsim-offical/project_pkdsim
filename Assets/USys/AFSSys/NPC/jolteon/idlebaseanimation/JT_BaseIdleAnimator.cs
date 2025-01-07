using project_pkdsim.Assets.Models.ANIMATOR.NPC.Jolteon.idlebaseanimation.IdleSitting;
using project_pkdsim.Assets.Models.ANIMATOR.NPC.Jolteon.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Jolteon.idlebaseanimation
{
	public class Jolteon_LFS_AnimatorIdleController : MonoBehaviour 
	{
		private JT_LFS_IdleStanding JT_idlestanding;
		
		private JT_LFS_IdleSitting JT_idlesitting;

		private void JT_BaseIdleAnimatorController()
		{
			JT_idlestanding.JT_IdleStandingController();
			JT_idlesitting.JT_IdleSittingController();	
		}
	}
}