using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Zoroark.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Zoroark.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Zoroark.converteranimations.WalkingTo
{
	public class Z_LFS_WalkingTo : MonoBehaviour 
	{
		private Z_LFS_WalkingToStanding Zoroark_LFS_WalkingToStanding;
		private Z_LFS_WalkingToSitting Zoroark_LFS_WalkingToSitting;
		
		public void Z_LFS_WalkingToController() 
		{
			Load_Z_LFS_WalkingToStandingController();
			Load_Z_LFS_WalkingToSittingController();
		}

		private void Load_Z_LFS_WalkingToStandingController()
		{
			Zoroark_LFS_WalkingToStanding.Z_LFS_WalkingToStandingController();
		}
		
		private void Load_Z_LFS_WalkingToSittingController()
		{
			Zoroark_LFS_WalkingToSitting.Z_LFS_WalkingToSittingController();
		}
	}
}