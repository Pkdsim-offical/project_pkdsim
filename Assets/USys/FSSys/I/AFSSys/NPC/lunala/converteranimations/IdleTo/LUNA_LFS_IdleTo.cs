using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lunala.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lunala.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lunala.converteranimations.IdleTo
{
	public class LUNA_LFS_IdleTo : MonoBehaviour 
	{
		private LUNA_LFS_IdleToRun Lunala_LFS_IdleToRun;
		private LUNA_LFS_IdleToWalk Lunala_LFS_IdleToWalk;

		public void LUNA_LFS_IdleToController()
		{
			Load_LUNA_LFS_idleToRun();
			Load_LUNA_LFS_idleToWalk();
		}
		private void Load_LUNA_LFS_idleToRun()
		{
			Lunala_LFS_IdleToRun.LUNA_LFS_IdleToRunController();
		}
		private void Load_LUNA_LFS_idleToWalk()
		{
			Lunala_LFS_IdleToWalk.LUNA_LFS_IdleToWalkController();
		}
	}
}