using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Jolteon.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Jolteon.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Jolteon.idlebaseanimation
{
	public class Jolteon_LFS_IdleAnimatorController : MonoBehaviour 
	{
		private JT_LFS_IdleStanding Jolteon_idlestanding;
		
		private JT_LFS_IdleSitting Jolteon_idlesitting;

		public void JT_LFS_Base_IdleAnimatorController()
		{
			Jolteon_idlestanding.JT_IdleStandingController();
			Jolteon_idlesitting.JT_IdleSittingController();	
		}
	}
}