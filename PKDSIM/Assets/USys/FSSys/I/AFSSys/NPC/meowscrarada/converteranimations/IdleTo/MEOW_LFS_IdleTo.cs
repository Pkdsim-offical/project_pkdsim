using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Meowscarada.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Meowscarada.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Meowscarada.converteranimations.IdleTo
{
	public class MEOW_LFS_IdleTo : MonoBehaviour 
	{
		private MEOW_LFS_IdleToRun Meowscarada_LFS_IdleToRun;
		private MEOW_LFS_IdleToWalk Meowscarada_LFS_IdleToWalk;

		public void MEOW_LFS_IdleToController()
		{
			Load_MEOW_LFS_IdleToRun();
			Load_MEOW_LFS_IdleToWalk();
		}
		private void Load_MEOW_LFS_IdleToRun()
		{
			Meowscarada_LFS_IdleToRun.MEOW_LFS_IdleToRunController();
		}
		private void Load_MEOW_LFS_IdleToWalk()
		{
			Meowscarada_LFS_IdleToWalk.MEOW_LFS_IdleToWalkController();
		}
	}
}