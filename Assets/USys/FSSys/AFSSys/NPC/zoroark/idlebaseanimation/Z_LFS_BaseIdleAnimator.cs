using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Zoroark.idlebaseanimation.IdleSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Zoroark.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Zoroark.idlebaseanimation
{
	public class Zoroark_LFS_IdleAnimatorController : MonoBehaviour 
	{
		private Z_LFS_IdleStanding Zoroark_LFS_idlestanding;
		
		private Z_LFS_IdleSitting Zoroark_LFS_idlesitting;
		
		public void	Z_LFS_IdleAnimatorController()
		{
			Z_LFS_IdleStandingAnimatorController();
			Z_LFS_IdleSittingAnimatorController();
		}
		private void Z_LFS_IdleStandingAnimatorController()
		{
			Zoroark_LFS_idlestanding.Z_LFS_IdleStandingController();
		}
		private void Z_LFS_IdleSittingAnimatorController()
		{
			Zoroark_LFS_idlesitting.Z_LFS_IdleSittingController();
		}
	}
}