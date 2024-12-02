using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Umbreon.converteranimations.SittingTo.SittingToStanding;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Umbreon.converteranimations.SittingTo.SittingToStartWalking;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Umbreon.converteranimations.SittingTo
{
	public class UM_LFS_SittingTo : MonoBehaviour 
	{
		private UM_LFS_SittingToStartWalking Umbreon_LFS_sittingToStartWalking;
		private UM_LFS_SittingToStanding Umbreon_LFS_sittingToStanding;
		public void UM_LFS_SittingToController()
		{
			UM_LFS_SittingToStartWalking();
			UM_LFS_SittingToStanding();
		}
		private void UM_LFS_SittingToStartWalking()
		{
			Umbreon_LFS_sittingToStartWalking.UM_LFS_SittingToStartWalkingController();
		}
		private void UM_LFS_SittingToStanding()
		{
			Umbreon_LFS_sittingToStanding.UM_LFS_SittingToStandingController();
		}
	}
}