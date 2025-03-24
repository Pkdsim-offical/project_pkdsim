using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Umbreon.converteranimations.IdleTo;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Umbreon.converteranimations.SittingTo;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Umbreon.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Umbreon.converteranimations
{
	public class Umbreon_LFS_AnimatorCoverterController : MonoBehaviour 
	{
		private UM_LFS_IdleTo Umbreon_LFS_idleTo;
		
		private UM_LFS_WalkingTo Umbreon_LFS_WalkingTo;

		private UM_LFS_SittingTo Umbreon_LFS_SittingTo;

		public void UM_LFS_ConverterToAnimatorController()
		{
			Umbreon_LFS_idleTo.UM_LFS_IdleToController();
			Umbreon_LFS_WalkingTo.UM_LFS_WalkingToController();	
			Umbreon_LFS_SittingTo.UM_LFS_SittingToController();
		}
	}
}