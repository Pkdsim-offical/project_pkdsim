using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Blaziken.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Blaziken.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Blaziken.converteranimations.SittingTo
{
	public class BL_LFS_SittingTo : MonoBehaviour 
	{
		private BL_LFS_SittingToStartWalking Blaziken_LFS_sittingToStartWalking;
		private BL_LFS_SittingToStanding Blaziken_LFS_sittingToStanding;
		public void BL_LFS_SittingToController()
		{
			BL_LFS_SittingToStartWalking();
			BL_LFS_SittingToStanding();
		}
		private void BL_LFS_SittingToStartWalking()
		{
			Blaziken_LFS_sittingToStartWalking.BL_LFS_SittingToStartWalkingController();
		}
		private void BL_LFS_SittingToStanding()
		{
			Blaziken_LFS_sittingToStanding.BL_LFS_SittingToStandingController();
		}

	}
}