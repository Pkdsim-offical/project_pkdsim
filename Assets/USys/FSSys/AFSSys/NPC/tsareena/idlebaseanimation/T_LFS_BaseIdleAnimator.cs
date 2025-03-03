using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Tsareena.idlebaseanimation.IdleSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Tsareena.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Tsareena.idlebaseanimation
{
	public class Tsareena_LFS_IdleAnimatorController : MonoBehaviour 
	{
		private T_LFS_IdleStanding T_LFS_idlestanding;
		
		private T_LFS_IdleSitting T_LFS_idlesitting;
		
		public void	T_LFS_IdleAnimatorController()
		{
			T_LFS_IdleStandingAnimatorController();
			T_LFS_IdleSittingAnimatorController();
		}
		private void T_LFS_IdleStandingAnimatorController()
		{
			T_LFS_idlestanding.T_LFS_IdleStandingController();
		}
		private void T_LFS_IdleSittingAnimatorController()
		{
			T_LFS_idlesitting.T_LFS_IdleSittingController();
		}
	}
}