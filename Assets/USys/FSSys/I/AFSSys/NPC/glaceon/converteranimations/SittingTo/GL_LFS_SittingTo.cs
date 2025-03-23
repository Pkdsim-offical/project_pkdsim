using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Glaceon.converteranimations.SittingTo.SittingToStanding;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Glaceon.converteranimations.SittingTo.SittingToStartWalking;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Glaceon.converteranimations.SittingTo
{
	public class GL_LFS_SittingTo : MonoBehaviour 
	{
		private GL_LFS_SittingToStanding Glaceon_LFS_SittingToStanding;
		private GL_LFS_SittingToStartWalking Glaceon_LFS_SittingToStartWalking;
		public void GL_LFS_SittingToController()
		{
			Load_GL_LFS_SittingToStanding();
			Load_GL_LFS_SittingToStartWalking();
		}
		private void Load_GL_LFS_SittingToStanding()
		{
			Glaceon_LFS_SittingToStanding.GL_LFS_SittingToStandingController();
		}
		private void Load_GL_LFS_SittingToStartWalking()
		{
			Glaceon_LFS_SittingToStartWalking.GL_LFS_SittingToStartWalkingController();
		}
	}
}