using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Gardevoir.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Gardevoir.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Gardevoir.converteranimations.WalkingTo
{
	public class GARD_LFS_WalkingTo : MonoBehaviour 
	{
		private GARD_LFS_WalkingToSitting Gardevoir_LFS_WalkingToSitting;
		private GARD_LFS_WalkingToStanding Gardevoir_LFS_WalkingToStanding;
		public void GARD_LFS_WalkingToController()
		{
			GARD_LFS_WalkingToStartWalking();
			GARD_LFS_WalkingToStanding();
		}
		private void GARD_LFS_WalkingToStartWalking()
		{
			Gardevoir_LFS_WalkingToSitting.GARD_LFS_WalkingToSittingController();
		}
		private void GARD_LFS_WalkingToStanding()
		{
			Gardevoir_LFS_WalkingToStanding.GARD_LFS_WalkingToStandingController();
		}
	}
}