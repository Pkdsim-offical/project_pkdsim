using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Noivern.idlebaseanimation.IdleSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Noivern.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Noivern.idlebaseanimation
{
	public class Noivern_LFS_IdleAnimatorController : MonoBehaviour 
	{
		private NOI_LFS_IdleStanding Noivern_LFS_idlestanding;
		
		private NOI_LFS_IdleSitting Noivern_LFS_idlesitting;
		
		public void	NOI_LFS_IdleAnimatorController()
		{
			NOI_LFS_IdleStandingAnimatorController();
			NOI_LFS_IdleSittingAnimatorController();
		}
		private void NOI_LFS_IdleStandingAnimatorController()
		{
			Noivern_LFS_idlestanding.NOI_LFS_IdleStandingController();
		}
		private void NOI_LFS_IdleSittingAnimatorController()
		{
			Noivern_LFS_idlesitting.NOI_LFS_IdleSittingController();
		}
	}
}