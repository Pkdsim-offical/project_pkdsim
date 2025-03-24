using project_pkdsim.Assets.Models.SCRIPTS.mouse.States.I;
using UnityEngine;

namespace project_pkdsim.Assets.Models.SCRIPTS.mouse
{
	public enum MouseStateEnum
	{
		LeftClick,
		RightClick,
		MiddleClick
	}
	
	public class MouseStates
	{
		public MouseStateEnum LeftClick()
		{
			// code to handle left click
			return MouseStateEnum.LeftClick;
		}

		public MouseStateEnum RightClick()
		{
			// code to handle right click
			return MouseStateEnum.RightClick;
		}

		public MouseStateEnum MiddleClick()
		{
			// code to handle middle click
			return MouseStateEnum.MiddleClick;
		}
	}
}