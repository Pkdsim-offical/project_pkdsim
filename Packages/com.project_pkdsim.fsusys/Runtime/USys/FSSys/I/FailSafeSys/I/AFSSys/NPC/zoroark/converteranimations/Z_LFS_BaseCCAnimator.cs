using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Zoroark.converteranimations.IdleTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Zoroark.converteranimations.SittingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Zoroark.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Zoroark.converteranimations
{
	public class Zoroark_LFS_ConverterAnimatorController : MonoBehaviour 
	{
		private Z_LFS_SittingTo Zoroark_LFS_sittingto;
		
		private Z_LFS_WalkingTo Zoroark_LFS_walkingto;
		
		private Z_LFS_IdleTo Zoroark_LFS_idleto;

		public void Z_LFS_ConverterAnimatorController()
		{
			Zoroark_LFS_walkingto.Z_LFS_WalkingToController();

			Zoroark_LFS_idleto.Z_LFS_IdleToController();
			
			Zoroark_LFS_sittingto.Z_LFS_SittingToController();	
		}
	}
}