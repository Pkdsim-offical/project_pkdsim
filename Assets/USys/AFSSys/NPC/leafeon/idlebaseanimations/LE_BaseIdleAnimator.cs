using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Leafeon.idlebaseanimations.IdleSitting;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Leafeon.idlebaseanimations.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Leafeon.idlebaseanimations
{
	public class  Leafeon_LFS_AnimatorBaseIdleController  : MonoBehaviour 
	{
		private LE_LFS_IdleStanding LE_idlestanding;
		
		private LE_LFS_IdleSitting LE_idlesitting;

		private void LE_BaseIdleAnimatorController()
		{
			LE_idlestanding.LE_LFS_IdleStandingController();
			LE_idlesitting.LE_LFS_IdleSittingController();	
		}
	}
}