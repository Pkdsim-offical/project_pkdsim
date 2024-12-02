using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Glaceon.converteranimations.SittingTo;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Glaceon.converteranimations.WalkingTo;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Glaceon.converteranimations.IdleTo;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Glaceon.converteranimations
{
	public class Glaceon_LFS_CoverterAnimatorController : MonoBehaviour 
	{
		private GL_LFS_SittingTo Glaceon_LFS_sittingto;
		
		private GL_LFS_IdleTo Glaceon_LFS_Idleto;
		private GL_LFS_WalkingTo Glaceon_LFS_walkingto;

		public void GL_LFS_ConvertToAnimatorController()
		{
			Glaceon_LFS_sittingto.GL_LFS_SittingToController();

			Glaceon_LFS_Idleto.GL_LFS_IdleToController();
			
			Glaceon_LFS_walkingto.GL_LFS_WalkingToController();
		}

	}
}