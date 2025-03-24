using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Absol.idlebaseanimation.IdleSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Absol.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Absol.idlebaseanimation
{
	public class Absol_LFS_IdleAnimatorController : MonoBehaviour 
	{
		private AB_LFS_IdleStanding Absol_LFS_idlestanding;
		
		private AB_LFS_IdleSitting Absol_LFS_idlesitting;
		
		public void	AB_LFS_IdleAnimatorController()
		{
			AB_LFS_IdleStandingAnimatorController();
			AB_LFS_IdleSittingAnimatorController();
		}
		private void AB_LFS_IdleStandingAnimatorController()
		{
			Absol_LFS_idlestanding.AB_LFS_IdleStandingController();
		}
		private void AB_LFS_IdleSittingAnimatorController()
		{
			Absol_LFS_idlesitting.AB_LFS_IdleSittingController();
		}
	}
}