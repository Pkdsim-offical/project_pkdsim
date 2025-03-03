using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lunala.idlebaseanimation.IdleSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lunala.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lunala.idlebaseanimation
{
	public class Lunala_LFS_IdleAnimatorController : MonoBehaviour 
	{
		private LUNA_LFS_IdleStanding Lunala_LFS_idlestanding;
		
		private LUNA_LFS_IdleSitting Lunala_LFS_idlesitting;
		
		public void	LUNA_LFS_IdleAnimatorController()
		{
			LUNA_LFS_IdleStandingAnimatorController();
			LUNA_LFS_IdleSittingAnimatorController();
		}
		private void LUNA_LFS_IdleStandingAnimatorController()
		{
			Lunala_LFS_idlestanding.LUNA_LFS_IdleStandingController();
		}
		private void LUNA_LFS_IdleSittingAnimatorController()
		{
			Lunala_LFS_idlesitting.LUNA_LFS_IdleSittingController();
		}
	}
}