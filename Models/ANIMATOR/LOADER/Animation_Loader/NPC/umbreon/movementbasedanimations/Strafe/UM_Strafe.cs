using project_pkdsim.Assets.Models.ANIMATOR.NPC.Umbreon.movementbasedanimations.Strafe.StrafeLeft;
using project_pkdsim.Assets.Models.ANIMATOR.NPC.Umbreon.movementbasedanimations.Strafe.StrafeRight;
using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Umbreon.movementbasedanimations.Strafe
{
	public class UM_Strafing : MonoBehaviour 
	{
		private UM_StrafeLeft UM_strafeleft;
		
		private UM_StrafeRight UM_straferight;

		public void UM_StrafingController()
		{
			if (UM_strafeleft == null)
			{
				UM_strafeleft = GetComponent<UM_StrafeLeft>();
				Load_UM_StrafeLeft();
			}
			if (UM_straferight == null)
			{
				UM_straferight = GetComponent<UM_StrafeRight>();
				Load_UM_StrafeRight();
			}
			

		}
		private void Load_UM_StrafeRight()
		{
			UM_straferight.UM_StrafeRightController();
		}
		
		private void Load_UM_StrafeLeft()
		{
			UM_strafeleft.UM_StrafeLeftController();
		}
	}
}