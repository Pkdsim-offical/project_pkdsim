using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Leafeon.converteranimations.IdleTo;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Leafeon.converteranimations.SittingTo;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Leafeon.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Leafeon.converteranimations
{
	public class Leafeon_LFS_AnimatorBaseConverterController : MonoBehaviour 
	{
		private LE_LFS_IdleTo LE_LFS_idleTo;
		
		private LE_LFS_WalkingTo LE_LFS_WalkingTo;

		private LE_LFS_SittingTo LE_LFS_SittingTo;
		private void LE_LFS_BaseConverterAnimatorController()
		{
			LE_LFS_idleTo.LE_LFS_IdleToController();
			LE_LFS_WalkingTo.LE_LFS_WalkingToController();	
			LE_LFS_SittingTo.LE_LFS_SittingToController();
		}
	}
}