using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Lucario.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Lucario.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Lucario.converteranimations.SittingTo
{
	public class LUCA_LFS_SittingTo : MonoBehaviour 
	{
		private LUCA_LFS_SittingToStartWalking Lucario_LFS_sittingToStartWalking;
		private LUCA_LFS_SittingToStanding Lucario_LFS_sittingToStanding;
		public void LUCA_LFS_SittingToController()
		{
			LUCA_LFS_SittingToStartWalking();
			LUCA_LFS_SittingToStanding();
		}
		private void LUCA_LFS_SittingToStartWalking()
		{
			Lucario_LFS_sittingToStartWalking.LUCA_LFS_SittingToStartWalkingController();
		}
		private void LUCA_LFS_SittingToStanding()
		{
			Lucario_LFS_sittingToStanding.LUCA_LFS_SittingToStandingController();
		}
	}
}