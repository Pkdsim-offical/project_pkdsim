using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Garchomp.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Garchomp.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Garchomp.converteranimations.SittingTo
{
	public class GARC_LFS_SittingTo : MonoBehaviour 
	{
		private GARC_LFS_SittingToStartWalking Garchomp_LFS_sittingToStartWalking;
		private GARC_LFS_SittingToStanding Garchomp_LFS_sittingToStanding;
		public void GARC_LFS_SittingToController()
		{
			GARC_LFS_SittingToStartWalking();
			GARC_LFS_SittingToStanding();
		}
		private void GARC_LFS_SittingToStartWalking()
		{
			Garchomp_LFS_sittingToStartWalking.GARC_LFS_SittingToStartWalkingController();
		}
		private void GARC_LFS_SittingToStanding()
		{
			Garchomp_LFS_sittingToStanding.GARC_LFS_SittingToStandingController();
		}

	}
}