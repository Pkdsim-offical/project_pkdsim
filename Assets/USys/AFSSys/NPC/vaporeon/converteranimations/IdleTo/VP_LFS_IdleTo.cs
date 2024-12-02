using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Vaporeon.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Vaporeon.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Vaporeon.converteranimations.IdleTo
{
	public class VP_LFS_IdleTo : MonoBehaviour 
	{
		private VP_LFS_IdleToWalk VAPOR_idletowalk;
		
		private VP_LFS_IdleToRun VAPOR_idletorun;
		
		public void VP_LFS_IdleToController()
		{
			VAPOR_idletowalk.VP_LFS_IdleToWalkController();
			VAPOR_idletorun.VP_LFS_IdleToRunController();
		}
	}
}