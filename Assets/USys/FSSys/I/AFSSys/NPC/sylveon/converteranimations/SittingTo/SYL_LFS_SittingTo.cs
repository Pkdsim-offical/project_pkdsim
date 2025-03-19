using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Sylveon.converteranimations.SittingTo.SittingToStanding;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Sylveon.converteranimations.SittingTo.SittingToStartWalking;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Sylveon.converteranimations.SittingTo
{
	public class SYL_LFS_SittingTo : MonoBehaviour 
	{
		private SYL_LFS_SittingToStartWalking Sylveon_LFS_sittingToStartWalking;
		private SYL_LFS_SittingToStanding Sylveon_LFS_sittingToStanding;
		public void SYL_LFS_SittingToController()
		{
			SYL_LFS_SittingToStartWalking();
			SYL_LFS_SittingToStanding();
		}
		private void SYL_LFS_SittingToStartWalking()
		{
			Sylveon_LFS_sittingToStartWalking.SYL_LFS_SittingToStartWalkingController();
		}
		private void SYL_LFS_SittingToStanding()
		{
			Sylveon_LFS_sittingToStanding.SYL_LFS_SittingToStandingController();
		}
	}
}