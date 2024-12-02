using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Meowscarada.idlebaseanimation.IdleSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Meowscarada.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Meowscarada.idlebaseanimation
{
	public class Meowscarada_LFS_IdleAnimatorController : MonoBehaviour 
	{
		private MEOW_LFS_IdleStanding Meowscarada_LFS_idlestanding;
		
		private MEOW_LFS_IdleSitting Meowscarada_LFS_idlesitting;
		
		public void	MEOW_LFS_IdleAnimatorController()
		{
			MEOW_LFS_IdleStandingAnimatorController();
			MEOW_LFS_IdleSittingAnimatorController();
		}
		private void MEOW_LFS_IdleStandingAnimatorController()
		{
			Meowscarada_LFS_idlestanding.MEOW_LFS_IdleStandingController();
		}
		private void MEOW_LFS_IdleSittingAnimatorController()
		{
			Meowscarada_LFS_idlesitting.MEOW_LFS_IdleSittingController();
		}
	}
}