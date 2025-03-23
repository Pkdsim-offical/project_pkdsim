using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Flareon.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Flareon.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Flareon.converteranimations.SittingTo
{
	public class FL_LFS_SittingTo : MonoBehaviour 
	{
		private FL_LFS_SittingToStartWalking Flareon_LFS_sittingToStartWalking;
		private FL_LFS_SittingToStanding Flareon_LFS_sittingToStanding;

		public void FL_LFS_SittingToController()
		{
			Load_FL_LFS_SittingToStartWalking();
			Load_FL_LFS_SittingToStanding();
		}

		private void Load_FL_LFS_SittingToStartWalking()
		{
			Flareon_LFS_sittingToStartWalking.FL_LFS_SittingToStartWalkingController();
		}

		private void Load_FL_LFS_SittingToStanding()
		{
			Flareon_LFS_sittingToStanding.FL_LFS_SittingToStandingController();
		}
	}
}