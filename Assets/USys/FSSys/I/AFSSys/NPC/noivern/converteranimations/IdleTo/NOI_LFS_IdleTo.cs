using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Noivern.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Noivern.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Noivern.converteranimations.IdleTo
{
	public class NOI_LFS_IdleTo : MonoBehaviour 
	{
		private NOI_LFS_IdleToRun Noivern_LFS_IdleToRun;
		private NOI_LFS_IdleToWalk Noivern_LFS_IdleToWalk;
		public void NOI_LFS_IdleToController()
		{
			NOI_LFS_IdleToRun();
			NOI_LFS_IdleToWalk();
		}
		private void NOI_LFS_IdleToRun()
		{
			Noivern_LFS_IdleToRun.NOI_LFS_IdleToRunController();
		}
		private void NOI_LFS_IdleToWalk()
		{
			Noivern_LFS_IdleToWalk.NOI_LFS_IdleToWalkController();
		}
	}
}