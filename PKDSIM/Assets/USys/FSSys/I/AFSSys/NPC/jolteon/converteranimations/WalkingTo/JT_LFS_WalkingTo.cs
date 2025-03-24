using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.espeon.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Jolteon.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Jolteon.converteranimations.WalkingTo
{
	public class JT_LFS_WalkingTo : MonoBehaviour 
	{
		private JT_LFS_WalkingToStanding Jolteon_LFS_WalkingToStanding;
		private JT_LFS_WalkingToSitting Jolteon_LFS_WalkingToSitting;
		public void JT_LFS_WalkingToController()
		{
			Load_JT_LFS_WalkingToStanding();
			Load_JT_LFS_WalkingToWSitting();
		}
		private void Load_JT_LFS_WalkingToStanding()
		{
			Jolteon_LFS_WalkingToStanding.JT_LFS_WalkingToStandingController();
		}
		private void Load_JT_LFS_WalkingToWSitting()
		{
			Jolteon_LFS_WalkingToSitting.JT_LFS_WalkingToSittingController();
		}
	}
}