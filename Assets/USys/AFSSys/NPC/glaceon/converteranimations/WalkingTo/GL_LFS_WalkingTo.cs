using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Glaceon.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Glaceon.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Glaceon.converteranimations.WalkingTo
{
	public class GL_LFS_WalkingTo : MonoBehaviour 
	{
		private GL_LFS_WalkingToStanding Glaceon_LFS_WalkingToStanding;
		
		private GL_LFS_WalkingToSitting Glaceon_LFS_WalkingToSitting;
		public void GL_LFS_WalkingToController() 
		{
	
		}
		private void Load_GL_LFS_WalkingToStanding() 
		{
			Glaceon_LFS_WalkingToStanding.GL_LFS_WalkingToStandingController();
		}
		private void Load_GL_LFS_WalkingToSitting()
		{
			Glaceon_LFS_WalkingToSitting.GL_LFS_WalkingToSittingController();
		}
	}
}