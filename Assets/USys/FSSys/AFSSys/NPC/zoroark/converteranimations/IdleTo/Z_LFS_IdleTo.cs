using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Zoroark.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Zoroark.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Zoroark.converteranimations.IdleTo
{
	public class Z_LFS_IdleTo : MonoBehaviour 
	{
		private Z_LFS_IdleToRun Zoroark_LFS_IdleToRun;
		private Z_LFS_IdleToWalk Zoroark_LFS_IdleToWalk;
		public void Z_LFS_IdleToController()
		{
			Load_Z_LFS_idleToRun();
			Load_Z_LFS_idleToWalk();
		}
		private void Load_Z_LFS_idleToRun()
		{
			Zoroark_LFS_IdleToRun.Z_LFS_IdleToRunController();
		}
		private void Load_Z_LFS_idleToWalk()
		{
			Zoroark_LFS_IdleToWalk.Z_LFS_IdleToWalkController();
		}
	}
}