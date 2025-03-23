using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Beedrill.idlebaseanimation.IdleSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Beedrill.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Beedrill.idlebaseanimation
{
	public class Beedrill_LFS_IdleAnimatorController : MonoBehaviour 
	{
		private BE_LFS_IdleStanding Beedrill_LFS_idlestanding;
		
		private BE_LFS_IdleSitting Beedrill_LFS_idlesitting;
		
		public void	BE_LFS_IdleAnimatorController()
		{
			BE_LFS_IdleStandingAnimatorController();
			BE_LFS_IdleSittingAnimatorController();
		}
		private void BE_LFS_IdleStandingAnimatorController()
		{
			Beedrill_LFS_idlestanding.BE_LFS_IdleStandingController();
		}
		private void BE_LFS_IdleSittingAnimatorController()
		{
			Beedrill_LFS_idlesitting.BE_LFS_IdleSittingController();
		}
	}
}