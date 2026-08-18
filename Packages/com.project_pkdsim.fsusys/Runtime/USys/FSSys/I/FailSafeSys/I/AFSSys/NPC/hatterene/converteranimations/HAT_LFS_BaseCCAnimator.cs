using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Hatterene.converteranimations.IdleTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Hatterene.converteranimations.SittingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Hatterene.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Hatterene.converteranimations
{
	public class Hatterene_LFS_ConverterAnimatorController : MonoBehaviour 
	{
		private HAT_LFS_SittingTo Hatterene_LFS_sittingto;
		
		private HAT_LFS_WalkingTo Hatterene_LFS_walkingto;
		
		private HAT_LFS_IdleTo Hatterene_LFS_idleto;

		public void HAT_LFS_ConverterAnimatorController()
		{
			Hatterene_LFS_walkingto.HAT_LFS_WalkingToController();

			Hatterene_LFS_idleto.HAT_LFS_IdleToController();
			
			Hatterene_LFS_sittingto.HAT_LFS_SittingToController();	
		}
	}
}