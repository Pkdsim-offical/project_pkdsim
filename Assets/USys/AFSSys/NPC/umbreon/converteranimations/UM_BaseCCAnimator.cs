using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Umbreon.converteranimations.IdleTo;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Umbreon.converteranimations.SittingTo;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Umbreon.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Umbreon.converteranimations
{
	public class Umbreon_LFS_AnimatorCoverterController : MonoBehaviour 
	{
		private UM_LFS_IdleTo UM_LFS_idleTo;
		
		private UM_LFS_WalkingTo UM_LFS_WalkingTo;

		private UM_LFS_SittingTo UM_LFS_SittingTo;

		private void UM_LFS_BaseConverterAnimatorController()
		{
			UM_LFS_idleTo.UM_LFS_IdleToController();
			UM_LFS_WalkingTo.UM_LFS_WalkingToController();	
			UM_LFS_SittingTo.UM_LFS_SittingToController();
		}
	}
}