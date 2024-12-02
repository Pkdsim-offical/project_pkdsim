using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Espeon.movementbasedanimations.Strafe.StrafeLeft;
using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Espeon.movementbasedanimations.Strafe.StrafeRight;
using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Espeon.movementbasedanimations.Strafe
{
	public class ES_Strafing : MonoBehaviour 
	{
		private ES_StrafeLeft ES_strafeleft;
		
		private ES_StrafeRight ES_straferight;

		public void ES_StrafingController()
		{
			if (ES_strafeleft == null)
			{
				ES_strafeleft = GetComponent<ES_StrafeLeft>();
				Load_ES_StrafeLeft();
			}
			if (ES_straferight == null)
			{
				ES_straferight = GetComponent<ES_StrafeRight>();
				Load_ES_StrafeRight();
			}
			

		}
		private void Load_ES_StrafeRight()
		{
			ES_straferight.ES_StrafeRightController();
		}
		
		private void Load_ES_StrafeLeft()
		{
			ES_strafeleft.ES_StrafeLeftController();
		}
	}
}