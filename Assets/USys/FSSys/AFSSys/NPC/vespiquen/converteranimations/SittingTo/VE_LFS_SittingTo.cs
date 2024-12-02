using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Vespiquen.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Vespiquen.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Vespiquen.converteranimations.SittingTo
{
	public class VE_LFS_SittingTo : MonoBehaviour 
	{
		private VE_LFS_SittingToStartWalking Vespiquen_LFS_sittingToStartWalking;
		private VE_LFS_SittingToStanding Vespiquen_LFS_sittingToStanding;
		public void VE_LFS_SittingToController()
		{
			VE_LFS_SittingToStartWalking();
			VE_LFS_SittingToStanding();
		}
		private void VE_LFS_SittingToStartWalking()
		{
			Vespiquen_LFS_sittingToStartWalking.VE_LFS_SittingToStartWalkingController();
		}
		private void VE_LFS_SittingToStanding()
		{
			Vespiquen_LFS_sittingToStanding.VE_LFS_SittingToStandingController();
		}

	}
}