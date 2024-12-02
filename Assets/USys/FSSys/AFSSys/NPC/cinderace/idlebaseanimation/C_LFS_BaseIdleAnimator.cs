using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Cinderace.idlebaseanimation.IdleSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Cinderace.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Cinderace.idlebaseanimation
{
	public class Cinderace_LFS_IdleAnimatorController : MonoBehaviour 
	{
		private C_LFS_IdleStanding C_LFS_idlestanding;
		
		private C_LFS_IdleSitting C_LFS_idlesitting;
		
		public void	C_LFS_IdleAnimatorController()
		{
			C_LFS_IdleStandingAnimatorController();
			C_LFS_IdleSittingAnimatorController();
		}
		private void C_LFS_IdleStandingAnimatorController()
		{
			C_LFS_idlestanding.C_LFS_IdleStandingController();
		}
		private void C_LFS_IdleSittingAnimatorController()
		{
			C_LFS_idlesitting.C_LFS_IdleSittingController();
		}
	}
}