using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Vespiquen.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Vespiquen.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Vespiquen.converteranimations.WalkingTo
{
		public class VE_LFS_WalkingTo : MonoBehaviour 
	{
		private VE_LFS_WalkingToSitting Vespiquen_LFS_WalkingToSitting;
		private VE_LFS_WalkingToStanding Vespiquen_LFS_WalkingToStanding;
		public void VE_LFS_WalkingToController()
		{
			VE_LFS_WalkingToStartWalking();
			VE_LFS_WalkingToStanding();
		}
		private void VE_LFS_WalkingToStartWalking()
		{
			Vespiquen_LFS_WalkingToSitting.VE_LFS_WalkingToSittingController();
		}
		private void VE_LFS_WalkingToStanding()
		{
			Vespiquen_LFS_WalkingToStanding.VE_LFS_WalkingToStandingController();
		}
	}
}