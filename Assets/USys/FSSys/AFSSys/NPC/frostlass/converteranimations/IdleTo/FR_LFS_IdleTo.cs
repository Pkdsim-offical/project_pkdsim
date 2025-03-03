using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Frostlass.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Frostlass.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Frostlass.converteranimations.IdleTo
{
	public class FR_LFS_IdleTo : MonoBehaviour 
	{
		private FR_LFS_IdleToRun Frostlass_LFS_IdleToRun;
		private FR_LFS_IdleToWalk Frostlass_LFS_IdleToWalk;
		public void FR_LFS_IdleToController()
		{
			Load_FR_LFS_IdleToRun();
			Load_FR_LFS_IdleToWalk();
		}
		private void Load_FR_LFS_IdleToRun()
		{
			Frostlass_LFS_IdleToRun.FR_LFS_IdleToRunController();
		}
		private void Load_FR_LFS_IdleToWalk()
		{
			Frostlass_LFS_IdleToWalk.FR_LFS_IdleToWalkController();
		}
	}
}