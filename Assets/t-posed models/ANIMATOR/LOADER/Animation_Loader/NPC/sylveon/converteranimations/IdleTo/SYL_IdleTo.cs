using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Sylveon.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Sylveon.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Sylveon.converteranimations.IdleTo
{
	public class SYL_IdleTo : MonoBehaviour 
	{
		private SYL_IdleToRun Sylveon_IdleToRun;
		private SYL_IdleToWalk Sylveon_IdleToWalk;
		public void SYL_IdleToController()
		{
			Load_SYL_idleToRun();
			Load_SYL_idleToWalk();
		}
		private void Load_SYL_idleToRun()
		{
			Sylveon_IdleToRun.SYL_IdleToRunController();
		}
		private void Load_SYL_idleToWalk()
		{
			Sylveon_IdleToWalk.SYL_idleToWalkController();
		}
	}
}