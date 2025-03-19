using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Vespiquen.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Vespiquen.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Vespiquen.converteranimations.IdleTo
{
	public class VE_LFS_IdleTo : MonoBehaviour 
	{
		private VE_LFS_IdleToRun Vespiquen_LFS_IdleToRun;
		private VE_LFS_IdleToWalk Vespiquen_LFS_IdleToWalk;

		public void VE_LFS_IdleToController()
		{
			Load_VE_LFS_idleToRun();
			Load_VE_LFS_idleToWalk();
		}
		private void Load_VE_LFS_idleToRun()
		{
			Vespiquen_LFS_IdleToRun.VE_LFS_IdleToRunController();
		}
		private void Load_VE_LFS_idleToWalk()
		{
			Vespiquen_LFS_IdleToWalk.VE_LFS_IdleToWalkController();
		}
	}
}