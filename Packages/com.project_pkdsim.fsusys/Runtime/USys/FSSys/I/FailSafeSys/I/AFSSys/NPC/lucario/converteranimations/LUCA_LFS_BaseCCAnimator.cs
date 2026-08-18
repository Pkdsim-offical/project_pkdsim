using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Lucario.converteranimations.IdleTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Lucario.converteranimations.SittingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Lucario.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Lucario.converteranimations
{
	public class Lucario_LFS_ConverterAnimatorController : MonoBehaviour 
	{
		private LUCA_LFS_SittingTo Lucario_LFS_sittingto;
		
		private LUCA_LFS_WalkingTo Lucario_LFS_walkingto;
		
		private LUCA_LFS_IdleTo Lucario_LFS_idleto;

		public void LUCA_LFS_ConverterAnimatorController()
		{
			Lucario_LFS_walkingto.LUCA_LFS_WalkingToController();

			Lucario_LFS_idleto.LUCA_LFS_IdleToController();
			
			Lucario_LFS_sittingto.LUCA_LFS_SittingToController();	
		}
	}
}