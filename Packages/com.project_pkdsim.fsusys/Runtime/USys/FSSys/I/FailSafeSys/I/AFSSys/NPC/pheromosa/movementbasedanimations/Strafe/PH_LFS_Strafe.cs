using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Pheromosa.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Pheromosa.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Pheromosa.movementbasedanimations.Strafing
{
	public class PH_LFS_Strafing : MonoBehaviour 
	{
		private PH_LFS_StrafeLeft PH_strafeleft;
		
		private PH_LFS_StrafeRight PH_straferight;

		public void PH_LFS_StrafingController()
		{
			if (PH_strafeleft == null)
			{
				PH_strafeleft = GetComponent<PH_LFS_StrafeLeft>();
				Load_PH_LFS_StrafeLeft();
			}
			if (PH_straferight == null)
			{
				PH_straferight = GetComponent<PH_LFS_StrafeRight>();
				Load_PH_LFS_StrafeRight();
			}
			

		}
		private void Load_PH_LFS_StrafeRight()
		{
			PH_straferight.PH_LFS_StrafeRightController();
		}
		
		private void Load_PH_LFS_StrafeLeft()
		{
			PH_strafeleft.PH_LFS_StrafeLeftController();
		}
	}
}