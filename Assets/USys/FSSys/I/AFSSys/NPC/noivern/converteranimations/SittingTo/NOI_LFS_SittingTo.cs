using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Noivern.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Noivern.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Noivern.converteranimations.SittingTo
{
	public class NOI_LFS_SittingTo : MonoBehaviour 
	{
		private NOI_LFS_SittingToStartWalking Noivern_LFS_sittingToStartWalking;
		private NOI_LFS_SittingToStanding Noivern_LFS_sittingToStanding;
		public void NOI_LFS_SittingToController()
		{
			NOI_LFS_SittingToStartWalking();
			NOI_LFS_SittingToStanding();
		}
		private void NOI_LFS_SittingToStartWalking()
		{
			Noivern_LFS_sittingToStartWalking.NOI_LFS_SittingToStartWalkingController();
		}
		private void NOI_LFS_SittingToStanding()
		{
			Noivern_LFS_sittingToStanding.NOI_LFS_SittingToStandingController();
		}
	}
}