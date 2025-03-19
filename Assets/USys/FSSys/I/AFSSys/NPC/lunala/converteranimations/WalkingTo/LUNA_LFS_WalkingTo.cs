using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lunala.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lunala.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lunala.converteranimations.WalkingTo
{
	public class LUNA_LFS_WalkingTo : MonoBehaviour 
	{
		private LUNA_LFS_WalkingToSitting Lunala_LFS_WalkingToSitting;
		private LUNA_LFS_WalkingToStanding Lunala_LFS_WalkingToStanding;
		public void LUNA_LFS_WalkingToController()
		{
			LUNA_LFS_WalkingToSitting();
			LUNA_LFS_WalkingToStanding();
		}
		private void LUNA_LFS_WalkingToSitting()
		{
			Lunala_LFS_WalkingToSitting.LUNA_LFS_WalkingToSittingController();
		}
		private void LUNA_LFS_WalkingToStanding()
		{
			Lunala_LFS_WalkingToStanding.LUNA_LFS_WalkingToStandingController();
		}
	}
}