using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Rock.Brick_necklace;
using UnityEngine;

namespace project_pkdsim.USysUItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Rock
{
	public class Rock_necklace : MonoBehaviour
	{

		private Brick_NecklaceItem Brick_NecklaceItem;

		public void Get_BrickNecklace()
		{
			Brick_NecklaceItem.GetBuilder();
		}
	}
}