using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Beedrill.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Beedrill.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Beedrill.converteranimations.IdleTo
{
	public class BE_LFS_IdleTo : MonoBehaviour 
	{
		private BE_LFS_IdleToRun Beedrill_LFS_IdleToRun;
		private BE_LFS_IdleToWalk Beedrill_LFS_IdleToWalk;

		public void BE_LFS_IdleToController()
		{
			Load_BE_LFS_idleToRun();
			Load_BE_LFS_idleToWalk();
		}
		private void Load_BE_LFS_idleToRun()
		{
			Beedrill_LFS_IdleToRun.BE_LFS_IdleToRunController();
		}
		private void Load_BE_LFS_idleToWalk()
		{
			Beedrill_LFS_IdleToWalk.BE_LFS_IdleToWalkController();
		}
	}
}