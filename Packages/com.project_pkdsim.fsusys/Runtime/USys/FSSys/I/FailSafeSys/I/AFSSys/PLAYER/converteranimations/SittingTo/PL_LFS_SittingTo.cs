using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.PLAYER.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.PLAYER.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.PLAYER.converteranimations.SittingTo
{
	public class PL_LFS_SittingTo : MonoBehaviour 
	{
		private PL_LFS_SittingToStartWalking Player_LFS_sittingToStartWalking;
		private PL_LFS_SittingToStanding Player_LFS_sittingToStanding;
		public void PL_LFS_SittingToController()
		{
			PL_LFS_SittingToStartWalking();
			PL_LFS_SittingToStanding();
		}
		private void PL_LFS_SittingToStartWalking()
		{
			Player_LFS_sittingToStartWalking.PL_LFS_SittingToStartWalkingController();
		}
		private void PL_LFS_SittingToStanding()
		{
			Player_LFS_sittingToStanding.PL_LFS_SittingToStandingController();
		}

	}
}