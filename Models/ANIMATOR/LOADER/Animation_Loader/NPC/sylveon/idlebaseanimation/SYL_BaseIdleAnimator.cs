using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Sylveon.idlebaseanimation.IdleSitting;
using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Sylveon.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Sylveon.idlebaseanimation
{
	public class Sylveon_IdleAnimatorController : MonoBehaviour 
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