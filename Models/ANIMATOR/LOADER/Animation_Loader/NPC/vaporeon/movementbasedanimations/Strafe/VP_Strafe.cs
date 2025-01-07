using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Vaporeon.movementbasedanimations.Strafe.StrafeLeft;
using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Vaporeon.movementbasedanimations.Strafe.StrafeRight;
using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Vaporeon.movementbasedanimations.Strafe
{
	public class VP_Strafing : MonoBehaviour 
	{
		VP_StrafeLeft VP_strafeleft;
		VP_StrafeRight VP_straferight;
		public void VP_StrafingController()
		{
			VP_StrafeLeftController();
			VP_StrafeRightController();
		}
		private void VP_StrafeLeftController()
		{
			VP_strafeleft.VP_StrafeLeftController();
		}
		private void VP_StrafeRightController()
		{
			VP_straferight.VP_StrafeRightController();
		}
	}
}