using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Vaporeon.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Vaporeon.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Vaporeon.converteranimations.IdleTo
{
	public class VP_LFS_IdleTo : MonoBehaviour 
	{
		private VP_LFS_IdleToWalk Vaporeon_IdleToWalk;
		
		private VP_LFS_IdleToRun Vaporeon_IdleToRun;
		
		public void VP_LFS_IdleToController()
		{
			Load_VP_LFS_IdleToWalkController();
			Load_VP_LFS_IdleToRunController();
		}
		private void Load_VP_LFS_IdleToWalkController() 
		{
			Vaporeon_IdleToWalk.VP_LFS_IdleToWalkController();
		}
		private void Load_VP_LFS_IdleToRunController() 
		{
			Vaporeon_IdleToRun.VP_LFS_IdleToRunController();
		}
	}
}