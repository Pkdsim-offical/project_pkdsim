using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Pheromosa.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Pheromosa.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Pheromosa.converteranimations.WalkingTo
{
	public class PH_LFS_WalkingTo : MonoBehaviour 
	{
		private PH_LFS_WalkingToSitting Pheromosa_LFS_WalkingToSitting;
		private PH_LFS_WalkingToStanding Pheromosa_LFS_WalkingToStanding;
		public void PH_LFS_WalkingToController() 
		{
			Load_PH_LFS_WalkingToSitting();
			Load_PH_LFS_WalkingToStanding();
		}
		private void Load_PH_LFS_WalkingToStanding()
		{
			Pheromosa_LFS_WalkingToStanding.PH_LFS_WalkingToStandingController();
		}
		private void Load_PH_LFS_WalkingToSitting()
		{
			Pheromosa_LFS_WalkingToSitting.PH_LFS_WalkingToSittingController();
		}
	}
}