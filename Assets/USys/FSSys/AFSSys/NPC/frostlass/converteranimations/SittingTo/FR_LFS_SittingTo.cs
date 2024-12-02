using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Frostlass.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Frostlass.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Frostlass.converteranimations.SittingTo
{
	public class FR_LFS_SittingTo : MonoBehaviour 
	{
		private FR_LFS_SittingToStartWalking Frostlass_LFS_sittingToStartWalking;
		private FR_LFS_SittingToStanding Frostlass_LFS_sittingToStanding;
		public void FR_LFS_SittingToController()
		{
			FR_LFS_SittingToStartWalking();
			FR_LFS_SittingToStanding();
		}
		private void FR_LFS_SittingToStartWalking()
		{
			Frostlass_LFS_sittingToStartWalking.FR_LFS_SittingToStartWalkingController();
		}
		private void FR_LFS_SittingToStanding()
		{
			Frostlass_LFS_sittingToStanding.FR_LFS_SittingToStandingController();
		}

	}
}