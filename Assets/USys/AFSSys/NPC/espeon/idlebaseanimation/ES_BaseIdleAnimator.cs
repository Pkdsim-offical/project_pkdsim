using project_pkdsim.Assets.Models.ANIMATOR.NPC.Espeon.idlebaseanimation.IdleSitting;
using project_pkdsim.Assets.Models.ANIMATOR.NPC.Espeon.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Espeon.idlebaseanimation
{
	public class Espeon_LFS_AnimatorIdleController : MonoBehaviour 
	{
		private ES_LFS_IdleStanding ES_idlestanding;
		
		private ES_LFS_IdleSitting ES_idlesitting;
		

		private void ES_LFS_BaseIdleAnimatorController()
		{
			ES_idlestanding.ES_LFS_IdleStandingController();
			ES_idlesitting.ES_LFS_IdleSittingController();	
		}
	}
}