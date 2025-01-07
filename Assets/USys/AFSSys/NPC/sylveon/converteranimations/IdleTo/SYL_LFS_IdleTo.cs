using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Sylveon.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Sylveon.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Sylveon.converteranimations.IdleTo
{
	public class SYL_LFS_IdleTo : MonoBehaviour 
	{
		private SYL_LFS_IdleToRun IdleToRun;
		private SYL_LFS_IdleToWalk IdleToWalk;
		public void SYL_LFS_IdleToController()
		{
			Load_FL_LFS_idleToRun();
			Load_FL_LFS_idleToWalk();
		}
		private void Load_FL_LFS_idleToRun()
		{
			IdleToRun.SYL_LFS_IdleToRunController();
		}
		private void Load_FL_LFS_idleToWalk()
		{
			IdleToWalk.SYL_LFS_IdleToWalkController();
		}
	}
}