using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lopunny.idlebaseanimation.IdleSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lopunny.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lopunny.idlebaseanimation
{
	public class Lopunny_LFS_IdleAnimatorController : MonoBehaviour 
	{
		private LO_LFS_IdleStanding Lopunny_LFS_idlestanding;
		
		private LO_LFS_IdleSitting Lopunny_LFS_idlesitting;
		
		public void	LO_LFS_IdleAnimatorController()
		{
			LO_LFS_IdleStandingAnimatorController();
			LO_LFS_IdleSittingAnimatorController();
		}
		private void LO_LFS_IdleStandingAnimatorController()
		{
			Lopunny_LFS_idlestanding.LO_LFS_IdleStandingController();
		}
		private void LO_LFS_IdleSittingAnimatorController()
		{
			Lopunny_LFS_idlesitting.LO_LFS_IdleSittingController();
		}
	}
}