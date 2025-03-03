using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Dragapult.idlebaseanimation.IdleSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Dragapult.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Dragapult.idlebaseanimation
{
	public class Dragapult_LFS_IdleAnimatorController : MonoBehaviour 
	{
		private DR_LFS_IdleStanding Dragapult_LFS_idlestanding;
		
		private DR_LFS_IdleSitting Dragapult_LFS_idlesitting;
		
		public void	DR_LFS_IdleAnimatorController()
		{
			DR_LFS_IdleStandingAnimatorController();
			DR_LFS_IdleSittingAnimatorController();
		}
		private void DR_LFS_IdleStandingAnimatorController()
		{
			Dragapult_LFS_idlestanding.DR_LFS_IdleStandingController();
		}
		private void DR_LFS_IdleSittingAnimatorController()
		{
			Dragapult_LFS_idlesitting.DR_LFS_IdleSittingController();
		}
	}
}