using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.PLAYER.converteranimations.IdleTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.PLAYER.converteranimations.SittingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.PLAYER.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.PLAYER.converteranimations
{
	public class Player_LFS_ConverterAnimatorController : MonoBehaviour 
	{
		private PL_LFS_SittingTo Player_LFS_sittingto;
		
		private PL_LFS_WalkingTo Player_LFS_walkingto;
		
		private PL_LFS_IdleTo Player_LFS_idleto;

		public void PL_LFS_ConverterAnimatorController()
		{
			Player_LFS_walkingto.PL_LFS_WalkingToController();

			Player_LFS_idleto.PL_LFS_IdleToController();
			
			Player_LFS_sittingto.PL_LFS_SittingToController();	
		}
	}
}