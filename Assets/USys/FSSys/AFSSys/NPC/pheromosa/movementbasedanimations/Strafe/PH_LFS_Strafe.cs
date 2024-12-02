using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Pheromosa.movementbasedanimations.Strafe.StrafeLeft;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Pheromosa.movementbasedanimations.Strafe.StrafeRight;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Pheromosa.movementbasedanimations.Strafe
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