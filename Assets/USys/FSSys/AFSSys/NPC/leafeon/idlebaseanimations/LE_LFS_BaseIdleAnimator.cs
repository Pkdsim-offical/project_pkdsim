using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Leafeon.idlebaseanimations.IdleSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Leafeon.idlebaseanimations.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Leafeon.idlebaseanimations
{
	public class  Leafeon_LFS_AnimatorBaseIdleController  : MonoBehaviour 
	{
		private LE_LFS_IdleStanding LE_LFS_idlestanding;
		
		private LE_LFS_IdleSitting LE_LFS_idlesitting;

		public void LE_LFS_IdleAnimatorController()
		{
			LE_LFS_idlestanding.LE_LFS_IdleStandingController();
			
			LE_LFS_idlesitting.LE_LFS_IdleSittingController();	
		}
	}
}