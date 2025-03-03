using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lopunny.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lopunny.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lopunny.converteranimations.WalkingTo
{
	public class LO_LFS_WalkingTo : MonoBehaviour 
	{
		private LO_LFS_WalkingToStanding Lopunny_LFS_WalkingToStanding;
		private LO_LFS_WalkingToSitting Lopunny_LFS_WalkingToSitting;
		public void LO_LFS_WalkingToController()
		{
			Load_LO_LFS_WalkingToStanding();
			Load_LO_LFS_WalkingToWSitting();
		}
		private void Load_LO_LFS_WalkingToStanding()
		{
			Lopunny_LFS_WalkingToStanding.LO_LFS_WalkingToStandingController();
		}
		private void Load_LO_LFS_WalkingToWSitting()
		{
			Lopunny_LFS_WalkingToSitting.LO_LFS_WalkingToSittingController();
		}
	}
}