using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Noivern.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Noivern.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Noivern.converteranimations.WalkingTo
{
	public class NOI_LFS_WalkingTo : MonoBehaviour 
	{
		private NOI_LFS_WalkingToSitting Noivern_LFS_WalkingToSitting;
		private NOI_LFS_WalkingToStanding Noivern_LFS_WalkingToStanding;
		public void NOI_LFS_WalkingToController()
		{
			NOI_LFS_WalkingToSitting();
			NOI_LFS_WalkingToStanding();
		}
		private void NOI_LFS_WalkingToSitting()
		{
			Noivern_LFS_WalkingToSitting.NOI_LFS_WalkingToSittingController();
		}
		private void NOI_LFS_WalkingToStanding()
		{
			Noivern_LFS_WalkingToStanding.NOI_LFS_WalkingToStandingController();
		}
	}
}