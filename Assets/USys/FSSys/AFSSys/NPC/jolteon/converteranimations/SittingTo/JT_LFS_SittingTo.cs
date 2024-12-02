using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Jolteon.converteranimations.SittingTo.SittingToStanding;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Jolteon.converteranimations.SittingTo.SittingToStartWalking;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Jolteon.converteranimations.SittingTo
{
	public class JT_LFS_SittingTo : MonoBehaviour 
	{		
		private JT_LFS_SittingToStartWalking Jolteon_LFS_sittingToStartWalking;
		private JT_LFS_SittingToStanding Jolteon_LFS_sittingToStanding;
		public void JT_LFS_SittingToController()
		{
			JT_LFS_SittingToStartWalking();
			JT_LFS_SittingToStanding();
		}
		private void JT_LFS_SittingToStartWalking()
		{
			Jolteon_LFS_sittingToStartWalking.JT_LFS_SittingToStartWalkingController();
		}
		private void JT_LFS_SittingToStanding()
		{
			Jolteon_LFS_sittingToStanding.JT_LFS_SittingToStandingController();
		}
	}
}