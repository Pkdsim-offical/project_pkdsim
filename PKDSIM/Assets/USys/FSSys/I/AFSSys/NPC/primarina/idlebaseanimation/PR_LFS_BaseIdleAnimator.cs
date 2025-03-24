using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Primarina.idlebaseanimation.IdleSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Primarina.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Primarina.idlebaseanimation
{
	public class Primarina_LFS_IdleAnimatorController : MonoBehaviour 
	{
		private PR_LFS_IdleStanding Primarina_LFS_idlestanding;
		
		private PR_LFS_IdleSitting Primarina_LFS_idlesitting;
		
		public void	PR_LFS_IdleAnimatorController()
		{
			PR_LFS_IdleStandingAnimatorController();
			PR_LFS_IdleSittingAnimatorController();
		}
		private void PR_LFS_IdleStandingAnimatorController()
		{
			Primarina_LFS_idlestanding.PR_LFS_IdleStandingController();
		}
		private void PR_LFS_IdleSittingAnimatorController()
		{
			Primarina_LFS_idlesitting.PR_LFS_IdleSittingController();
		}
	}
}