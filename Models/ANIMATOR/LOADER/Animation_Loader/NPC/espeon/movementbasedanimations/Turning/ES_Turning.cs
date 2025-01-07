using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Espeon.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Espeon.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Espeon.movementbasedanimations.Turning
{
	public class ES_Turning : MonoBehaviour	
	{
		private ES_TurnLeft ES_turnleft;
		
		private ES_TurnRight ES_turnright;

		public void ES_TurningController()
		{
			if (ES_turnleft == null)
			{
				ES_turnleft = GetComponent<ES_TurnLeft>();
				Load_ES_TurningLeft();
			}
			if (ES_turnright == null)
			{
				ES_turnright = GetComponent<ES_TurnRight>();
				Load_ES_TurningRight();
			}
			

		}
		private void Load_ES_TurningRight()
		{
			ES_turnright.ES_TurningRightController();
		}
		
		private void Load_ES_TurningLeft()
		{
			ES_turnleft.ES_TurningLeftController();
		}
	}
}