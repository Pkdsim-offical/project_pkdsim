using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Absol.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Absol.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Absol.converteranimations.WalkingTo
{
	public class AB_LFS_WalkingTo : MonoBehaviour 
	{
		private AB_LFS_WalkingToSitting Absol_LFS_WalkingToSitting;
		private AB_LFS_WalkingToStanding Absol_LFS_WalkingToStanding;
		public void AB_LFS_WalkingToController()
		{
			AB_LFS_WalkingToStartWalking();
			AB_LFS_WalkingToStanding();
		}
		private void AB_LFS_WalkingToStartWalking()
		{
			Absol_LFS_WalkingToSitting.AB_LFS_WalkingToSittingController();
		}
		private void AB_LFS_WalkingToStanding()
		{
			Absol_LFS_WalkingToStanding.AB_LFS_WalkingToStandingController();
		}
	}
}