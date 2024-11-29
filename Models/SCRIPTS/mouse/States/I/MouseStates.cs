using project_pkdsim.Assets.t_posed_models.SCRIPTS.mouse.States.mouse_leftclick;
using project_pkdsim.Assets.t_posed_models.SCRIPTS.mouse.States.mouse_middleclick;
using project_pkdsim.Assets.t_posed_models.SCRIPTS.mouse.States.mouse_rightclick;
using UnityEngine;

namespace project_pkdsim.Assets.Models.SCRIPTS.mouse.States.I
{
	public class MouseStates : MonoBehaviour
	{
		private mouse_LC mouse_Lc;
		private mouse_RC mouse_Rc;
		private mouse_MC mouse_Mc;

		public void LeftClick()
		{
			Debug.Log("Left Click");
		}
		public void RightClick()
		{
			Debug.Log("Right Click");
		}
		public void MiddleClick()
		{
			Debug.Log("Middle Click");
		}
	}
}