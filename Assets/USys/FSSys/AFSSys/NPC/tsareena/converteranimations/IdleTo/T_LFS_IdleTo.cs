using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Tsareena.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Tsareena.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Tsareena.converteranimations.IdleTo
{
	public class T_LFS_IdleTo : MonoBehaviour 
	{
		private T_LFS_IdleToRun Tsareena_LFS_IdleToRun;
		private T_LFS_IdleToWalk Tsareena_LFS_IdleToWalk;
		public void T_LFS_IdleToController()
		{
			Load_T_LFS_idleToRun();
			Load_T_LFS_idleToWalk();
		}
		private void Load_T_LFS_idleToRun()
		{
			Tsareena_LFS_IdleToRun.T_LFS_IdleToRunController();
		}
		private void Load_T_LFS_idleToWalk()
		{
			Tsareena_LFS_IdleToWalk.T_LFS_IdleToWalkController();
		}
	}
}