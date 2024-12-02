using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Salazzle.idlebaseanimation.IdleSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Salazzle.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Salazzle.idlebaseanimation
{
	public class Salazzle_LFS_IdleAnimatorController : MonoBehaviour 
	{
		private SA_LFS_IdleStanding SA_LFS_idlestanding;
		
		private SA_LFS_IdleSitting SA_LFS_idlesitting;
		
		public void	SA_LFS_IdleAnimatorController()
		{
			SA_LFS_IdleStandingAnimatorController();
			SA_LFS_IdleSittingAnimatorController();
		}
		private void SA_LFS_IdleStandingAnimatorController()
		{
			SA_LFS_idlestanding.SA_LFS_IdleStandingController();
		}
		private void SA_LFS_IdleSittingAnimatorController()
		{
			SA_LFS_idlesitting.SA_LFS_IdleSittingController();
		}
	}
}