using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Pheromosa.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Pheromosa.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Pheromosa.converteranimations.SittingTo
{
	public class PH_LFS_SittingTo : MonoBehaviour 
	{
		private PH_LFS_SittingToStartWalking Pheromosa_LFS_sittingToStartWalking;
		private PH_LFS_SittingToStanding Pheromosa_LFS_sittingToStanding;
		public void PH_LFS_SittingToController()
		{
			PH_LFS_SittingToStartWalking();
			PH_LFS_SittingToStanding();
		}
		private void PH_LFS_SittingToStartWalking()
		{
			Pheromosa_LFS_sittingToStartWalking.PH_LFS_SittingToStartWalkingController();
		}
		private void PH_LFS_SittingToStanding()
		{
			Pheromosa_LFS_sittingToStanding.PH_LFS_SittingToStandingController();
		}

	}
}