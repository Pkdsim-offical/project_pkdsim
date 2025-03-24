using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Espeon.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Espeon.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Espeon.converteranimations.IdleTo
{
	public class ES_LFS_IdleTo : MonoBehaviour 
	{
		private ES_LFS_IdleToRun Espeon_IdleToRun;
		private ES_LFS_IdleToWalk Espeon_IdleToWalk;
		public void ES_LFS_IdleToController()
		{
			Load_ES_LFS_IdleToWalkController();
			Load_ES_LFS_IdleToRunController();
		}
		private void Load_ES_LFS_IdleToWalkController() 
		{
			Espeon_IdleToWalk.ES_LFS_IdleToWalkController();
		}
		private void Load_ES_LFS_IdleToRunController() 
		{
			Espeon_IdleToRun.ES_LFS_IdleToRunController();
		}
	}
}