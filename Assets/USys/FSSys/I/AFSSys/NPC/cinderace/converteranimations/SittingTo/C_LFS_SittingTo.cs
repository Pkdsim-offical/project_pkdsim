using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Cinderace.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Cinderace.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;
using Unity.Entities.UniversalDelegates;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Cinderace.converteranimations.SittingTo
{
	public class C_LFS_SittingTo : MonoBehaviour 
	{
		private C_LFS_SittingToStartWalking Cinderace_LFS_sittingToStartWalking;
		private C_LFS_SittingToStanding Cinderace_LFS_sittingToStanding;
		public void C_LFS_SittingToController()
		{
			C_LFS_SittingToStartWalking();
			C_LFS_SittingToStanding();
		}
		private void C_LFS_SittingToStartWalking()
		{
			Cinderace_LFS_sittingToStartWalking.C_LFS_SittingToStartWalkingController();
		}
		private void C_LFS_SittingToStanding()
		{
			Cinderace_LFS_sittingToStanding.C_LFS_SittingToStandingController();
		}

	}
}