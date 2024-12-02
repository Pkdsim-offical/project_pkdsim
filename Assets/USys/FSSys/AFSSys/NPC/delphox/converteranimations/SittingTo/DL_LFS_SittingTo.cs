using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Delphox.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Delphox.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Delphox.converteranimations.SittingTo
{
	public class DL_LFS_SittingTo : MonoBehaviour 
	{
		private DL_LFS_SittingToStartWalking Delphox_LFS_sittingToStartWalking;
		private DL_LFS_SittingToStanding Delphox_LFS_sittingToStanding;
		public void DL_LFS_SittingToController()
		{
			DL_LFS_SittingToStartWalking();
			DL_LFS_SittingToStanding();
		}
		private void DL_LFS_SittingToStartWalking()
		{
			Delphox_LFS_sittingToStartWalking.DL_LFS_SittingToStartWalkingController();
		}
		private void DL_LFS_SittingToStanding()
		{
			Delphox_LFS_sittingToStanding.DL_LFS_SittingToStandingController();
		}

	}
}