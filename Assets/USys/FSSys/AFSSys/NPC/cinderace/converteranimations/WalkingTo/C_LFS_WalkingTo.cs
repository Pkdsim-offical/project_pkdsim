using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Cinderace.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Cinderace.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Cinderace.converteranimations.WalkingTo
{
	public class C_LFS_WalkingTo : MonoBehaviour 
	{
		private C_LFS_WalkingToSitting Cinderace_LFS_WalkingToSitting;
		private C_LFS_WalkingToStanding Cinderace_LFS_WalkingToStanding;
		public void C_LFS_WalkingToController()
		{
			C_LFS_WalkingToStartWalking();
			C_LFS_WalkingToStanding();
		}
		private void C_LFS_WalkingToStartWalking()
		{
			Cinderace_LFS_WalkingToSitting.C_LFS_WalkingToSittingController();
		}
		private void C_LFS_WalkingToStanding()
		{
			Cinderace_LFS_WalkingToStanding.C_LFS_WalkingToStandingController();
		}
	}
}