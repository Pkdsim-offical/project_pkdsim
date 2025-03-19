using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Absol.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Absol.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Absol.converteranimations.IdleTo
{
	public class AB_LFS_IdleTo : MonoBehaviour 
	{

		private AB_LFS_IdleToRun Absol_LFS_IdleToRun;
		private AB_LFS_IdleToWalk Absol_LFS_IdleToWalk;
		public void AB_LFS_IdleToController()
		{
			Load_AB_LFS_idleToRun();
			Load_AB_LFS_idleToWalk();
		}
		private void Load_AB_LFS_idleToRun()
		{
			Absol_LFS_IdleToRun.AB_LFS_IdleToRunController();
		}
		private void Load_AB_LFS_idleToWalk()
		{
			Absol_LFS_IdleToWalk.AB_LFS_IdleToWalkController();
		}
	}
}