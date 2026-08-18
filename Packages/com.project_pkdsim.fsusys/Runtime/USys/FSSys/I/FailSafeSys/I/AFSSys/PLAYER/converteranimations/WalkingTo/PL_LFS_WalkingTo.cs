using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.PLAYER.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.PLAYER.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.PLAYER.converteranimations.WalkingTo
{
	public class PL_LFS_WalkingTo : MonoBehaviour 
	{
		private PL_LFS_WalkingToSitting Player_LFS_WalkingToSitting;
		private PL_LFS_WalkingToStanding Player_LFS_WalkingToStanding;
		public void PL_LFS_WalkingToController()
		{
			PL_LFS_WalkingToStartWalking();
			PL_LFS_WalkingToStanding();
		}
		private void PL_LFS_WalkingToStartWalking()
		{
			Player_LFS_WalkingToSitting.PL_LFS_WalkingToSittingController();
		}
		private void PL_LFS_WalkingToStanding()
		{
			Player_LFS_WalkingToStanding.PL_LFS_WalkingToStandingController();
		}
	}
}