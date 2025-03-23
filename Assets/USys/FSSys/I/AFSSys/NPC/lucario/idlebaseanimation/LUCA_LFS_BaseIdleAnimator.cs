using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lucario.idlebaseanimation.IdleSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lucario.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lucario.idlebaseanimation
{
	public class Lucario_LFS_IdleAnimatorController : MonoBehaviour 
	{
		private LUCA_LFS_IdleStanding Lucario_LFS_IdleStanding;
		
		private LUCA_LFS_IdleSitting Lucario_LFS_IdleSitting;
		
		public void	LUCA_LFS_IdleAnimatorController()
		{
			LUCA_LFS_IdleStandingAnimatorController();
			LUCA_LFS_IdleSittingAnimatorController();
		}
		private void LUCA_LFS_IdleStandingAnimatorController()
		{
			Lucario_LFS_IdleStanding.LUCA_LFS_IdleStandingController();
		}
		private void LUCA_LFS_IdleSittingAnimatorController()
		{
			Lucario_LFS_IdleSitting.LUCA_LFS_IdleSittingController();
		}
	}
}