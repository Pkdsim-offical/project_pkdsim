using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lucario.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lucario.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lucario.converteranimations.IdleTo
{
	public class LUCA_LFS_IdleTo : MonoBehaviour 
	{
		private LUCA_LFS_IdleToRun Lucario_LFS_IdleToRun;
		private LUCA_LFS_IdleToWalk Lucario_LFS_IdleToWalk;

		public void LUCA_LFS_IdleToController()
		{
			Load_LUCA_LFS_idleToRun();
			Load_LUCA_LFS_idleToWalk();
		}
		private void Load_LUCA_LFS_idleToRun()
		{
			Lucario_LFS_IdleToRun.LUCA_LFS_IdleToRunController();
		}
		private void Load_LUCA_LFS_idleToWalk()
		{
			Lucario_LFS_IdleToWalk.LUCA_LFS_IdleToWalkController();
		}
	}
}