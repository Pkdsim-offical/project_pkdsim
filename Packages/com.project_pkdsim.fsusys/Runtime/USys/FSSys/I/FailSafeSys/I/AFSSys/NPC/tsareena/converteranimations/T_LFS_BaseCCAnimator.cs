using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Tsareena.converteranimations.IdleTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Tsareena.converteranimations.SittingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Tsareena.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Tsareena.converteranimations
{
	public class Tsareena_LFS_ConverterAnimatorController : MonoBehaviour 
	{
		private T_LFS_SittingTo Tsareena_LFS_sittingto;
		
		private T_LFS_WalkingTo Tsareena_LFS_walkingto;
		
		private T_LFS_IdleTo Tsareena_LFS_idleto;

		public void T_LFS_ConverterAnimatorController()
		{
			Tsareena_LFS_walkingto.T_LFS_WalkingToController();

			Tsareena_LFS_idleto.T_LFS_IdleToController();
			
			Tsareena_LFS_sittingto.T_LFS_SittingToController();	
		}
	}
}