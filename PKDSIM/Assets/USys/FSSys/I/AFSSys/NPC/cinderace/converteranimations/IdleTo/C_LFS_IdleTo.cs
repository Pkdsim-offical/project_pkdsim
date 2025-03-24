using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Cinderace.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Cinderace.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Cinderace.converteranimations.IdleTo
{
	public class C_LFS_IdleTo : MonoBehaviour 
	{
		private C_LFS_IdleToRun Cinderace_LFS_IdleToRun;
		private C_LFS_IdleToWalk Cinderace_LFS_IdleToWalk;
		public void C_LFS_IdleToController()
		{
			Load_C_LFS_idleToRun();
			Load_C_LFS_idleToWalk();
		}
		private void Load_C_LFS_idleToRun()
		{
			Cinderace_LFS_IdleToRun.C_LFS_IdleToRunController();
		}
		private void Load_C_LFS_idleToWalk()
		{
			Cinderace_LFS_IdleToWalk.C_LFS_IdleToWalkController();
		}
	}
}